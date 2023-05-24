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
    public partial class placeorder : Form
    {
        public placeorder()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void placeorder_Load(object sender, EventArgs e)
        {
            string path = "product.txt";
            ProductDL.readdatafromfile(path);
            grv_view.DataSource = ProductDL.products;
            DataGridViewRow row = grv_view.CurrentRow;
            Product p = (Product)row.DataBoundItem;

        }

        private void grv_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new billpayfoam();
            f.Show();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }
    }
}
