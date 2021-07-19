
namespace HW_W3
{
    partial class VLTaxFrorm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CC_Combo = new System.Windows.Forms.ComboBox();
            this.All_rbtn = new System.Windows.Forms.RadioButton();
            this.term_rbtn = new System.Windows.Forms.RadioButton();
            this.Car_combo = new System.Windows.Forms.ComboBox();
            this.result_Text = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CC_Combo
            // 
            this.CC_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC_Combo.FormattingEnabled = true;
            this.CC_Combo.Location = new System.Drawing.Point(6, 24);
            this.CC_Combo.Name = "CC_Combo";
            this.CC_Combo.Size = new System.Drawing.Size(405, 28);
            this.CC_Combo.TabIndex = 0;
            this.CC_Combo.SelectedIndexChanged += new System.EventHandler(this.CC_Combo_SelectedIndexChanged);
            // 
            // All_rbtn
            // 
            this.All_rbtn.AutoSize = true;
            this.All_rbtn.Checked = true;
            this.All_rbtn.Location = new System.Drawing.Point(6, 43);
            this.All_rbtn.Name = "All_rbtn";
            this.All_rbtn.Size = new System.Drawing.Size(81, 24);
            this.All_rbtn.TabIndex = 1;
            this.All_rbtn.TabStop = true;
            this.All_rbtn.Text = "全年度";
            this.All_rbtn.UseVisualStyleBackColor = true;
            this.All_rbtn.CheckedChanged += new System.EventHandler(this.All_rbtn_CheckedChanged);
            // 
            // term_rbtn
            // 
            this.term_rbtn.AutoSize = true;
            this.term_rbtn.Location = new System.Drawing.Point(115, 43);
            this.term_rbtn.Name = "term_rbtn";
            this.term_rbtn.Size = new System.Drawing.Size(81, 24);
            this.term_rbtn.TabIndex = 2;
            this.term_rbtn.Text = "依期間";
            this.term_rbtn.UseVisualStyleBackColor = true;
            this.term_rbtn.CheckedChanged += new System.EventHandler(this.term_rbtn_CheckedChanged);
            // 
            // Car_combo
            // 
            this.Car_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Car_combo.FormattingEnabled = true;
            this.Car_combo.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.Car_combo.Location = new System.Drawing.Point(6, 32);
            this.Car_combo.Name = "Car_combo";
            this.Car_combo.Size = new System.Drawing.Size(405, 28);
            this.Car_combo.TabIndex = 3;
            this.Car_combo.SelectedIndexChanged += new System.EventHandler(this.Car_combo_SelectedIndexChanged);
            // 
            // result_Text
            // 
            this.result_Text.BackColor = System.Drawing.SystemColors.Control;
            this.result_Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.result_Text.Location = new System.Drawing.Point(0, 24);
            this.result_Text.Multiline = true;
            this.result_Text.Name = "result_Text";
            this.result_Text.Size = new System.Drawing.Size(432, 484);
            this.result_Text.TabIndex = 4;
            this.result_Text.TextChanged += new System.EventHandler(this.result_Text_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 18);
            this.dateTimePicker1.MaxDate = new System.DateTime(2121, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(459, 67);
            this.dateTimePicker2.MaxDate = new System.DateTime(2121, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(424, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "從";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(424, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "至";
            this.label2.Visible = false;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Calculate_btn.Location = new System.Drawing.Point(506, 334);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(118, 47);
            this.Calculate_btn.TabIndex = 9;
            this.Calculate_btn.Text = "試算";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_btn.Location = new System.Drawing.Point(653, 334);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(109, 47);
            this.Reset_btn.TabIndex = 10;
            this.Reset_btn.Text = "清除";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.term_rbtn);
            this.groupBox1.Controls.Add(this.All_rbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(47, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 106);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用期間";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Car_combo);
            this.groupBox2.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(47, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 71);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用途";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CC_Combo);
            this.groupBox3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(47, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 65);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "汽缸CC數／馬達馬力";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.result_Text);
            this.groupBox4.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox4.Location = new System.Drawing.Point(47, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 526);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "試算結果";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HW_W3.Properties.Resources.エリナb_バニー__エリナb_12h;
            this.pictureBox1.Location = new System.Drawing.Point(493, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 431);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // VLTaxFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(811, 976);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Calculate_btn);
            this.Name = "VLTaxFrorm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VLTaxFrorm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CC_Combo;
        private System.Windows.Forms.RadioButton All_rbtn;
        private System.Windows.Forms.RadioButton term_rbtn;
        private System.Windows.Forms.ComboBox Car_combo;
        private System.Windows.Forms.TextBox result_Text;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}