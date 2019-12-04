using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consignment_shop;

namespace ConsignmentStoreDemo
{
    public partial class ConsignmentStoreDemo : Form
    {
        private Store store = new Store("THE BOOKSTORE");
        private List<Item>ShoppingCartData = new List<Item>();
       
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentStoreDemo()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x=>x.Sold==false).ToList();
            ItemsListBox.DataSource = itemsBinding;
            ItemsListBox.DisplayMember = "Output";//παιρνει get! (property)
            ItemsListBox.ValueMember = "Output";//παιρνει get! (property)
            cartBinding.DataSource = ShoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;
            ShoppingCartListBox.DisplayMember = "Output";
            ShoppingCartListBox.ValueMember = "Output";
            vendorsBinding.DataSource = store.Vendors;
            VendorsListBox.DataSource = vendorsBinding;
            VendorsListBox.DisplayMember = "Output";
            VendorsListBox.ValueMember = "Output";






        }
        
        public void SetupData()
        {
          Vendor v1 = new Vendor("Giannis", "Papadopoulos");
          Vendor v2 = new Vendor("Thanasis", "Georgiadis");
            store.Vendors.Add(v1);
            store.Vendors.Add(v2);

            Item i1 = new Item("Harry Potter", "Fantasy book", 18.90M, v1);
            Item i2 = new Item("Game of Thrones", "Fantasy book/Epic Saga", 30.90M,v1);
            Item i3 = new Item("Endgame", "Adventure book", 18.90M,v1);
            Item i4 = new Item("The cronicles of Narnia", "Fantasy book", 25.30M,v2);
            Item i5 = new Item("The basics of economy", "Academic book", 50.50M,v2);

            store.Items.Add(i1);
            store.Items.Add(i2);
            store.Items.Add(i3);
            store.Items.Add(i4);
            store.Items.Add(i5);

            



        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ItemsListBox.SelectedItem;
            
            ShoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            foreach (var item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owener.Payment += Convert.ToDecimal(item.Owener.CommissionRate) * item.Price;
                storeProfit +=( 1 - Convert.ToDecimal(item.Owener.CommissionRate)) * item.Price;
            }
            ShoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            StoreProfitValue.Text = storeProfit.ToString();
        }

       
    }
    
        



        
         
 }
           
    

