using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HW_W3
{
    public partial class TaxForm : Form
    {
        public TaxForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Init()
        {
            this.Amount.Text = "0";
            this.comboBox1.SelectedIndex = 0;
            this.lblresult.Text = "0元";
        }

        /// <summary>
        /// 依據下拉選單的項目，回傳稅率，不合理時回傳0
        /// </summary>
        /// <returns></returns>
        private double GetTaxPercenttage() 
        {

            if (this.comboBox1.SelectedIndex == -1)
                return 0;
            string taxType = this.comboBox1.Text;

            switch(taxType)
            {
                case "銀錢收據":
                    return 0.004;
                case "承攬契據":
                    return 0.001;
                case "典賣、讓受及分割不動產契據":
                    return 0.001;

                default:
                    return 0;


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void TaxForm_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //取得稅率
            decimal perc = (decimal)this.GetTaxPercenttage();
            //取得金額
            string amountText = this.Amount.Text;
            decimal amount ;


            //-------------檢查輸入值-------------------
            if (perc == 0 )
            {
                this.TaxTypeMsg.Text = "請輸入正確下拉選單";
                this.TaxTypeMsg.Visible = true;
            }
            else
               this.TaxTypeMsg.Visible = false;

            if (!decimal.TryParse(amountText, out amount))
            {
                this.amountMsg.Text = "請輸入正確金額";
                this.amountMsg.Visible = true;
            }
            else if( amount < 0 || amount > 1000000000)
            {
                this.amountMsg.Text = "正確金額不能小於0或大於10億";
                this.amountMsg.Visible = true;
            }
            else
                this.amountMsg.Visible = false;
            //-------------檢查輸入值-------------------

            //計算結果
            decimal result = amount * perc;
            if ( this.amountMsg.Visible || this.amountMsg.Visible)
                result = 0;
            else if (!this.amountMsg.Visible && !this.TaxTypeMsg.Visible)
                result = Math.Truncate(result);

            lblresult.Text = $"{result.ToString("#,0")}元";
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Amount_Leave(object sender, EventArgs e)
        {
            decimal amount;
            string sText = this.Amount.Text.Replace(",", "");
            if (decimal.TryParse(Amount.Text, out amount))
            {
                amount = Convert.ToDecimal(this.Amount.Text);
                this.Amount.Text = amount.ToString("###,###,###");
            }
        }
    }
}
