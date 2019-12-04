
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignment_shop
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentToVendor { get; set; }
        public Vendor Owener { get; set; } // δεν το θελω αλλα αυτος το βαζει

        public Item(string title, string description, decimal price,Vendor owener)
        {
            Title = title;
            Description = description;
            Price = price;
            Owener = owener;
        }
        public string Output
        {
            get{
                return string.Format($"{Title,-4} {Description,-2} {Price}");
            }
            
        }
    }
}
