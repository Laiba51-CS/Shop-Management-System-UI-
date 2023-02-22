using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_management_system.Resources.BL
{
    class Customer

    {

        private string customerName;

        private List<soldtype> purchased;

        public Customer(string customerName)
        {
            this.CustomerName = customerName;
            Purchased = new List<soldtype>();
        }
        public string CustomerName { get => customerName; set => customerName = value; }
        internal List<soldtype> Purchased { get => purchased; set => purchased = value; }

        public List<soldtype> getProductList()
        {
            if (purchased != null)
            {
                return purchased;
            }
            return null;
        }
        public void addBuyedProduct(soldtype buyed)
        {
            purchased.Add(buyed);
        }

    }
}
