using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW_W3
{
    class Car_Tax
    {

        public Car_Tax( string _type, string _cc, int _tax)
        {
            Type = _type;//車種
            Cc = _cc;//汽缸CC數／馬達馬力
            Tax = _tax;//稅額
        }
        public string Type { get; set; }
        public string Cc { get; set; }
        public int Tax { get; set; }
    }
}
