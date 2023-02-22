using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_management_system.Resources.BL
{
    class order
    {
        private string productName;
        private string customerName;
        private string address;
        private int orderQuantity;
        private string phoneNo;
        private int orderOK;
        public order()
        {

        }
        public order(string productName, string customerName,int orderQuantity, string address, string phoneNo)
        {
            this.productName = productName;
            this.address = address;
            this.orderQuantity = orderQuantity;
            this.phoneNo = phoneNo;
            this.CustomerName = customerName;
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int OrderQuantity
        {
            get { return orderQuantity; }
            set { orderQuantity = value; }
        }
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
        public int OrderOk
        {
            get { return orderOK; }
            set { orderOK = value; }
        }

        public string CustomerName { get => customerName; set => customerName = value; }
    }
}
