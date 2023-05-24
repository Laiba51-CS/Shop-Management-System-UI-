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
    public partial class stockfoam : Form
    {
        public stockfoam()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void databind()
        {
            grv_stock.DataSource = null;
            grv_stock.DataSource = ProductDL.stockToManage();
            grv_stock.Refresh();
        }

        private void stockfoam_Load(object sender, EventArgs e)
        {
           
            List<Product>p = ProductDL.stockToManage();
            grv_stock.DataSource = p;
            if(p==null)
            {
                string  msg= "NO customer buy products that why nothing to show";
                MessageBox.Show(msg);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new menuform();
            frm.Show();
        }
    }
}
