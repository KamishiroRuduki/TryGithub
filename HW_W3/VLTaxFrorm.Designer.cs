
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
            this.SuspendLayout();
            // 
            // CC_Combo
            // 
            this.CC_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC_Combo.FormattingEnabled = true;
            this.CC_Combo.Location = new System.Drawing.Point(57, 184);
            this.CC_Combo.Name = "CC_Combo";
            this.CC_Combo.Size = new System.Drawing.Size(405, 23);
            this.CC_Combo.TabIndex = 0;
            this.CC_Combo.SelectedIndexChanged += new System.EventHandler(this.CC_Combo_SelectedIndexChanged);
            // 
            // All_rbtn
            // 
            this.All_rbtn.AutoSize = true;
            this.All_rbtn.Checked = true;
            this.All_rbtn.Location = new System.Drawing.Point(57, 51);
            this.All_rbtn.Name = "All_rbtn";
            this.All_rbtn.Size = new System.Drawing.Size(73, 19);
            this.All_rbtn.TabIndex = 1;
            this.All_rbtn.TabStop = true;
            this.All_rbtn.Text = "全年度";
            this.All_rbtn.UseVisualStyleBackColor = true;
            this.All_rbtn.CheckedChanged += new System.EventHandler(this.All_rbtn_CheckedChanged);
            // 
            // term_rbtn
            // 
            this.term_rbtn.AutoSize = true;
            this.term_rbtn.Location = new System.Drawing.Point(179, 51);
            this.term_rbtn.Name = "term_rbtn";
            this.term_rbtn.Size = new System.Drawing.Size(73, 19);
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
            this.Car_combo.Location = new System.Drawing.Point(57, 128);
            this.Car_combo.Name = "Car_combo";
            this.Car_combo.Size = new System.Drawing.Size(405, 23);
            this.Car_combo.TabIndex = 3;
            this.Car_combo.SelectedIndexChanged += new System.EventHandler(this.Car_combo_SelectedIndexChanged);
            // 
            // result_Text
            // 
            this.result_Text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.result_Text.Location = new System.Drawing.Point(57, 242);
            this.result_Text.Multiline = true;
            this.result_Text.Name = "result_Text";
            this.result_Text.Size = new System.Drawing.Size(405, 395);
            this.result_Text.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 49);
            this.dateTimePicker1.MaxDate = new System.DateTime(2121, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(513, 90);
            this.dateTimePicker2.MaxDate = new System.DateTime(2121, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1921, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(478, 49);
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
            this.label2.Location = new System.Drawing.Point(478, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "至";
            this.label2.Visible = false;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(486, 242);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(118, 47);
            this.Calculate_btn.TabIndex = 9;
            this.Calculate_btn.Text = "試算";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(626, 242);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(109, 47);
            this.Reset_btn.TabIndex = 10;
            this.Reset_btn.Text = "清除";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // VLTaxFrorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 716);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.result_Text);
            this.Controls.Add(this.Car_combo);
            this.Controls.Add(this.term_rbtn);
            this.Controls.Add(this.All_rbtn);
            this.Controls.Add(this.CC_Combo);
            this.Name = "VLTaxFrorm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VLTaxFrorm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}