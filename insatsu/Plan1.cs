using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static insatsu.Form1;

namespace insatsu
{
    class Plan1
    {

        public int Machine_cnt; //印刷機の数
        public Input_Machine[] machines;   //印刷機
        public int Print_cnt;   //印刷物の種類の数
        public Input_Print[] prints; //印刷物
        private int R = 5000;

        public List<Machine> outmachines;   //出力用の印刷機リスト
        public Print_Type outtype;
        public Print outprint;  //出力する印刷物

        //テスト用
        public List<List<List<string>>> test_oomachine = new List<List<List<string>>>();
        public List<List<string>> test_schedule = new List<List<string>>();
        public List<string> test_oprint;

        public struct Input_Machine   //構造体で印刷機を表す
        {
            public int rpm;    //回転数
            public int color;  //色数
            public string size;    //サイズ
            public int size_a; //A4サイズを考えた時の数
            public int size_b; //B5サイズを考えた時の数
            public string name;

            public void rpm_set(int R)  //回転数の設定
            { this.rpm = R; }

            public void size_div()   //サイズをA4サイズに分割
            {
                this.size_a = 0;
                this.size_b = 0;
                if (this.size == "A全判" || this.size == "菊全判")
                {
                    this.size_a = 8;
                }
                else if (this.size == "A半裁" || this.size == "菊半裁")
                {
                    this.size_a = 4;
                }
                else if (this.size == "B全判" || this.size == "四六全判")
                {
                    this.size_b = 16;
                }
                else if (this.size == "B半裁" || this.size == "四六半裁")
                {
                    this.size_b = 8;
                }
            }
        }

        public struct Input_Print
        {
            public int deadline;   //納期
            public int circulation;    //部数
            public int color;  //色数
            public string size;    //サイズ
            public int size_a;
            public int size_b;
            public string side; //両面印刷/片面印刷
            public bool assign; //割り当てが完了しているかどうか,完了していればtrue
            public string name; //印刷物の名前

            public void size_div()  //サイズを最小サイズに分割
            {
                this.size_a = 0;
                this.size_b = 0;
                if (this.size == "A1") { this.size_a = 8; }
                else if (this.size == "A2") { this.size_a = 4; }
                else if (this.size == "A3") { this.size_a = 2; }
                else if (this.size == "A4") { this.size_a = 1; }
                else if (this.size == "B1") { this.size_b = 16; }
                else if (this.size == "B2") { this.size_b = 8; }
                else if (this.size == "B3") { this.size_b = 4; }
                else if (this.size == "B4") { this.size_b = 2; }
                else if (this.size == "B5") { this.size_b = 1; }
            }
        }

        public Plan1(Input_Machine[] machines, Input_Print[] prints)
        {
            this.machines = machines;
            this.prints = prints;

        }

        public void Make_OutMachine()  //出力用の印刷機リストを作成
        {
            //public List<Machine> outmachines;
            /*for(int cnt = 0; cnt < machines.Count(); cnt++)
            {
                if (machines[cnt].size_a != 0)
                {
                    outmachines.Add(new Machine(Print_Type.A, machines[cnt].size_a, "印刷機" + cnt.ToString()));
                }else if(machines[cnt].size_b != 0)
                {
                    outmachines.Add(new Machine(Print_Type.B, machines[cnt].size_b, "印刷機" + cnt.ToString()));
                }
            }*/

            //テスト用印刷機のリスト
            for (int cnt = 0; cnt < machines.Count(); cnt++)
            {
                test_oprint = new List<string>();
                test_oprint.Add("準備時間");
                test_schedule = new List<List<string>>();
                test_schedule.Add(test_oprint);
                test_oomachine.Add(test_schedule);
            }
        }

