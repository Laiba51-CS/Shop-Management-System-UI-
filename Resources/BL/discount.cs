using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_management_system.Resources.BL
{
    class Discount
    {
        private bool flag;
        private int price;
        private float dis;
        public Discount()
        {

        }
        public Discount(int price, float dis, bool flag)
        {
            this.price = price;
            this.dis = dis;
            this.flag = flag;
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public float Dis
        {
            get { return dis; }
            set { dis = value; }
        }
        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
    }
}

