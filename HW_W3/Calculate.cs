using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W3
{
    class Calculate
    {
        /// <summary>
        /// 回傳對應的稅額
        /// </summary>
        /// <param name="CarIndex"></param>
        /// <param name="CcIndex"></param>
        /// <returns></returns>
        public int GetIntTax( int CarIndex, int CcIndex )
        {

            switch (CarIndex)
            {
                case 0:
                    return Common.autobike_Tax[CcIndex].Tax;
                case 1:
                    return Common.truck_Tax[CcIndex].Tax; 
                case 2:
                    return Common.coach_Tax[CcIndex].Tax;
                case 3:
                    return Common.mysmalltruck_Tax[CcIndex].Tax;
                case 4:
                    return Common.smalltruck_Tax[CcIndex].Tax;

                default:
                    return 0;


            }

        }
        /// <summary>
        /// 回傳對應的車種
        /// </summary>
        /// <param name="CarIndex"></param>
        /// <param name="CcIndex"></param>
        /// <returns></returns>
        public string GetStrType(int CarIndex, int CcIndex)
        {

            switch (CarIndex)
            {
                case 0:
                    return Common.autobike_Tax[CcIndex].Type;
                case 1:
                    return Common.truck_Tax[CcIndex].Type;
                case 2:
                    return Common.coach_Tax[CcIndex].Type;
                case 3:
                    return Common.mysmalltruck_Tax[CcIndex].Type;
                case 4:
                    return Common.smalltruck_Tax[CcIndex].Type;

                default:
                    return null;


            }

        }
        /// <summary>
        /// 回傳對應的汽缸CC數／馬達馬力
        /// </summary>
        /// <param name="CarIndex"></param>
        /// <param name="CcIndex"></param>
        /// <returns></returns>
        public string GetStrCc(int CarIndex, int CcIndex)
        {

            switch (CarIndex)
            {
                case 0:
                    return Common.autobike_Tax[CcIndex].Cc;
                case 1:
                    return Common.truck_Tax[CcIndex].Cc;
                case 2:
                    return Common.coach_Tax[CcIndex].Cc;
                case 3:
                    return Common.mysmalltruck_Tax[CcIndex].Cc;
                case 4:
                    return Common.smalltruck_Tax[CcIndex].Cc;

                default:
                    return null;


            }

        }
        /// <summary>
        /// 取得使用期間的日期
        /// </summary>
        /// <param name="sDate"></param>
        /// <param name="eDate"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public DateTime GetDate(DateTime sDate, DateTime eDate, int i,int j)
        {
            DateTime cDate = DateTime.Now;
           // string date = "";

            if( j == 1 )
            {
                if (sDate.Year == i)
                    cDate = sDate;
                else
                    cDate = new DateTime(i, 1, 1);

            }
            else if(j == 12)
            {
                if (eDate.Year == i)
                    cDate = eDate;
                else
                    cDate = new DateTime(i, 12, 31);
            }

            return cDate;
        }

     /*   public decimal TermResult(DateTime sDate, DateTime eDate, int i, decimal result)
        {

            int days = Days( sDate,  eDate,  i);

             if (DateTime.IsLeapYear(i))
                 return result * days / 366;
             else
                 return result * days / 365;

        }*/
        /// <summary>
        /// 不滿一年時判斷日數
        /// </summary>
        /// <param name="sDate"></param>
        /// <param name="eDate"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Days(DateTime sDate, DateTime eDate, int i)
        {
            int days = 0;
            if (DateTime.IsLeapYear(i))
                days = 366;
            else
                days = 365;

            if (i == sDate.Year && sDate != eDate)
            {
                string str = "12/31/" + i.ToString();
                DateTime dt = Convert.ToDateTime(str);
                TimeSpan ts = dt - sDate;
                days = (int)ts.TotalDays + 1;
            }
            else if (i == eDate.Year && sDate != eDate)
            {
                string str = "01/01/" + i.ToString();
                DateTime dt = Convert.ToDateTime(str);
                TimeSpan ts = eDate - dt;
                days = (int)ts.TotalDays + 1;
            }
            else if ( sDate == eDate)
            {
                days = 1;
            }
            return days;
        }
        /// <summary>
        /// 稅額計算並將計算結果放進字串並回傳
        /// </summary>
        /// <param name="sDate"></param>
        /// <param name="eDate"></param>
        /// <param name="i"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        public string TermResult2(DateTime sDate, DateTime eDate, int i, decimal tax)
        {
            decimal rtax = 0 ;
            string str = "";
            int days = Days(sDate, eDate, i);
            int days2 = 0;
            if (DateTime.IsLeapYear(i))//閏年判斷
            { 
                days2 = 366;
                rtax = tax * days / 366;
            }
            else
            { 
                days2 = 365;
                rtax = tax * days / 365;
            }

            DateTime minDate = GetDate(sDate, eDate, i, 1); DateTime maxDate = GetDate(sDate, eDate, i, 12);
            this.result += rtax;
            str =  "使用期間:" + minDate.ToString("yyyy-MM-dd") + " ~ " + maxDate.ToString("yyyy-MM-dd") + Environment.NewLine + $"計算天數: {days}天" + Environment.NewLine + "汽缸CC數: " + this.Cctext + Environment.NewLine + "用途: " + this.Typetext + Environment.NewLine + $"計算公式:{tax}*{days}/{days2} = {((int)rtax).ToString("#,0")} 元" + Environment.NewLine + $"應納稅額: 共 {((int)rtax).ToString("#,0")} 元" + Environment.NewLine + Environment.NewLine;


            return str;

        }
        public string Cctext { get; set; }
        public string Typetext { get; set; }
        public decimal result { get; set; }

        public void SetText(string cctext, string typetext )
        {
            this.Cctext = cctext;
            this.Typetext = typetext;
            this.result = 0;

        }


    }
}