        public void Planning()
        {
            int m_index;
            int p_index = -1;   //割り当て対象の印刷物のインデックス
            int cnt, i;
            List<Input_Print> assign_printList = new List<Input_Print>();   //割り当てを行う印刷物のリスト

            Make_OutMachine();  //出力に渡す用の印刷機のリストを作成

            Array.Sort(machines, (a, b) => b.color - a.color);   //色数について降順ソート

            int np_index;   //割り当て不可の印刷物のインデックスを保持,p_indexに統一できるかも
            if (machines.Max(s => s.size_a) < prints.Max(s => s.size_a))    //使用する印刷機のサイズより大きいサイズの印刷物をはじく(assign=true割り当て終了にして割り当て不可であることを示す)
            {
                var noprints = Array.FindAll(prints, sp => sp.size_a == prints.Max(s => s.size_a)); //Maxサイズと同じ大きさの印刷物取得
                foreach (var np in noprints)
                {
                    np_index = Array.FindIndex(prints, n => n.name == np.name);
                    prints[np_index].assign = true;
                }
            }
            else if (machines.Max(s => s.size_b) < prints.Max(s => s.size_b))
            {
                var noprints = Array.FindAll(prints, sp => sp.size_b == prints.Max(s => s.size_b)); //Maxサイズと同じ大きさの印刷物取得
                foreach (var np in noprints)
                {
                    np_index = Array.FindIndex(prints, n => n.name == np.name);
                    prints[np_index].assign = true;
                }
            }

            while (prints.Any(s => s.assign == false)) //割り当て未完了の印刷物があるならば
            {

                for (cnt = 0; cnt < machines.Count(); cnt++)
                {
                    p_index = -1;
                    //サイズ・色数が完全に一致するものを探す
                    //var p = Prints.Select().Where(c => c.color == m_color).Where(sa => sa == m_size_a).Where(sb => m_size_b).Take(1);
                    //var p=Prints.FindIndex((s,c)=>s.size==m_size_b&&c==m_color);
                    var p1 = Array.FindIndex(prints, s => s.size_a == machines[cnt].size_a && s.size_b == machines[cnt].size_b && s.color == machines[cnt].color && s.assign == false);

                    if (p1 > -1)  //p1(一致するもの)が存在するならインデックスを,見つからなかったときは-1を返す
                    {
                        //Prints[p1]をMachines[cnt]に割り当てる
                        p_index = p1;
                        Assign_Print1(cnt, p_index);
                        prints[p_index].assign = true;  //割り当て終了
                        continue;
                    }

                    for (i = 0; i < machines[cnt].color; i++)   //印刷機の色数以下を探す
                    {
                        var p2 = Array.FindIndex(prints, s => s.size_a == machines[cnt].size_a && s.size_b == machines[cnt].size_b && s.color == (machines[cnt].color - i) && s.assign == false);    //サイズ等しく機械の色数以下のものを探す
                        if (p2 > -1)
                        {
                            p_index = p2;
                            Assign_Print1(cnt, p_index);
                            prints[p_index].assign = true;  //割り当て終了
                            break; //見つかれば外に出る&p2を割り当てる
                        }
                    }
                    if (p_index > -1)
                    {
                        continue;   //割り当てが行われたなら次の印刷機へ
                    }

                    //サイズ・色数共に印刷機以下のものがある場合
                    var available_print = prints.Any(s => s.size_a <= machines[cnt].size_a && s.size_b <= machines[cnt].size_b && s.color <= machines[cnt].color && s.assign == false);
                    if (available_print)  //該当する印刷物がある場合
                    {
                        //印刷機の割り当て可能領域を確保
                        int available_size_a = machines[cnt].size_a;
                        int available_size_b = machines[cnt].size_b;
                        string assign_printname = "noname";    //割り当て対象の印刷物名

                        while (available_size_a > 0 || available_size_b > 0)    //割り当て可能領域が残っているなら
                        {
                            var ap = Array.FindAll(prints, s => s.size_a <= available_size_a && s.size_b <= available_size_b && s.color <= machines[cnt].color && s.assign == false);
                            if (ap.Count() > 0)   //要素があれば(ないとき=0)
                            {
                                //1サイズ2色数の順に見たときに最大の印刷物を選択
                                var assign_print = ap.OrderByDescending(s => s.size_a).ThenByDescending(c => c.color).Take(1);
                                foreach (var pi in assign_print)
                                {
                                    assign_printname = pi.name.ToString();
                                }
                                p_index = Array.FindIndex(prints, n => n.name == assign_printname);   //名前からインデックス検索

                                assign_printList.Add(prints[p_index]);  //割り当て対象の印刷物を確保

                                prints[p_index].assign = true;  //割り当て終了にする

                                //割り当て可能領域の更新
                                available_size_a = available_size_a - prints[p_index].size_a;
                                available_size_b = available_size_b - prints[p_index].size_b;
                            }
                            else
                            {
                                break;  //割り当て可能印刷物がなくなったとき
                            }
                        }
                        Assign_Print2(cnt, assign_printList);   //割り当てメソッドへ
                        assign_printList.Clear();   //割り当て印刷物用のリスト解放
                        continue;   //次の印刷機へ
                    }

                    //サイズが印刷機以下・色数が印刷機より大きいものがある場合
                    available_print = prints.Any(s => s.size_a <= machines[cnt].size_a && s.size_b <= machines[cnt].size_b && s.color > machines[cnt].color && s.assign == false);
                    if (available_print)
                    {
                        int available_size_a = machines[cnt].size_a;
                        int available_size_b = machines[cnt].size_b;
                        string assign_printname = "noname";

                        for (i = 1; machines[cnt].color + i <= 4; i++)
                        {

                            var ap = Array.FindAll(prints, s => s.size_a <= available_size_a && s.size_b <= available_size_b && s.color == machines[cnt].color + i && s.assign == false);
                            while (ap.Count() > 0)
                            {
                                if (available_size_b == 0)  //A判の場合
                                {
                                    var assign_print = ap.OrderByDescending(s => s.size_a).Where(c => c.color == machines[cnt].color + i).Take(1);
                                    foreach (var pi in assign_print)
                                    {
                                        assign_printname = pi.name.ToString();
                                    }
                                }
                                else    //B判の場合
                                {
                                    var assign_print = ap.OrderByDescending(s => s.size_b).Where(c => c.color == machines[cnt].color + i).Take(1);
                                    foreach (var pi in assign_print)
                                    {
                                        assign_printname = pi.name.ToString();
                                    }
                                }


                                p_index = Array.FindIndex(prints, n => n.name == assign_printname);   //名前からインデックス検索

                                assign_printList.Add(prints[p_index]);  //割り当て対象の印刷物を確保

                                prints[p_index].assign = true;  //割り当て終了にする

                                //割り当て可能領域の更新
                                available_size_a = available_size_a - prints[p_index].size_a;
                                available_size_b = available_size_b - prints[p_index].size_b;

                                //割り当て可能印刷物の更新
                                ap = Array.FindAll(prints, s => s.size_a <= available_size_a && s.size_b <= available_size_b && s.color == machines[cnt].color + i && s.assign == false);
                            }

                        }


                        Assign_Print2(cnt, assign_printList);   //割り当てメソッドへ
                        assign_printList.Clear();   //割り当て印刷物用のリスト解放
                        continue;
                    }

                }

            }

        }

