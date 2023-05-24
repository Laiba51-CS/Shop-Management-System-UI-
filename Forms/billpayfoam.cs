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
    


    public partial class billpayfoam : Form
    {
        string name;
         int quantity;
        public billpayfoam()
        {
            InitializeComponent();
        }

        private void billpayfoam_Load(object sender, EventArgs e)
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
            Form frm = new custfoam();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            string name = txtbuy.Text;
             quantity = int.Parse(txtprice.Text);
            int price = 0;
            try
            {
                int quantity = int.Parse(txtprice.Text);
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
            foreach (Product a in ProductDL.products)
            {
                if (name == a.ProductName)
                {
                    price = a.Price * quantity;

                }
            }
            txtprice.Text = price.ToString();
        }
    }
}
