using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static insatsu.Form1;

namespace insatsu
{
    public partial class Form2 : Form
    {
        private readonly int beginTime;
        private readonly int endTime;
        private readonly int minimumUnitMinutes;
        private readonly List<Machine2> machines;
        internal Form2(int beginTime, int endTIme, int minimumUnitMinutes, List<Machine2> machines)
        {
            InitializeComponent();
            this.beginTime = beginTime;
            this.endTime = endTIme;
            this.minimumUnitMinutes = minimumUnitMinutes;
            this.machines = machines;
        }

        private int Get_Max_Count(List<List<Print2>> schedule)
        {
            int max = 0;

            for(int i = 0; i < schedule.Count; i++)
            {
                if(max < schedule[i].Count)
                {
                    max = schedule[i].Count;
                }
            }

            return max;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // カラム数を指定
            dataGridView1.ColumnCount = 100;


            // 行ヘッダーの作成
            for (int i = 0; i < endTime - beginTime + 1; i++)
            {
                dataGridView1.Columns[i].HeaderText = i + beginTime + "時";
            }

            
            var machine_count = 0;

            for (int i = 0; i < machines.Count; i++)
            {
                for (int l = 0; l < machines[i].schedule.Count; l++)
                {
                    machine_count++;
                }
            }

            var line_count = 0;

            for (int i = 0; i < machines.Count; i++)
            {
                var machine = machines[i];
                for (int j = 0; j < machine.schedule.Count; j++)
                {
                    Console.WriteLine(machine.schedule[j].Count);
                }

                int max = Get_Max_Count(machine.schedule);
                for (int j = 0; j < max; j++)
                {
                    var index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].HeaderCell.Value = machine.name;


                    for(int k = 0; k < machine.schedule.Count; k++)
                    {

                        if (machine.schedule[k].Count > j)
                        {
                            var a = machine.schedule[k];
                            var b = machine.schedule[k][j].name;

                            Console.WriteLine($"i:{i} j:{j} k:{k}");

                            var c = dataGridView1.Rows[index];
                            var d = dataGridView1.Rows[index].Cells[k];
                            dataGridView1.Rows[index].Cells[k].Value = machine.schedule[k][j].name;

                        }

                    }
                }


            }


            // データを追加


        }
    }
}