        public void Assign_Print1(int machine_ind, int print_ind)   //印刷物の割り当てを行うメソッド1
        {
            //color_cnt,circulation_cntは切り上げ
            int color_cnt = (int)Math.Ceiling((double)prints[print_ind].color / (double)machines[machine_ind].color);
            int circulation_cnt = (int)Math.Ceiling((double)prints[print_ind].circulation / (double)machines[machine_ind].rpm);
            int side_cnt = 0;

            int schedule_ind;

            if (prints[print_ind].side == "両面印刷")
            {
                side_cnt = 2;
            }
            else if (prints[print_ind].side == "片面印刷")
            {
                side_cnt = 1;
            }

            while (side_cnt > 0)
            {
                while (color_cnt > 0)
                {
                    while (circulation_cnt > 0)
                    {
                        //テスト用
                        test_oprint = new List<string>();
                        test_oprint.Add(prints[print_ind].name);
                        test_oomachine[machine_ind].Add(test_oprint);

                        circulation_cnt--;
                    }
                    color_cnt--;
                    circulation_cnt = (int)Math.Ceiling((double)prints[print_ind].circulation / (double)machines[machine_ind].rpm);
                    schedule_ind = test_oomachine[machine_ind].Count() - 1;
                    if (!test_oomachine[machine_ind][schedule_ind].Contains("準備時間"))
                    {
                        /*準備時間未設定なら準備時間を入れる*/
                    test_oprint = new List<string>();
                    test_oprint.Add("準備時間");
                    test_oomachine[machine_ind].Add(test_oprint);
                    }
                }
                side_cnt--;
                color_cnt = (int)Math.Ceiling((double)prints[print_ind].color / (double)machines[machine_ind].color);
                circulation_cnt = (int)Math.Ceiling((double)prints[print_ind].circulation / (double)machines[machine_ind].rpm);
                schedule_ind = test_oomachine[machine_ind].Count() - 1;
                if (!test_oomachine[machine_ind][schedule_ind].Contains("準備時間"))
                {

                    test_oprint = new List<string>();
                    test_oprint.Add("準備時間");
                    test_oomachine[machine_ind].Add(test_oprint);
                }
            }
        }

