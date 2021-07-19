
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
            this.SuspendLayout();
            // 
            // Taxbtn
            // 
            this.Taxbtn.Font = new System.Drawing.Font("HGP行書体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Taxbtn.Location = new System.Drawing.Point(130, 142);
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
            this.VLTaxbtn.Location = new System.Drawing.Point(451, 142);
            this.VLTaxbtn.Name = "VLTaxbtn";
            this.VLTaxbtn.Size = new System.Drawing.Size(211, 120);
            this.VLTaxbtn.TabIndex = 1;
            this.VLTaxbtn.Text = "牌照稅試算";
            this.VLTaxbtn.UseVisualStyleBackColor = true;
            this.VLTaxbtn.Click += new System.EventHandler(this.VLTaxbtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VLTaxbtn);
            this.Controls.Add(this.Taxbtn);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Taxbtn;
        private System.Windows.Forms.Button VLTaxbtn;
    }
}