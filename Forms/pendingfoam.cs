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
    public partial class pendingfoam : Form
    {
        public pendingfoam()
        {
            InitializeComponent();
        }

        private void pendingfoam_Load(object sender, EventArgs e)
        {
     

            string path = "pending.txt";
            orderDL.read_data(path);
            databind();

        }

        private void grv_pending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string path1 = "pending.txt";
            order o = (order)grv_pending.CurrentRow.DataBoundItem;
            if (grv_pending.Columns["COMPLETE"].Index == e.ColumnIndex)
            {
                string path2 = "order.txt";
                orderDL.storedata(path2);
                orderDL.orders.Remove(o);
                orderDL.storedata(path1);
                databind();

            }
            else
            {
                string oo = "oops";
                MessageBox.Show(oo);
            }
            

        }
        public void databind()
        {
            grv_pending.DataSource = null;
            grv_pending.DataSource = orderDL.orders;
            grv_pending.Refresh();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new orderfoam();
            f.Show();
        }
    }

    
}
