using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_management_system.Resources.BL
{
    class soldtype
    {
        private string productName;
        private int quantity;
        private int price;
        public soldtype()
        {

        }
        public soldtype(string productName, int quantity, int price)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

