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

        public List<Machine2> outmachines;   //出力用の印刷機リスト
        public Print_Type outtype;
        public List<Print2> outprint;  //出力する印刷物
        List<Print2> prep_time;  //準備時間

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
            public DateTime deadline;   //納期
            public int circulation;    //部数
            public int color;  //色数
            public int backcolor;   //裏面の色数
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
        private struct Assign_PrintsCount
        {
            public int color_cnt;  //各印刷物の色変え回数
            public int circulation_cnt;    //各印刷物の部数/(rpm*割り当て数)
            public int side_cnt;   //各印刷物の両面/片面印刷の属性
            public int assign_cnt; //１回の割り当て数
            public int rest_circulation;    //残り部数
        }
        public Plan1(Input_Machine[] machines, Input_Print[] prints)
        {
            this.machines = machines;
            this.prints = prints;

        }

        public void Make_OutMachine()  //出力用の印刷機リストを作成
        {
            outmachines = new List<Machine2>();
            for (int cnt = 0; cnt < machines.Count(); cnt++)
            {
                if (machines[cnt].size_a != 0)
                {
                    outmachines.Add(new Machine2(Print_Type.A, machines[cnt].size_a, machines[cnt].name));
                }
                else if (machines[cnt].size_b != 0)
                {
                    outmachines.Add(new Machine2(Print_Type.B, machines[cnt].size_b, machines[cnt].name));
                }
                prep_time = new List<Print2>();
                prep_time.Add(new Print2("準備時間", 0));
                outmachines[cnt].Set_Plan(prep_time);
            }

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
                        if (available_size_a > 0)
                        {
                            Assign_Print2(cnt, assign_printList, available_size_a);
                        }
                        else if (available_size_b > 0)
                        {
                            Assign_Print2(cnt, assign_printList, available_size_b);
                        }
                        else
                        {
                            Assign_Print2(cnt, assign_printList, 0);
                        }
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
                        if (available_size_a > 0)
                        {
                            Assign_Print2(cnt, assign_printList, available_size_a);
                        }
                        else if (available_size_b > 0)
                        {
                            Assign_Print2(cnt, assign_printList, available_size_b);
                        }
                        else
                        {
                            Assign_Print2(cnt, assign_printList, 0);
                        }
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
            int outmachine_ind = outmachines.FindIndex(n => n.name == machines[machine_ind].name);  //名前から出力用印刷機リストのインデックスを逆引き

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
                        /*割り当て対象印刷物を割り当てる*/
                        outprint = new List<Print2>();
                        outprint.Add(new Print2(prints[print_ind].name, prints[print_ind].circulation));
                        outmachines[outmachine_ind].Set_Plan(outprint);

                        //テスト用
                        test_oprint = new List<string>();
                        test_oprint.Add(prints[print_ind].name);
                        test_oomachine[outmachine_ind].Add(test_oprint);

                        circulation_cnt--;
                    }
                    color_cnt--;
                    circulation_cnt = (int)Math.Ceiling((double)prints[print_ind].circulation / (double)machines[machine_ind].rpm);
                    schedule_ind = test_oomachine[outmachine_ind].Count() - 1;
                    /*準備時間が未設定なら設定する*/
                    Assign_preptime(outmachine_ind);
                }
                side_cnt--;
                color_cnt = (int)Math.Ceiling((double)prints[print_ind].backcolor / (double)machines[machine_ind].color);
                circulation_cnt = (int)Math.Ceiling((double)prints[print_ind].circulation / (double)machines[machine_ind].rpm);
                /*準備時間が未設定なら設定する*/
                Assign_preptime(outmachine_ind);
            }
        }

        public void Assign_Print2(int machine_ind, List<Input_Print> aprints, int available_size) //印刷物の割り当てを行うメソッド2
        {
            //available_sizeは割り当て可能領域
            List<Input_Print> assignprints = aprints;  //割り当て対象の印刷物のリスト
            List<Assign_PrintsCount> countlist = new List<Assign_PrintsCount>(); //各カウント値を制御するリスト
            List<int> remove_ind; //削除対象のインデックス確保用リスト
            int cnt;
            int assignprint_cnt;    //assignprintsの要素数保持
            int outmachine_ind = outmachines.FindIndex(n => n.name == machines[machine_ind].name);//名前から出力用印刷機リストのインデックスを逆引き

            int schedule_ind;
            int assign_ind = -1;

            for (cnt = 0; cnt < assignprints.Count(); cnt++) //各カウント値の設定
            {
                Assign_PrintsCount apc = new Assign_PrintsCount();
                apc.rest_circulation = assignprints[cnt].circulation;   //残り部数
                apc.color_cnt = (int)Math.Ceiling((double)assignprints[cnt].color / (double)machines[machine_ind].color) - 1;
                apc.circulation_cnt = (int)Math.Ceiling((double)assignprints[cnt].circulation / (double)machines[machine_ind].rpm);
                apc.assign_cnt = 1;
                if (assignprints[cnt].side == "両面印刷")
                {
                    apc.side_cnt = 1;
                }
                else if (assignprints[cnt].side == "片面印刷")
                {
                    apc.side_cnt = 0;
                }
                countlist.Add(apc);
            }

            Assign_PrintsCount apcl = new Assign_PrintsCount();
            while (assignprints.Count() > 0)    //割り当て対象印刷物があれば
            {
                //割り当て領域以下のサイズの印刷物が割り当て対象のリストにあるか
                var aps = assignprints.FindAll(s => s.size_a <= available_size && s.size_b <= available_size);
                while (aps.Count() > 0) //複数割り当てを行う印刷物を取得
                {
                    List<int> apind = new List<int>();
                    foreach (var pi in aps)  //該当する印刷物のインデックス抽出
                    {
                        assign_ind = assignprints.FindIndex(n => n.name == pi.name);
                        apind.Add(assign_ind);  //該当のインデックスを格納
                    }

                    int max_circulation = -1;   //部数カウントが最大のものを格納する変数
                    int max_ind = -1;
                    for (int i = 0; i < apind.Count(); i++)
                    {
                        if (countlist[apind[i]].circulation_cnt > max_circulation)
                        {
                            max_circulation = countlist[apind[i]].circulation_cnt;  //最大値更新
                            max_ind = apind[i];
                        }
                    }

                    if (max_circulation > 1)    //部数カウント最大の印刷物があれば割り当て数を増やす
                    {
                        apcl = countlist[max_ind];
                        apcl.assign_cnt++;  //割り当て数+1
                        apcl.circulation_cnt = (int)Math.Ceiling((double)apcl.rest_circulation / ((double)machines[machine_ind].rpm * apcl.assign_cnt));    //部数カウント更新
                        countlist[max_ind] = apcl;
                        /*割り当て可能領域更新*/
                        if (assignprints[max_ind].size_a != 0) { available_size = available_size - assignprints[max_ind].size_a; }
                        else { available_size = available_size - assignprints[max_ind].size_b; }
                    }
                    else
                    {
                        break;  //部数カウントが該当する印刷物が無ければループを抜ける
                    }
                    aps = assignprints.FindAll(s => s.size_a <= available_size && s.size_b <= available_size);
                }
                /*割り当て対象印刷物を割り当てる*/
                outprint = new List<Print2>();
                for (cnt = 0; cnt < assignprints.Count(); cnt++)
                {
                    for (int i = 0; i < countlist[cnt].assign_cnt; i++)
                    {
                        outprint.Add(new Print2(assignprints[cnt].name, assignprints[cnt].circulation));
                    }
                }
                outmachines[outmachine_ind].Set_Plan(outprint);

                //テスト用
                test_oprint = new List<string>();   //新しくインスタンス作成
                for (cnt = 0; cnt < assignprints.Count(); cnt++)
                {
                    for (int i = 0; i < countlist[cnt].assign_cnt; i++)
                    {
                        test_oprint.Add(assignprints[cnt].name);
                    }
                }
                test_oomachine[outmachine_ind].Add(test_oprint);   //印刷機[machine_ind]に対象の印刷物を割り当て

                remove_ind = new List<int>();   //削除対象の印刷物のインデックス
                assignprint_cnt = assignprints.Count();
                for (cnt = 0; cnt < assignprint_cnt; cnt++)
                {
                    apcl = countlist[cnt];
                    apcl.circulation_cnt--; //部数カウント更新
                    apcl.rest_circulation = apcl.rest_circulation - (machines[machine_ind].rpm * apcl.assign_cnt);
                    if (apcl.circulation_cnt <= 0)   //部数カウント0
                    {
                        if (apcl.color_cnt <= 0)
                        {
                            if (apcl.side_cnt <= 0)
                            {
                                /*削除対象のインデックスを確保*/
                                remove_ind.Add(cnt);
                                /*準備時間未設定なら準備時間を入れる*/
                                Assign_preptime(outmachine_ind);
                                continue;
                            }
                            else
                            {
                                apcl.side_cnt--;
                                apcl.color_cnt = (int)Math.Ceiling((double)assignprints[cnt].backcolor / (double)machines[machine_ind].color) - 1;  //色数カウント再設定

                                /*準備時間が未設定なら設定する*/
                                Assign_preptime(outmachine_ind);
                            }
                        }
                        else
                        {
                            apcl.color_cnt--;

                            /*準備時間が未設定なら設定する*/
                            Assign_preptime(outmachine_ind);
                        }
                        apcl.circulation_cnt = (int)Math.Ceiling((double)assignprints[cnt].circulation / ((double)machines[machine_ind].rpm * apcl.assign_cnt));  //部数カウント再設定
                        apcl.rest_circulation = assignprints[cnt].circulation;   //残り部数再設定
                    }
                    countlist[cnt] = apcl;
                }

                /*ここで対象の印刷物を削除,後ろのインデックスから削除*/
                for (int i = remove_ind.Count() - 1; i >= 0; i--)
                {
                    /*割り当て可能領域更新*/
                    if (assignprints[remove_ind[i]].size_a > 0) { available_size = available_size + (assignprints[remove_ind[i]].size_a * countlist[remove_ind[i]].assign_cnt); }
                    else { available_size = available_size + (assignprints[remove_ind[i]].size_b * countlist[remove_ind[i]].assign_cnt); }
                    assignprints.RemoveAt(remove_ind[i]);
                    countlist.RemoveAt(remove_ind[i]);
                }
                /*残り部数を考慮して割り当て数を変更*/
                for (cnt = 0; cnt < assignprints.Count(); cnt++)
                {
                    apcl = countlist[cnt];
                    if (apcl.rest_circulation <= machines[machine_ind].rpm * (apcl.assign_cnt - 1) && apcl.assign_cnt > 0)
                    {
                        for (int i = 1; i < apcl.assign_cnt; i++)
                        {
                            if (apcl.rest_circulation <= machines[machine_ind].rpm * i)
                            {
                                //割り当て数変更==版の変更用の準備時間設定
                                /*準備時間が未設定なら設定する*/
                                Assign_preptime(outmachine_ind);
                                test_oprint = new List<string>();
                                test_oprint.Add("割り当て数版準備時間" + apcl.assign_cnt.ToString());
                                test_oomachine[outmachine_ind].Add(test_oprint);

                                //割り当て領域を戻す
                                if (assignprints[cnt].size_a > 0) { available_size = available_size + (assignprints[cnt].size_a * (apcl.assign_cnt - i)); }
                                else { available_size = available_size + (assignprints[cnt].size_b * (apcl.assign_cnt - i)); }
                                apcl.assign_cnt = i;    //割り当て数変更
                                apcl.circulation_cnt = (int)Math.Ceiling((double)apcl.rest_circulation / ((double)machines[machine_ind].rpm * apcl.assign_cnt));    //部数カウント変更
                                break;
                            }
                        }
                    }
                    countlist[cnt] = apcl;
                }
            }

        }
        private void Assign_preptime(int outmachine_ind)
        {
            /*準備時間が未設定なら設定する*/
            int schedule_ind = outmachines[outmachine_ind].schedule.Count() - 1;
            prep_time = new List<Print2>();
            /*prep_time.Add(new Print2("準備時間"+ outmachines[outmachine_ind].schedule[schedule_ind][0].name, 0));
            outmachines[outmachine_ind].Set_Plan(prep_time);
            prep_time = new List<Print2>();*/
            prep_time.Add(new Print2("準備時間", 0));
            if (outmachines[outmachine_ind].schedule[schedule_ind][0].name != "準備時間")
            {
                outmachines[outmachine_ind].Set_Plan(prep_time);
            }
            //テスト用
            schedule_ind = test_oomachine[outmachine_ind].Count() - 1;
            if (!test_oomachine[outmachine_ind][schedule_ind].Contains("準備時間"))
            {
                test_oprint = new List<string>();
                test_oprint.Add("準備時間");
                test_oomachine[outmachine_ind].Add(test_oprint);
            }
        }

    }
}
