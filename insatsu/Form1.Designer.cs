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
            this.textBox1.Location = new System.Drawing.Point(152, 819);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // machinecount
            // 
            this.machinecount.Location = new System.Drawing.Point(234, 102);
            this.machinecount.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.machinecount.Name = "machinecount";
            this.machinecount.Size = new System.Drawing.Size(133, 43);
            this.machinecount.TabIndex = 1;
            this.machinecount.ValueChanged += new System.EventHandler(this.machinecount_ValueChanged);
            // 
            // insatsuki
            // 
            this.insatsuki.AutoSize = true;
            this.insatsuki.Location = new System.Drawing.Point(41, 102);
            this.insatsuki.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.insatsuki.Name = "insatsuki";
            this.insatsuki.Size = new System.Drawing.Size(123, 36);
            this.insatsuki.TabIndex = 2;
            this.insatsuki.Text = "印刷機";
            // 
            // printcount
            // 
            this.printcount.Location = new System.Drawing.Point(234, 582);
            this.printcount.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.printcount.Name = "printcount";
            this.printcount.Size = new System.Drawing.Size(133, 43);
            this.printcount.TabIndex = 3;
            this.printcount.ValueChanged += new System.EventHandler(this.printcount_ValueChanged);
            // 
            // insatsubutsu
            // 
            this.insatsubutsu.AutoSize = true;
            this.insatsubutsu.Location = new System.Drawing.Point(41, 582);
            this.insatsubutsu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.insatsubutsu.Name = "insatsubutsu";
            this.insatsubutsu.Size = new System.Drawing.Size(123, 36);
            this.insatsubutsu.TabIndex = 4;
            this.insatsubutsu.Text = "印刷物";
            // 
            // machine_listBox
            // 
            this.machine_listBox.FormattingEnabled = true;
            this.machine_listBox.ItemHeight = 36;
            this.machine_listBox.Location = new System.Drawing.Point(466, 102);
            this.machine_listBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.machine_listBox.Name = "machine_listBox";
            this.machine_listBox.Size = new System.Drawing.Size(371, 256);
            this.machine_listBox.TabIndex = 5;
            this.machine_listBox.SelectedIndexChanged += new System.EventHandler(this.machine_listBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.machinesize_comboBox.Location = new System.Drawing.Point(1077, 96);
            this.machinesize_comboBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.machinesize_comboBox.Name = "machinesize_comboBox";
            this.machinesize_comboBox.Size = new System.Drawing.Size(374, 44);
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
            this.machinecolor_comboBox.Location = new System.Drawing.Point(1077, 219);
            this.machinecolor_comboBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.machinecolor_comboBox.Name = "machinecolor_comboBox";
            this.machinecolor_comboBox.Size = new System.Drawing.Size(374, 44);
            this.machinecolor_comboBox.TabIndex = 8;
            this.machinecolor_comboBox.SelectionChangeCommitted += new System.EventHandler(this.machinecolor_comboBox_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 2097);
            this.Controls.Add(this.machinecolor_comboBox);
            this.Controls.Add(this.machinesize_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.machine_listBox);
            this.Controls.Add(this.insatsubutsu);
            this.Controls.Add(this.printcount);
            this.Controls.Add(this.insatsuki);
            this.Controls.Add(this.machinecount);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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

