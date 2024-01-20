namespace insatsu
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.machinecount = new System.Windows.Forms.NumericUpDown();
            this.insatsuki = new System.Windows.Forms.Label();
            this.printcount = new System.Windows.Forms.NumericUpDown();
            this.insatsubutsu = new System.Windows.Forms.Label();
            this.machine_listBox = new System.Windows.Forms.ListBox();
            this.machinecount_button = new System.Windows.Forms.Button();
            this.machinesize_comboBox = new System.Windows.Forms.ComboBox();
            this.machinecolor_comboBox = new System.Windows.Forms.ComboBox();
            this.print_listBox = new System.Windows.Forms.ListBox();
            this.printsize_comboBox = new System.Windows.Forms.ComboBox();
            this.printcolor_comboBox = new System.Windows.Forms.ComboBox();
            this.printside_comboBox = new System.Windows.Forms.ComboBox();
            this.circulation_textBox = new System.Windows.Forms.TextBox();
            this.printcount_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.machinesize_label = new System.Windows.Forms.Label();
            this.machinecolor_label = new System.Windows.Forms.Label();
            this.printsize_label = new System.Windows.Forms.Label();
            this.printcolor_label = new System.Windows.Forms.Label();
            this.printside__label = new System.Windows.Forms.Label();
            this.circulation_label = new System.Windows.Forms.Label();
            this.begintime_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endtime_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.printbackcolor_comboBox = new System.Windows.Forms.ComboBox();
            this.begintime_label = new System.Windows.Forms.Label();
            this.endtime_label = new System.Windows.Forms.Label();
            this.printbackcolor_label = new System.Windows.Forms.Label();
            this.deadline_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deadline_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.machinecount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begintime_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endtime_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 594);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 325);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // machinecount
            // 
            this.machinecount.Location = new System.Drawing.Point(123, 51);
            this.machinecount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.machinecount.Name = "machinecount";
            this.machinecount.Size = new System.Drawing.Size(70, 25);
            this.machinecount.TabIndex = 1;
            this.machinecount.ValueChanged += new System.EventHandler(this.machinecount_ValueChanged);
            // 
            // insatsuki
            // 
            this.insatsuki.AutoSize = true;
            this.insatsuki.Location = new System.Drawing.Point(22, 51);
            this.insatsuki.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.insatsuki.Name = "insatsuki";
            this.insatsuki.Size = new System.Drawing.Size(62, 18);
            this.insatsuki.TabIndex = 2;
            this.insatsuki.Text = "印刷機";
            // 
            // printcount
            // 
            this.printcount.Location = new System.Drawing.Point(123, 291);
            this.printcount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printcount.Name = "printcount";
            this.printcount.Size = new System.Drawing.Size(70, 25);
            this.printcount.TabIndex = 3;
            this.printcount.ValueChanged += new System.EventHandler(this.printcount_ValueChanged);
            // 
            // insatsubutsu
            // 
            this.insatsubutsu.AutoSize = true;
            this.insatsubutsu.Location = new System.Drawing.Point(22, 291);
            this.insatsubutsu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.insatsubutsu.Name = "insatsubutsu";
            this.insatsubutsu.Size = new System.Drawing.Size(62, 18);
            this.insatsubutsu.TabIndex = 4;
            this.insatsubutsu.Text = "印刷物";
            // 
            // machine_listBox
            // 
            this.machine_listBox.FormattingEnabled = true;
            this.machine_listBox.ItemHeight = 18;
            this.machine_listBox.Location = new System.Drawing.Point(245, 51);
            this.machine_listBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.machine_listBox.Name = "machine_listBox";
            this.machine_listBox.Size = new System.Drawing.Size(197, 130);
            this.machine_listBox.TabIndex = 5;
            this.machine_listBox.SelectedIndexChanged += new System.EventHandler(this.machine_listBox_SelectedIndexChanged);
            // 
            // machinecount_button
            // 
            this.machinecount_button.Location = new System.Drawing.Point(68, 110);
            this.machinecount_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.machinecount_button.Name = "machinecount_button";
            this.machinecount_button.Size = new System.Drawing.Size(125, 34);
            this.machinecount_button.TabIndex = 6;
            this.machinecount_button.Text = "確定";
            this.machinecount_button.UseVisualStyleBackColor = true;
            this.machinecount_button.Click += new System.EventHandler(this.machinecount_button_Click);
            // 
            // machinesize_comboBox
            // 
            this.machinesize_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machinesize_comboBox.FormattingEnabled = true;
            this.machinesize_comboBox.Items.AddRange(new object[] {
            "A全判",
            "A半裁",
            "B全判",
            "B半裁",
            "菊全判",
            "菊半裁",
            "四六全判",
            "四六半裁"});
            this.machinesize_comboBox.Location = new System.Drawing.Point(682, 58);
            this.machinesize_comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.machinesize_comboBox.Name = "machinesize_comboBox";
            this.machinesize_comboBox.Size = new System.Drawing.Size(199, 26);
            this.machinesize_comboBox.TabIndex = 7;
            this.machinesize_comboBox.SelectionChangeCommitted += new System.EventHandler(this.machinesize_comboBox_SelectionChangeCommitted);
            // 
            // machinecolor_comboBox
            // 
            this.machinecolor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machinecolor_comboBox.FormattingEnabled = true;
            this.machinecolor_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.machinecolor_comboBox.Location = new System.Drawing.Point(682, 120);
            this.machinecolor_comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.machinecolor_comboBox.Name = "machinecolor_comboBox";
            this.machinecolor_comboBox.Size = new System.Drawing.Size(199, 26);
            this.machinecolor_comboBox.TabIndex = 8;
            this.machinecolor_comboBox.SelectionChangeCommitted += new System.EventHandler(this.machinecolor_comboBox_SelectionChangeCommitted);
            // 
            // print_listBox
            // 
            this.print_listBox.FormattingEnabled = true;
            this.print_listBox.ItemHeight = 18;
            this.print_listBox.Location = new System.Drawing.Point(245, 266);
            this.print_listBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.print_listBox.Name = "print_listBox";
            this.print_listBox.Size = new System.Drawing.Size(197, 130);
            this.print_listBox.TabIndex = 9;
            this.print_listBox.SelectedIndexChanged += new System.EventHandler(this.print_listBox_SelectedIndexChanged);
            // 
            // printsize_comboBox
            // 
            this.printsize_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printsize_comboBox.FormattingEnabled = true;
            this.printsize_comboBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5"});
            this.printsize_comboBox.Location = new System.Drawing.Point(682, 268);
            this.printsize_comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printsize_comboBox.Name = "printsize_comboBox";
            this.printsize_comboBox.Size = new System.Drawing.Size(199, 26);
            this.printsize_comboBox.TabIndex = 10;
            this.printsize_comboBox.SelectionChangeCommitted += new System.EventHandler(this.printsize_comboBox_SelectionChangeCommitted);
            // 
            // printcolor_comboBox
            // 
            this.printcolor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printcolor_comboBox.FormattingEnabled = true;
            this.printcolor_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.printcolor_comboBox.Location = new System.Drawing.Point(682, 308);
            this.printcolor_comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printcolor_comboBox.Name = "printcolor_comboBox";
            this.printcolor_comboBox.Size = new System.Drawing.Size(199, 26);
            this.printcolor_comboBox.TabIndex = 11;
            this.printcolor_comboBox.SelectionChangeCommitted += new System.EventHandler(this.printcolor_comboBox_SelectionChangeCommitted);
            // 
            // printside_comboBox
            // 
            this.printside_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printside_comboBox.FormattingEnabled = true;
            this.printside_comboBox.Items.AddRange(new object[] {
            "片面印刷",
            "両面印刷"});
            this.printside_comboBox.Location = new System.Drawing.Point(682, 348);
            this.printside_comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printside_comboBox.Name = "printside_comboBox";
            this.printside_comboBox.Size = new System.Drawing.Size(199, 26);
            this.printside_comboBox.TabIndex = 12;
            this.printside_comboBox.SelectedIndexChanged += new System.EventHandler(this.printside_comboBox_SelectedIndexChanged);
            // 
            // circulation_textBox
            // 
            this.circulation_textBox.Location = new System.Drawing.Point(682, 388);
            this.circulation_textBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.circulation_textBox.Name = "circulation_textBox";
            this.circulation_textBox.Size = new System.Drawing.Size(199, 25);
            this.circulation_textBox.TabIndex = 13;
            this.circulation_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.circulation_textBox_KeyPress);
            // 
            // printcount_button
            // 
            this.printcount_button.Location = new System.Drawing.Point(68, 345);
            this.printcount_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printcount_button.Name = "printcount_button";
            this.printcount_button.Size = new System.Drawing.Size(125, 34);
            this.printcount_button.TabIndex = 14;
            this.printcount_button.Text = "確定";
            this.printcount_button.UseVisualStyleBackColor = true;
            this.printcount_button.Click += new System.EventHandler(this.printcount_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(483, 594);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(662, 325);
            this.textBox2.TabIndex = 15;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(758, 456);
            this.start_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(125, 34);
            this.start_button.TabIndex = 16;
            this.start_button.Text = "開始";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // machinesize_label
            // 
            this.machinesize_label.AutoSize = true;
            this.machinesize_label.Location = new System.Drawing.Point(487, 63);
            this.machinesize_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.machinesize_label.Name = "machinesize_label";
            this.machinesize_label.Size = new System.Drawing.Size(51, 18);
            this.machinesize_label.TabIndex = 17;
            this.machinesize_label.Text = "サイズ";
            // 
            // machinecolor_label
            // 
            this.machinecolor_label.AutoSize = true;
            this.machinecolor_label.Location = new System.Drawing.Point(487, 126);
            this.machinecolor_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.machinecolor_label.Name = "machinecolor_label";
            this.machinecolor_label.Size = new System.Drawing.Size(26, 18);
            this.machinecolor_label.TabIndex = 18;
            this.machinecolor_label.Text = "色";
            // 
            // printsize_label
            // 
            this.printsize_label.AutoSize = true;
            this.printsize_label.Location = new System.Drawing.Point(483, 273);
            this.printsize_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printsize_label.Name = "printsize_label";
            this.printsize_label.Size = new System.Drawing.Size(51, 18);
            this.printsize_label.TabIndex = 19;
            this.printsize_label.Text = "サイズ";
            // 
            // printcolor_label
            // 
            this.printcolor_label.AutoSize = true;
            this.printcolor_label.Location = new System.Drawing.Point(487, 312);
            this.printcolor_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printcolor_label.Name = "printcolor_label";
            this.printcolor_label.Size = new System.Drawing.Size(26, 18);
            this.printcolor_label.TabIndex = 20;
            this.printcolor_label.Text = "色";
            // 
            // printside__label
            // 
            this.printside__label.AutoSize = true;
            this.printside__label.Location = new System.Drawing.Point(487, 352);
            this.printside__label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.printside__label.Name = "printside__label";
            this.printside__label.Size = new System.Drawing.Size(125, 18);
            this.printside__label.TabIndex = 21;
            this.printside__label.Text = "両面/片面印刷";
            // 
            // circulation_label
            // 
            this.circulation_label.AutoSize = true;
            this.circulation_label.Location = new System.Drawing.Point(483, 393);
            this.circulation_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.circulation_label.Name = "circulation_label";
            this.circulation_label.Size = new System.Drawing.Size(44, 18);
            this.circulation_label.TabIndex = 22;
            this.circulation_label.Text = "部数";
            // 
            // begintime_numericUpDown
            // 
            this.begintime_numericUpDown.Location = new System.Drawing.Point(87, 490);
            this.begintime_numericUpDown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.begintime_numericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.begintime_numericUpDown.Name = "begintime_numericUpDown";
            this.begintime_numericUpDown.Size = new System.Drawing.Size(83, 25);
            this.begintime_numericUpDown.TabIndex = 23;
            // 
            // endtime_numericUpDown
            // 
            this.endtime_numericUpDown.Location = new System.Drawing.Point(245, 490);
            this.endtime_numericUpDown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.endtime_numericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.endtime_numericUpDown.Name = "endtime_numericUpDown";
            this.endtime_numericUpDown.Size = new System.Drawing.Size(83, 25);
            this.endtime_numericUpDown.TabIndex = 24;
            // 
            // printbackcolor_comboBox
            // 
            this.printbackcolor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printbackcolor_comboBox.FormattingEnabled = true;
            this.printbackcolor_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.printbackcolor_comboBox.Location = new System.Drawing.Point(995, 312);
            this.printbackcolor_comboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.printbackcolor_comboBox.Name = "printbackcolor_comboBox";
            this.printbackcolor_comboBox.Size = new System.Drawing.Size(199, 26);
            this.printbackcolor_comboBox.TabIndex = 25;
            this.printbackcolor_comboBox.SelectionChangeCommitted += new System.EventHandler(this.printbackcolor_comboBox_SelectionChangeCommitted);
            // 
            // begintime_label
            // 
            this.begintime_label.AutoSize = true;
            this.begintime_label.Location = new System.Drawing.Point(84, 456);
            this.begintime_label.Name = "begintime_label";
            this.begintime_label.Size = new System.Drawing.Size(80, 18);
            this.begintime_label.TabIndex = 26;
            this.begintime_label.Text = "開始時間";
            // 
            // endtime_label
            // 
            this.endtime_label.AutoSize = true;
            this.endtime_label.Location = new System.Drawing.Point(248, 456);
            this.endtime_label.Name = "endtime_label";
            this.endtime_label.Size = new System.Drawing.Size(80, 18);
            this.endtime_label.TabIndex = 27;
            this.endtime_label.Text = "終了時間";
            // 
            // printbackcolor_label
            // 
            this.printbackcolor_label.AutoSize = true;
            this.printbackcolor_label.Location = new System.Drawing.Point(913, 312);
            this.printbackcolor_label.Name = "printbackcolor_label";
            this.printbackcolor_label.Size = new System.Drawing.Size(59, 18);
            this.printbackcolor_label.TabIndex = 28;
            this.printbackcolor_label.Text = "裏の色";
            // 
            // deadline_dateTimePicker
            // 
            this.deadline_dateTimePicker.Location = new System.Drawing.Point(995, 385);
            this.deadline_dateTimePicker.Name = "deadline_dateTimePicker";
            this.deadline_dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.deadline_dateTimePicker.TabIndex = 29;
            this.deadline_dateTimePicker.ValueChanged += new System.EventHandler(this.deadline_dateTimePicker_ValueChanged);
            // 
            // deadline_label
            // 
            this.deadline_label.AutoSize = true;
            this.deadline_label.Location = new System.Drawing.Point(920, 393);
            this.deadline_label.Name = "deadline_label";
            this.deadline_label.Size = new System.Drawing.Size(44, 18);
            this.deadline_label.TabIndex = 30;
            this.deadline_label.Text = "納期";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 1080);
            this.Controls.Add(this.deadline_label);
            this.Controls.Add(this.deadline_dateTimePicker);
            this.Controls.Add(this.printbackcolor_label);
            this.Controls.Add(this.endtime_label);
            this.Controls.Add(this.begintime_label);
            this.Controls.Add(this.printbackcolor_comboBox);
            this.Controls.Add(this.endtime_numericUpDown);
            this.Controls.Add(this.begintime_numericUpDown);
            this.Controls.Add(this.circulation_label);
            this.Controls.Add(this.printside__label);
            this.Controls.Add(this.printcolor_label);
            this.Controls.Add(this.printsize_label);
            this.Controls.Add(this.machinecolor_label);
            this.Controls.Add(this.machinesize_label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.printcount_button);
            this.Controls.Add(this.circulation_textBox);
            this.Controls.Add(this.printside_comboBox);
            this.Controls.Add(this.printcolor_comboBox);
            this.Controls.Add(this.printsize_comboBox);
            this.Controls.Add(this.print_listBox);
            this.Controls.Add(this.machinecolor_comboBox);
            this.Controls.Add(this.machinesize_comboBox);
            this.Controls.Add(this.machinecount_button);
            this.Controls.Add(this.machine_listBox);
            this.Controls.Add(this.insatsubutsu);
            this.Controls.Add(this.printcount);
            this.Controls.Add(this.insatsuki);
            this.Controls.Add(this.machinecount);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machinecount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begintime_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endtime_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown machinecount;
        private System.Windows.Forms.Label insatsuki;
        private System.Windows.Forms.NumericUpDown printcount;
        private System.Windows.Forms.Label insatsubutsu;
        private System.Windows.Forms.ListBox machine_listBox;
        private System.Windows.Forms.Button machinecount_button;
        private System.Windows.Forms.ComboBox machinesize_comboBox;
        private System.Windows.Forms.ComboBox machinecolor_comboBox;
        private System.Windows.Forms.ListBox print_listBox;
        private System.Windows.Forms.ComboBox printsize_comboBox;
        private System.Windows.Forms.ComboBox printcolor_comboBox;
        private System.Windows.Forms.ComboBox printside_comboBox;
        private System.Windows.Forms.TextBox circulation_textBox;
        private System.Windows.Forms.Button printcount_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label machinesize_label;
        private System.Windows.Forms.Label machinecolor_label;
        private System.Windows.Forms.Label printsize_label;
        private System.Windows.Forms.Label printcolor_label;
        private System.Windows.Forms.Label printside__label;
        private System.Windows.Forms.Label circulation_label;
        private System.Windows.Forms.NumericUpDown begintime_numericUpDown;
        private System.Windows.Forms.NumericUpDown endtime_numericUpDown;
        private System.Windows.Forms.ComboBox printbackcolor_comboBox;
        private System.Windows.Forms.Label begintime_label;
        private System.Windows.Forms.Label endtime_label;
        private System.Windows.Forms.Label printbackcolor_label;
        private System.Windows.Forms.DateTimePicker deadline_dateTimePicker;
        private System.Windows.Forms.Label deadline_label;
    }
}

