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
    public partial class viewform : Form
    {
        public viewform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void viewform_Load_1(object sender, EventArgs e)
        {
            string path = "product.txt";
            ProductDL.readdatafromfile(path);
            grv_view.DataSource = ProductDL.products;
            DataGridViewRow row = grv_view.CurrentRow;
            Product p = (Product)row.DataBoundItem;
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new menuform();
            frm.Show();
        }

        private void grv_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
