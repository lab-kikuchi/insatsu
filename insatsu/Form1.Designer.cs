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
            ((System.ComponentModel.ISupportInitialize)(this.machinecount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printcount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // machinecount
            // 
            this.machinecount.Location = new System.Drawing.Point(74, 34);
            this.machinecount.Name = "machinecount";
            this.machinecount.Size = new System.Drawing.Size(42, 19);
            this.machinecount.TabIndex = 1;
            this.machinecount.ValueChanged += new System.EventHandler(this.machinecount_ValueChanged);
            // 
            // insatsuki
            // 
            this.insatsuki.AutoSize = true;
            this.insatsuki.Location = new System.Drawing.Point(13, 34);
            this.insatsuki.Name = "insatsuki";
            this.insatsuki.Size = new System.Drawing.Size(41, 12);
            this.insatsuki.TabIndex = 2;
            this.insatsuki.Text = "印刷機";
            // 
            // printcount
            // 
            this.printcount.Location = new System.Drawing.Point(74, 194);
            this.printcount.Name = "printcount";
            this.printcount.Size = new System.Drawing.Size(42, 19);
            this.printcount.TabIndex = 3;
            this.printcount.ValueChanged += new System.EventHandler(this.printcount_ValueChanged);
            // 
            // insatsubutsu
            // 
            this.insatsubutsu.AutoSize = true;
            this.insatsubutsu.Location = new System.Drawing.Point(13, 194);
            this.insatsubutsu.Name = "insatsubutsu";
            this.insatsubutsu.Size = new System.Drawing.Size(41, 12);
            this.insatsubutsu.TabIndex = 4;
            this.insatsubutsu.Text = "印刷物";
            // 
            // machine_listBox
            // 
            this.machine_listBox.FormattingEnabled = true;
            this.machine_listBox.ItemHeight = 12;
            this.machine_listBox.Location = new System.Drawing.Point(147, 34);
            this.machine_listBox.Name = "machine_listBox";
            this.machine_listBox.Size = new System.Drawing.Size(120, 88);
            this.machine_listBox.TabIndex = 5;
            this.machine_listBox.SelectedIndexChanged += new System.EventHandler(this.machine_listBox_SelectedIndexChanged);
            // 
            // machinecount_button
            // 
            this.machinecount_button.Location = new System.Drawing.Point(41, 73);
            this.machinecount_button.Name = "machinecount_button";
            this.machinecount_button.Size = new System.Drawing.Size(75, 23);
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
            this.machinesize_comboBox.Location = new System.Drawing.Point(340, 32);
            this.machinesize_comboBox.Name = "machinesize_comboBox";
            this.machinesize_comboBox.Size = new System.Drawing.Size(121, 20);
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
            this.machinecolor_comboBox.Location = new System.Drawing.Point(340, 73);
            this.machinecolor_comboBox.Name = "machinecolor_comboBox";
            this.machinecolor_comboBox.Size = new System.Drawing.Size(121, 20);
            this.machinecolor_comboBox.TabIndex = 8;
            this.machinecolor_comboBox.SelectionChangeCommitted += new System.EventHandler(this.machinecolor_comboBox_SelectionChangeCommitted);
            // 
            // print_listBox
            // 
            this.print_listBox.FormattingEnabled = true;
            this.print_listBox.ItemHeight = 12;
            this.print_listBox.Location = new System.Drawing.Point(147, 177);
            this.print_listBox.Name = "print_listBox";
            this.print_listBox.Size = new System.Drawing.Size(120, 88);
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
            this.printsize_comboBox.Location = new System.Drawing.Point(340, 177);
            this.printsize_comboBox.Name = "printsize_comboBox";
            this.printsize_comboBox.Size = new System.Drawing.Size(121, 20);
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
            this.printcolor_comboBox.Location = new System.Drawing.Point(340, 203);
            this.printcolor_comboBox.Name = "printcolor_comboBox";
            this.printcolor_comboBox.Size = new System.Drawing.Size(121, 20);
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
            this.printside_comboBox.Location = new System.Drawing.Point(340, 230);
            this.printside_comboBox.Name = "printside_comboBox";
            this.printside_comboBox.Size = new System.Drawing.Size(121, 20);
            this.printside_comboBox.TabIndex = 12;
            this.printside_comboBox.SelectedIndexChanged += new System.EventHandler(this.printside_comboBox_SelectedIndexChanged);
            // 
            // circulation_textBox
            // 
            this.circulation_textBox.Location = new System.Drawing.Point(340, 257);
            this.circulation_textBox.Name = "circulation_textBox";
            this.circulation_textBox.Size = new System.Drawing.Size(121, 19);
            this.circulation_textBox.TabIndex = 13;
            // 
            // printcount_button
            // 
            this.printcount_button.Location = new System.Drawing.Point(41, 230);
            this.printcount_button.Name = "printcount_button";
            this.printcount_button.Size = new System.Drawing.Size(75, 23);
            this.printcount_button.TabIndex = 14;
            this.printcount_button.Text = "確定";
            this.printcount_button.UseVisualStyleBackColor = true;
            this.printcount_button.Click += new System.EventHandler(this.printcount_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 474);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machinecount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printcount)).EndInit();
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
    }
}

