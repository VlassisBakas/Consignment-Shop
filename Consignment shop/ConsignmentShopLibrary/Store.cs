using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignment_shop
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }
       // public List<ItemsPerVendor> itemsPerVendor { get; set; }
        public Store(string name)
        {
            Name = name;
            Items=new List<Item>();
            Vendors = new List<Vendor>();
        }
        
    }
}
