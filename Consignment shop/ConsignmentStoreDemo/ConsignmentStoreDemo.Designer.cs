namespace ConsignmentStoreDemo
{
    partial class ConsignmentStoreDemo
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddToCart = new System.Windows.Forms.Button();
            this.StoreItems = new System.Windows.Forms.Label();
            this.ShoppingCart = new System.Windows.Forms.Label();
            this.MakePurchase = new System.Windows.Forms.Button();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.VendorsListBoxLabel = new System.Windows.Forms.Label();
            this.VendorsListBox = new System.Windows.Forms.ListBox();
            this.StoreProfit = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HeaderText.Location = new System.Drawing.Point(38, 9);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(234, 29);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consignment Shop";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(43, 96);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(268, 186);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(342, 173);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(100, 29);
            this.AddToCart.TabIndex = 2;
            this.AddToCart.Text = "Add to Cart -->";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // StoreItems
            // 
            this.StoreItems.AutoSize = true;
            this.StoreItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StoreItems.Location = new System.Drawing.Point(39, 62);
            this.StoreItems.Name = "StoreItems";
            this.StoreItems.Size = new System.Drawing.Size(103, 20);
            this.StoreItems.TabIndex = 3;
            this.StoreItems.Text = "Store Items";
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.AutoSize = true;
            this.ShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ShoppingCart.Location = new System.Drawing.Point(467, 62);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Size = new System.Drawing.Size(124, 20);
            this.ShoppingCart.TabIndex = 6;
            this.ShoppingCart.Text = "Shopping Cart";
            // 
            // MakePurchase
            // 
            this.MakePurchase.Location = new System.Drawing.Point(639, 299);
            this.MakePurchase.Name = "MakePurchase";
            this.MakePurchase.Size = new System.Drawing.Size(100, 29);
            this.MakePurchase.TabIndex = 5;
            this.MakePurchase.Text = "Purchase";
            this.MakePurchase.UseVisualStyleBackColor = true;
            this.MakePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(471, 96);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(268, 186);
            this.ShoppingCartListBox.TabIndex = 4;
            // 
            // VendorsListBoxLabel
            // 
            this.VendorsListBoxLabel.AutoSize = true;
            this.VendorsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.VendorsListBoxLabel.Location = new System.Drawing.Point(39, 304);
            this.VendorsListBoxLabel.Name = "VendorsListBoxLabel";
            this.VendorsListBoxLabel.Size = new System.Drawing.Size(76, 20);
            this.VendorsListBoxLabel.TabIndex = 8;
            this.VendorsListBoxLabel.Text = "Vendors";
            // 
            // VendorsListBox
            // 
            this.VendorsListBox.FormattingEnabled = true;
            this.VendorsListBox.Location = new System.Drawing.Point(43, 338);
            this.VendorsListBox.Name = "VendorsListBox";
            this.VendorsListBox.Size = new System.Drawing.Size(268, 186);
            this.VendorsListBox.TabIndex = 7;
            // 
            // StoreProfit
            // 
            this.StoreProfit.AutoSize = true;
            this.StoreProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StoreProfit.Location = new System.Drawing.Point(467, 338);
            this.StoreProfit.Name = "StoreProfit";
            this.StoreProfit.Size = new System.Drawing.Size(101, 20);
            this.StoreProfit.TabIndex = 9;
            this.StoreProfit.Text = "Store Profit";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StoreProfitValue.Location = new System.Drawing.Point(576, 338);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(85, 20);
            this.StoreProfitValue.TabIndex = 10;
            this.StoreProfitValue.Text = "0.00 euro";
            // 
            // ConsignmentStoreDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfit);
            this.Controls.Add(this.VendorsListBoxLabel);
            this.Controls.Add(this.VendorsListBox);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.MakePurchase);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.StoreItems);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.HeaderText);
            this.Name = "ConsignmentStoreDemo";
            this.ShowIcon = false;
            this.Text = "Consignment Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label StoreItems;
        private System.Windows.Forms.Label ShoppingCart;
        private System.Windows.Forms.Button MakePurchase;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Label VendorsListBoxLabel;
        private System.Windows.Forms.ListBox VendorsListBox;
        private System.Windows.Forms.Label StoreProfit;
        private System.Windows.Forms.Label StoreProfitValue;
    }
}

