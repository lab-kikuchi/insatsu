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
        private int machine_listInd;

        public struct Machine   //構造体で印刷機を表す
        {
            int rpm;    //回転数
            public int color;  //色数
            //string size;    //サイズ
            public int size_a; //A4サイズを考えた時の数
            public int size_b; //B5サイズを考えた時の数

            public void rpm_set(int R)  //回転数の設定
            { this.rpm = R; }

            public void size_div(string size)   //サイズをA4サイズに分割
            {
                this.size_a = 0;
                this.size_b = 0;
                if (size == "A全判" || size == "菊全判")
                {
                    this.size_a = 8;
                }
                else if (size == "A半裁" || size == "菊半裁")
                {
                    this.size_a = 4;
                }
                else if (size == "B全判" || size == "四六全判")
                {
                    this.size_b = 16;
                }
                else if (size == "B半裁" || size == "四六半裁")
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
            //string size;    //サイズ
            public int size_a;
            public int size_b;
            public int print_page; //両面印刷/片面印刷

            public void size_div(string size)  //サイズを最小サイズに分割
            {
                this.size_a = 0;
                this.size_b = 0;
                if (size == "A1") { this.size_a = 8; }
                else if (size == "A2") { this.size_a = 4; }
                else if (size == "A3") { this.size_a = 2; }
                else if (size == "A4") { this.size_a = 1; }
                else if (size == "B1") { this.size_b = 16; }
                else if (size == "B2") { this.size_b = 8; }
                else if (size == "B3") { this.size_b = 4; }
                else if (size == "B4") { this.size_b = 2; }
                else if (size == "B5") { this.size_b = 1; }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void machinecount_ValueChanged(object sender, EventArgs e)
        {
            //印刷機の数を取得
            Machine_cnt = decimal.ToInt32(machinecount.Value);
            Machines = new Machine[Machine_cnt];
        }

        private void printcount_ValueChanged(object sender, EventArgs e)
        {
            //印刷物の数を取得
            Print_cnt = decimal.ToInt32(printcount.Value);
            Prints = new Print[Print_cnt];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt;
            for (cnt = 1; cnt <= Machine_cnt; cnt++){
                machine_listBox.Items.Add("印刷機" + cnt);
                Machines[cnt - 1].rpm_set(R);
            }
        }

        private void machine_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            machine_listInd = machine_listBox.SelectedIndex;
            textBox1.Text = machine_listInd.ToString();
        }

        private void machinesize_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Machines[machine_listInd].size_div(machinesize_comboBox.Text);
            textBox1.Text += Machines[machine_listInd].size_a.ToString();
            textBox1.Text += Machines[machine_listInd].size_b.ToString();
        }

        private void machinecolor_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Machines[machine_listInd].color = int.Parse(machinecolor_comboBox.Text);
            textBox1.Text += Machines[machine_listInd].color.ToString();
        }
    }
}
