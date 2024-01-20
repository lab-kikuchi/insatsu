using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insatsu
{
    public partial class Form1 : Form
    {
        public int Machine_cnt; //印刷機の数
        public Machine[] Machines;   //印刷機
        public int Print_cnt;   //印刷物の種類の数
        public Print[] Prints; //印刷物
        private int R = 5000;
        public int beginTime;  //1日の作業開始時間
        public int endTime;    //1日の作業終了時間

        private int machine_listInd = -1;    //リスト内の印刷機のインデックス
        private int print_listInd = -1;  //リスト内の印刷物のインデックス

        public struct Machine   //構造体で印刷機を表す
        {
            public int rpm;    //回転数
            public int color;  //色数
            public string size;    //サイズ
            public int size_a; //A4サイズを考えた時の数
            public int size_b; //B5サイズを考えた時の数
            public string name; //印刷機の名前

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

        public struct Print
        {
            public int deadline;   //納期
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

        public Form1()
        {
            InitializeComponent();
            this.beginTime = 9;
            this.endTime = 21;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //入力負荷にする初期設定
            machinesize_comboBox.Enabled = false;   //印刷機
            machinecolor_comboBox.Enabled = false;
            circulation_textBox.ReadOnly = true;    //印刷物
            printsize_comboBox.Enabled = false;
            printside_comboBox.Enabled = false;
            printcolor_comboBox.Enabled = false;
            printbackcolor_comboBox.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void machinecount_ValueChanged(object sender, EventArgs e)
        {
            //印刷機の数を取得
            //Machine_cnt = decimal.ToInt32(machinecount.Value);
            //Machines = new Machine[Machine_cnt];
        }

        private void printcount_ValueChanged(object sender, EventArgs e)
        {
            //印刷物の数を取得
            //Print_cnt = decimal.ToInt32(printcount.Value);
            //Prints = new Print[Print_cnt];
        }

        private void machine_listBox_SelectedIndexChanged(object sender, EventArgs e)   //リストから印刷機選択
        {
            machine_listInd = machine_listBox.SelectedIndex;    //現在選択中の印刷機のインデックス取得

            //選択している印刷機の要素を表示
            machinesize_comboBox.Text = Machines[machine_listInd].size;
            machinecolor_comboBox.Text = Machines[machine_listInd].color.ToString();

            //印刷機の要素を入力可能にする
            machinesize_comboBox.Enabled = true;
            machinecolor_comboBox.Enabled = true;
        }

        private void machinesize_comboBox_SelectionChangeCommitted(object sender, EventArgs e)  //印刷機のサイズの取得
        {
            Machines[machine_listInd].size = machinesize_comboBox.Text;
            Machines[machine_listInd].size_div();
        }

        private void machinecolor_comboBox_SelectionChangeCommitted(object sender, EventArgs e) //何色機か取得
        {
            Machines[machine_listInd].color = int.Parse(machinecolor_comboBox.Text);
        }


        private void machinecount_button_Click(object sender, EventArgs e)  //印刷機のリスト表示
        {
            //印刷機の数を取得
            Machine_cnt = decimal.ToInt32(machinecount.Value);
            Machines = new Machine[Machine_cnt];

            machine_listBox.Items.Clear();  //リスト消去
            machine_listInd = -1;
            for (int cnt = 1; cnt <= Machine_cnt; cnt++)    
            {
                machine_listBox.Items.Add("印刷機" + cnt); //リストに追加
                Machines[cnt - 1].rpm_set(R);   //回転数の設定
                Machines[cnt - 1].name = "印刷機" + cnt.ToString();    //印刷機の名前設定
            }

        }

        private void print_listBox_SelectedIndexChanged(object sender, EventArgs e) //リストから印刷物選択
        {
            print_listInd = print_listBox.SelectedIndex;    //現在選択中の印刷物のインデックス取得

            //選択している印刷物の要素を表示
            circulation_textBox.Text = Prints[print_listInd].circulation.ToString();
            printsize_comboBox.Text = Prints[print_listInd].size;
            printside_comboBox.Text = Prints[print_listInd].side;
            printcolor_comboBox.Text = Prints[print_listInd].color.ToString();
            printbackcolor_comboBox.Text = Prints[print_listInd].backcolor.ToString();

            //印刷物の要素を入力可能にする
            circulation_textBox.ReadOnly = false;
            printsize_comboBox.Enabled = true;
            printside_comboBox.Enabled = true;
            printcolor_comboBox.Enabled = true;
            if (Prints[print_listInd].side == "両面印刷") { printbackcolor_comboBox.Enabled = true; }
            else if (Prints[print_listInd].side == "片面印刷") { printbackcolor_comboBox.Enabled = false; }
        }

        private void printcount_button_Click(object sender, EventArgs e)    //印刷物のリスト表示
        {
            //印刷物の種類を取得
            Print_cnt = decimal.ToInt32(printcount.Value);  
            Prints = new Print[Print_cnt];

            print_listBox.Items.Clear();    //リスト消去
            print_listInd = -1;
            for (int cnt = 1; cnt <= Print_cnt; cnt++)
            {
                print_listBox.Items.Add("印刷物" + cnt);
                Prints[cnt - 1].name = "印刷物" + cnt.ToString();
            }

        }

        private void printsize_comboBox_SelectionChangeCommitted(object sender, EventArgs e)    //印刷物のサイズ取得
        {
            Prints[print_listInd].size = printsize_comboBox.Text;
            Prints[print_listInd].size_div();
        }

        private void printcolor_comboBox_SelectionChangeCommitted(object sender, EventArgs e)   //印刷物が何色刷りか取得
        {
            Prints[print_listInd].color = int.Parse(printcolor_comboBox.Text);
        }
        private void printbackcolor_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Prints[print_listInd].backcolor = int.Parse(printbackcolor_comboBox.Text);
        }
        private void printside_comboBox_SelectedIndexChanged(object sender, EventArgs e)    //両面印刷/片面印刷どちらか取得
        {
            Prints[print_listInd].side = printside_comboBox.Text;
            if (Prints[print_listInd].side == "両面印刷") { printbackcolor_comboBox.Enabled = true; }
            else if (Prints[print_listInd].side == "片面印刷") { printbackcolor_comboBox.Enabled = false; }
        }

        private void circulation_textBox_KeyPress(object sender, KeyPressEventArgs e)   //部数取得
        {
            if (e.KeyChar == (char)Keys.Enter)  //エンターキーが押されたとき
            {
                if (!String.IsNullOrEmpty(circulation_textBox.Text))    //入力値が空でなければ
                {
                    Prints[print_listInd].circulation = int.Parse(circulation_textBox.Text);  //入力値を整数型に変換後,代入
                }

                e.Handled = true;   //ビープ音だけは鳴らないようにしたい
            }

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;   //数字以外の時イベントキャンセル
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int cnt;
            int no_Input = 0;   //入力値がない要素の数

            /*入力値が足りないときのエラー処理*/
            if (machine_listInd == -1)
            {
                textBox1.Text += "印刷機がありません\r\n";
                no_Input++;
            }
            else
            {
                for (cnt = 0; cnt < Machines.Count(); cnt++)
                {   //印刷機
                    if (Machines[cnt].size == null)
                    {
                        textBox1.Text += Machines[cnt].name + "のサイズを入力してください\r\n";
                        no_Input++;
                    }
                    if (Machines[cnt].color == 0)
                    {
                        textBox1.Text += Machines[cnt].name + "の色を入力してください\r\n";
                        no_Input++;
                    }
                }
            }

            if (print_listInd == -1)
            {
                textBox1.Text += "印刷物がありません\r\n";
                no_Input++;
            }
            else
            {
                for (cnt = 0; cnt < Prints.Count(); cnt++)  //印刷物
                {
                    if (Prints[cnt].size == null)
                    {
                        textBox1.Text += Prints[cnt].name + "のサイズを入力してください\r\n";
                        no_Input++;
                    }
                    if (Prints[cnt].circulation == 0)
                    {
                        textBox1.Text += Prints[cnt].name + "の部数を入力してください\r\n";
                        no_Input++;
                    }
                    if (Prints[cnt].color == 0)
                    {
                        textBox1.Text += Prints[cnt].name + "の色を入力してください\r\n";
                        no_Input++;
                    }
                    if (Prints[cnt].side == null)
                    {
                        textBox1.Text += Prints[cnt].name + "の両面印刷/片面印刷を選択して下さい\r\n";
                        no_Input++;
                    }
                    else if (Prints[cnt].side == "両面印刷" && Prints[cnt].backcolor == 0)
                    {
                        textBox1.Text += Prints[cnt].name + "の裏面の色を選択して下さい\r\n";
                        no_Input++;
                    }
                    /*if (Prints[cnt].deadline == 0) { 
                        textBox1.Text = Prints[cnt].name + "の納期を入力してください";
                        no_Input++;
                    }*/
                }
            }

            /*開始・終了時間の取得*/
            beginTime = decimal.ToInt32(begintime_numericUpDown.Value);
            endTime = decimal.ToInt32(endtime_numericUpDown.Value);
            if (endTime - beginTime <= 0)   //エラー
            {
                textBox1.Text += "終了時間は開始時間より遅く設定してください\r\n";
                no_Input++;
            }

            if (no_Input <= 0)  //未入力値がない場合,Planをスタート
            {
                Plan1_Start();
            }
        }

        private void Plan1_Start()
        {
            int cnt;

            //Plan1テスト
            Plan1.Input_Print[] input_print = new Plan1.Input_Print[Print_cnt];
            for (cnt = 0; cnt < Prints.Count(); cnt++)
            {
                input_print[cnt].size_a = Prints[cnt].size_a;
                input_print[cnt].deadline = Prints[cnt].deadline;   //納期
                input_print[cnt].circulation = Prints[cnt].circulation;    //部数
                input_print[cnt].color = Prints[cnt].color;  //色数
                input_print[cnt].backcolor = Prints[cnt].backcolor;
                input_print[cnt].size = Prints[cnt].size;    //サイズ  
                input_print[cnt].size_a = Prints[cnt].size_a;
                input_print[cnt].size_b = Prints[cnt].size_b;
                input_print[cnt].side = Prints[cnt].side; //両面印刷/片面印刷
                input_print[cnt].assign = false; //割り当てが完了しているかどうか,完了していればtrue
                input_print[cnt].name = Prints[cnt].name; //印刷物の名前
            }
            Plan1.Input_Machine[] input_machine = new Plan1.Input_Machine[Machine_cnt];
            for (cnt = 0; cnt < Machines.Count(); cnt++)
            {
                input_machine[cnt].rpm = Machines[cnt].rpm;    //回転数
                input_machine[cnt].color = Machines[cnt].color;  //色数
                input_machine[cnt].size = Machines[cnt].size;    //サイズ
                input_machine[cnt].size_a = Machines[cnt].size_a; //A4サイズを考えた時の数
                input_machine[cnt].size_b = Machines[cnt].size_b; //B5サイズを考えた時の数
                input_machine[cnt].name = Machines[cnt].name;
            }

            Plan1 plan1 = new Plan1(input_machine, input_print);


            plan1.Planning();

            Form form2 = new Form2(beginTime, endTime, 1, plan1.outmachines);
            form2.Show();

            /*以下テスト用*/
            textBox2.Text = "テスト開始";
            for (int i = 0; i < plan1.test_oomachine.Count(); i++)
            {
                for (int j = 0; j < plan1.test_oomachine[i].Count(); j++)
                {
                    for (int k = 0; k < plan1.test_oomachine[i][j].Count(); k++)
                    {
                        textBox2.Text += i.ToString() + j.ToString() + k.ToString() + plan1.test_oomachine[i][j][k] + ",";
                    }
                    textBox2.Text += " jj ";
                }
                textBox2.Text += " ii \r\n";
            }

            textBox2.Text += "\r\n";
            foreach (var s in plan1.prints)
            {
                textBox2.Text += s.name + ",";
            }
            //テスト
            for (int i = 0; i < plan1.outmachines.Count(); i++)
            {
                for (int j = 0; j < plan1.outmachines[i].schedule.Count(); j++)
                {
                    for (int k = 0; k < plan1.outmachines[i].schedule[j].Count(); k++)
                    {
                        textBox2.Text += i.ToString() + j.ToString() + k.ToString() + plan1.outmachines[i].schedule[j][k].name + ",";
                    }
                    textBox2.Text += " jj ";
                }
                textBox2.Text += " ii \r\n";
            }
        }        
    }
}
