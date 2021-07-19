
namespace HW_W3
{
    partial class Main
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
            this.Taxbtn = new System.Windows.Forms.Button();
            this.VLTaxbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Taxbtn
            // 
            this.Taxbtn.Font = new System.Drawing.Font("HGP行書体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Taxbtn.Location = new System.Drawing.Point(79, 189);
            this.Taxbtn.Name = "Taxbtn";
            this.Taxbtn.Size = new System.Drawing.Size(207, 120);
            this.Taxbtn.TabIndex = 0;
            this.Taxbtn.Text = "印花稅試算";
            this.Taxbtn.UseVisualStyleBackColor = true;
            this.Taxbtn.Click += new System.EventHandler(this.Taxbtn_Click);
            // 
            // VLTaxbtn
            // 
            this.VLTaxbtn.Font = new System.Drawing.Font("HG行書体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VLTaxbtn.Location = new System.Drawing.Point(322, 189);
            this.VLTaxbtn.Name = "VLTaxbtn";
            this.VLTaxbtn.Size = new System.Drawing.Size(211, 120);
            this.VLTaxbtn.TabIndex = 1;
            this.VLTaxbtn.Text = "牌照稅試算";
            this.VLTaxbtn.UseVisualStyleBackColor = true;
            this.VLTaxbtn.Click += new System.EventHandler(this.VLTaxbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG正楷書体-PRO", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(130, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "歡迎使用稅額試算系統\r\n本系統提供印花稅跟牌照稅二種試算";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(41, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(683, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "注意:本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HG行書体", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(562, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 120);
            this.button1.TabIndex = 4;
            this.button1.Text = "結束系統";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VLTaxbtn);
            this.Controls.Add(this.Taxbtn);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Taxbtn;
        private System.Windows.Forms.Button VLTaxbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}