        public void Assign_Print2(int machine_ind, List<Input_Print> aprints) //印刷物の割り当てを行うメソッド2
        {
            List<Input_Print> assignprints = aprints;  //割り当て対象の印刷物のリスト
            List<int> color_cnt = new List<int>();  //各印刷物の色変え回数
            List<int> circulation_cnt = new List<int>();    //各印刷物の部数/rpm
            List<int> side_cnt = new List<int>();   //各印刷物の両面/片面印刷の属性
            List<int> remove_ind; //削除対象のインデックス確保用リスト
            int cnt;
            int assignprint_cnt;

            int schedule_ind;

            for (cnt = 0; cnt < assignprints.Count(); cnt++) //各カウント値の設定
            {
                color_cnt.Add((int)Math.Ceiling((double)assignprints[cnt].color / (double)machines[machine_ind].color) - 1);
                circulation_cnt.Add((int)Math.Ceiling((double)assignprints[cnt].circulation / (double)machines[machine_ind].rpm));
                if (assignprints[cnt].side == "両面印刷")
                {
                    side_cnt.Add(1);
                }
                else if (assignprints[cnt].side == "片面印刷")
                {
                    side_cnt.Add(0);
                }
            }

            while (assignprints.Count() > 0)    //割り当て対象印刷物があれば
            {
                /*割り当て対象印刷物を割り当てる
                 * for(cnt=0;cnt<assignprints.Count();cnt++){
                 *  outprint = new Print(assignprints[cnt].name, assignprints[cnt].circulation);
                 *  //Print型のリストにAddする
                 * }
                outmachines[machine_ind].Set_Plan(Print型のリスト);*/

                //テスト用
                test_oprint = new List<string>();   //新しくインスタンス作成
                for (cnt = 0; cnt < assignprints.Count(); cnt++)
                {
                    test_oprint.Add(assignprints[cnt].name);
                }
                //test_schedule.Add(test_oprint);
                test_oomachine[machine_ind].Add(test_oprint);   //印刷機[machine_ind]に対象の印刷物を割り当て

                remove_ind = new List<int>();   //削除対象の印刷物のインデックス
                assignprint_cnt = assignprints.Count();
                for (cnt = 0; cnt < assignprint_cnt; cnt++)
                {
                    circulation_cnt[cnt]--; //部数カウント更新
                    if (circulation_cnt[cnt] <= 0)   //部数カウント0
                    {
                        if (color_cnt[cnt] <= 0)
                        {
                            if (side_cnt[cnt] <= 0)
                            {
                                /*削除対象のインデックスを確保*/
                                remove_ind.Add(cnt);
                                /*準備時間未設定なら準備時間を入れる*/
                                schedule_ind = test_oomachine[machine_ind].Count() - 1;
                                if (!test_oomachine[machine_ind][schedule_ind].Contains("準備時間"))
                                {
                                    test_oprint = new List<string>();
                                    test_oprint.Add("準備時間");
                                    test_oomachine[machine_ind].Add(test_oprint);
                                }
                                continue;
                            }
                            else
                            {
                                side_cnt[cnt]--;
                                color_cnt[cnt] = (int)Math.Ceiling((double)assignprints[cnt].color / (double)machines[machine_ind].color) - 1;
                                schedule_ind = test_oomachine[machine_ind].Count() - 1;
                                if (!test_oomachine[machine_ind][schedule_ind].Contains("準備時間"))
                                {
                                    test_oprint = new List<string>();
                                    test_oprint.Add("準備時間");
                                    test_oomachine[machine_ind].Add(test_oprint);
                                }
                            }
                        }
                        else
                        {
                            color_cnt[cnt]--;
                            schedule_ind = test_oomachine[machine_ind].Count() - 1;
                            if (!test_oomachine[machine_ind][schedule_ind].Contains("準備時間"))
                            {
                                test_oprint = new List<string>();
                                test_oprint.Add("準備時間");
                                test_oomachine[machine_ind].Add(test_oprint);
                            }
                        }
                        circulation_cnt[cnt] = (int)Math.Ceiling((double)assignprints[cnt].circulation / (double)machines[machine_ind].rpm);  //部数カウント再設定
                    }
                }
                /*ここで対象の印刷物を削除,後ろのインデックスから削除*/
                for (int i = remove_ind.Count() - 1; i >= 0; i--)
                {
                    assignprints.RemoveAt(remove_ind[i]);
                    color_cnt.RemoveAt(remove_ind[i]);  //色変え回数
                    circulation_cnt.RemoveAt(remove_ind[i]);
                    side_cnt.RemoveAt(remove_ind[i]);   //両面/片面印刷の属性
                }
            }
        }


    }
}
