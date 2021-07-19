﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HW_W3
{
    public partial class VLTaxFrorm : Form
    {
        public VLTaxFrorm()
        {
            InitializeComponent();
        }

        private void VLTaxFrorm_Load(object sender, EventArgs e)
        {   
            if(Common.autobike_Tax.Count == 0)        
              Common.Car();
            this.Init();
        }
        /// <summary>
        /// 設定各物件初始值
        /// </summary>
        private void Init()
        {
            this.Car_combo.SelectedIndex = 0;
            this.CC_Combo.SelectedIndex = 0;
            this.result_Text.Text = null;
            this.dateTimePicker1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker2.Value = new DateTime(DateTime.Now.Year, 12, 31);


        }
//-----------------------------------combo box-------------------------------------------------------------------------
        private void Car_combo_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (this.Car_combo.SelectedIndex != -1)//依車種將汽缸CC數／馬達馬力放進CC_combo
            {
               
                if (this.Car_combo.Text == "機車")
                {                              
                    this.CC_Combo.DataSource = Common.autobike_Tax;
                    this.CC_Combo.DisplayMember = "Cc";
                    this.CC_Combo.ValueMember = "Type";
                }
                else if (this.Car_combo.Text == "貨車")
                {
                    this.CC_Combo.DataSource = Common.truck_Tax;
                    this.CC_Combo.DisplayMember = "Cc";
                    this.CC_Combo.ValueMember = "Type";
                }
                else if (this.Car_combo.Text == "大客車")
                {
                    this.CC_Combo.DataSource = Common.coach_Tax;
                    this.CC_Combo.DisplayMember = "Cc";
                    this.CC_Combo.ValueMember = "Type";
                }
                else if (this.Car_combo.Text == "自用小客車")
                {
                    this.CC_Combo.DataSource = Common.mysmalltruck_Tax;
                    this.CC_Combo.DisplayMember = "Cc";
                    this.CC_Combo.ValueMember = "Type";
                }
                else if (this.Car_combo.Text == "營業用小客車")
                {
                    this.CC_Combo.DataSource = Common.smalltruck_Tax;
                    this.CC_Combo.DisplayMember = "Cc";
                    this.CC_Combo.ValueMember = "Type";
                }
                
            }
        }

        private void CC_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//-----------------------------------combo box-------------------------------------------------------------------------
//---------------------------------radio button------------------------------------------------------------------------
        private void term_rbtn_CheckedChanged(object sender, EventArgs e)//選依期間時讓日曆出現在畫面上
        {
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
        }

        private void All_rbtn_CheckedChanged(object sender, EventArgs e)//選全年度關掉日曆
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
        }
//---------------------------------radio button-------------------------------------------------------------------------
//------------------------------------button----------------------------------------------------------------------------
        private void Reset_btn_Click(object sender, EventArgs e)//回到初始值
        {
            this.Init();
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            this.result_Text.Text = null;
            Calculate calculate = new Calculate();
            int tax = calculate.GetIntTax(Car_combo.SelectedIndex, CC_Combo.SelectedIndex);
            string cctext = calculate.GetStrType(Car_combo.SelectedIndex, CC_Combo.SelectedIndex);
            string typetext = calculate.GetStrCc(Car_combo.SelectedIndex, CC_Combo.SelectedIndex);
            if (All_rbtn.Checked) //全年度
            {
                DateTime startYear = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime endYear = new DateTime(DateTime.Now.Year, 12, 31);
                int days = DateTime.Now.Year;
                if (DateTime.IsLeapYear(days))//閏年判斷
                    days = 366;
                else
                    days = 365;

                result_Text.Text = tax.ToString();
                result_Text.Text = "使用期間:" + startYear.ToString("yyyy-MM-dd") + " ~ " + endYear.ToString("yyyy-MM-dd") + Environment.NewLine + $"計算天數: {days}天" + Environment.NewLine + "汽缸CC數: " +cctext + Environment.NewLine+ "用途: " +typetext + Environment.NewLine + $"計算公式:{tax}*{days}/{days} = {tax.ToString("#,0")} 元" + Environment.NewLine + $"應納稅額: 共 {tax.ToString("#,0")} 元" + Environment.NewLine ;
            }
            else if(term_rbtn.Checked)//依期間
            {
                DateTime sDate = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                DateTime eDate = Convert.ToDateTime(dateTimePicker2.Value.ToString());
                calculate.SetText(cctext, typetext);
                if (sDate > eDate) //處理日曆1的日期在日曆2的日期之後的狀況
                {
                    DateTime cDate = sDate;
                    sDate = eDate;
                    eDate = cDate;
                }    
                
                for ( int i = sDate.Year; i <= eDate.Year; i++)
                {

                    string str = "";                   
                    str = calculate.TermResult2( sDate,  eDate,  i, tax);
                    result_Text.Text += str;


                }
                result_Text.Text += $"全部應納稅額: 共 {((int)calculate.result).ToString("#,0")} 元";

            }
            pictureBox1.Visible = true;


        }
//------------------------------------button----------------------------------------------------------------------------
        private void result_Text_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
