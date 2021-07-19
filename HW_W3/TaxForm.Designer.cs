
namespace HW_W3
{
    partial class TaxForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultMsg = new System.Windows.Forms.Label();
            this.TaxTypeMsg = new System.Windows.Forms.Label();
            this.amountMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultMsg);
            this.panel1.Controls.Add(this.TaxTypeMsg);
            this.panel1.Controls.Add(this.amountMsg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.Calculate);
            this.panel1.Controls.Add(this.lblresult);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(76, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // resultMsg
            // 
            this.resultMsg.AutoSize = true;
            this.resultMsg.Location = new System.Drawing.Point(660, 156);
            this.resultMsg.Name = "resultMsg";
            this.resultMsg.Size = new System.Drawing.Size(82, 15);
            this.resultMsg.TabIndex = 11;
            this.resultMsg.Text = "應繳印花稅";
            this.resultMsg.Visible = false;
            // 
            // TaxTypeMsg
            // 
            this.TaxTypeMsg.AutoSize = true;
            this.TaxTypeMsg.Location = new System.Drawing.Point(660, 99);
            this.TaxTypeMsg.Name = "TaxTypeMsg";
            this.TaxTypeMsg.Size = new System.Drawing.Size(82, 15);
            this.TaxTypeMsg.TabIndex = 10;
            this.TaxTypeMsg.Text = "印花稅種類";
            this.TaxTypeMsg.Visible = false;
            // 
            // amountMsg
            // 
            this.amountMsg.AutoSize = true;
            this.amountMsg.Location = new System.Drawing.Point(657, 47);
            this.amountMsg.Name = "amountMsg";
            this.amountMsg.Size = new System.Drawing.Size(12, 15);
            this.amountMsg.TabIndex = 9;
            this.amountMsg.Text = "-";
            this.amountMsg.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "元";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(457, 282);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(109, 34);
            this.reset.TabIndex = 7;
            this.reset.Text = "清除";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(330, 282);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(98, 34);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "確定";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(327, 156);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(29, 15);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "0元";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "銀錢收據",
            "承攬契據",
            "典賣、讓受及分割不動產契據"});
            this.comboBox1.Location = new System.Drawing.Point(330, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(330, 39);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(265, 25);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "0";
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(100, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "應繳印花稅";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(100, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "印花稅種類";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "收據或契據上之金額";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 716);
            this.Controls.Add(this.panel1);
            this.Name = "TaxForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TaxForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultMsg;
        private System.Windows.Forms.Label TaxTypeMsg;
        private System.Windows.Forms.Label amountMsg;
    }
}

