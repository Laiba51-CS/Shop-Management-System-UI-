using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_management_system.Resources.BL
{
    class Product
    {
        private string productName;
        private int price;
        private int quantity;
        private string brand;
        private int threshold;
        public Product()
        {
        }
        public Product(string productName, int price, int quantity, string Brand, int threshold)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
            this.Brand = Brand;
            this.Threshold = threshold;
        }
       

        public string ProductName { get => productName; set => productName = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Threshold { get => threshold; set => threshold = value; }
    }
}
