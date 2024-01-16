using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void Form2_Load(object sender, EventArgs e)
        {
            // カラム数を指定
            dataGridView1.ColumnCount = endTime - beginTime;

            // 行ヘッダーの作成
            for (int i = 0; i < endTime - beginTime; i++)
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
                Console.WriteLine(machine.name);

                for (int j = 0; j < machine.schedule.Count; j++, line_count++)
                {
                    var prints = machine.schedule[j];
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[line_count].HeaderCell.Value = machine.name;

                    for (int k = 0; k < prints.Count; k++)
                    {
                        dataGridView1.Rows[line_count].Cells[k].Value = prints[k].name;
                    }
                }

            }


            // データを追加


        }
    }
}