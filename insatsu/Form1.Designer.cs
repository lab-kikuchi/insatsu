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
            this.button1 = new System.Windows.Forms.Button();
            this.machinesize_comboBox = new System.Windows.Forms.ComboBox();
            this.machinecolor_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.machinecount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printcount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 273);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // machinesize_comboBox
            // 
            this.machinesize_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machinesize_comboBox.FormattingEnabled = true;
            this.machinesize_comboBox.Location = new System.Drawing.Point(340, 32);
            this.machinesize_comboBox.Name = "machinesize_comboBox";
            this.machinesize_comboBox.Size = new System.Drawing.Size(121, 20);
            this.machinesize_comboBox.TabIndex = 7;
            // 
            // machinecolor_comboBox
            // 
            this.machinecolor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machinecolor_comboBox.FormattingEnabled = true;
            this.machinecolor_comboBox.Location = new System.Drawing.Point(340, 73);
            this.machinecolor_comboBox.Name = "machinecolor_comboBox";
            this.machinecolor_comboBox.Size = new System.Drawing.Size(121, 20);
            this.machinecolor_comboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 722);
            this.Controls.Add(this.machinecolor_comboBox);
            this.Controls.Add(this.machinesize_comboBox);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox machinesize_comboBox;
        private System.Windows.Forms.ComboBox machinecolor_comboBox;
    }
}

