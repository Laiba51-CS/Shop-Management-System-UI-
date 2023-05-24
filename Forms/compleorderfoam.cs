using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_management_system.Resources.BL;
using Shop_management_system.DL;



namespace Shop_management_system.Forms
{
    public partial class compleorderfoam : Form
    {
        public compleorderfoam()
        {
            InitializeComponent();
        }

        private void grv_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void compleorderfoam_Load(object sender, EventArgs e)
        {
            string path = "order.txt";
            orderDL.read_data(path);
            grv_pending.DataSource = orderDL.orders;
            DataGridViewRow row = grv_pending.CurrentRow;
            order o = (order)row.DataBoundItem;

        }
    }
}
