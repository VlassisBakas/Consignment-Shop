using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignment_shop
{
    public class Vendor
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public double CommissionRate { get; set; }
        public decimal Payment { get; set; } 

        public Vendor(string fname, string lname)
        {
            FName = fname;
            LName = lname;
            CommissionRate = 0.50;
        }

        public string Output
        {
            get
            {
                return string.Format($"{FName,-4} {LName,-2} {Payment}");
            }

        }

    }
}
