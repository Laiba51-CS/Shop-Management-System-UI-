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
    public partial class Editform : Form
    {
        public Editform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editform_Load(object sender, EventArgs e)
        {
            string path = "product.txt";
            ProductDL.readdatafromfile(path);
             databind();
            
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void databind()
        {
            grv_2.DataSource = null;
            grv_2.DataSource = ProductDL.products;
            grv_2.Refresh();

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            string path = "product.txt";
            Product p = (Product)grv_2.CurrentRow.DataBoundItem;
            if (grv_2.Columns["Edit"].Index == e.ColumnIndex)
            {
                this.Close();
                Form f = new Forms.form4();
                f.Show();
                ProductDL.storeData(path);
                databind();

            }
            else if (grv_2.Columns["Delete"].Index == e.ColumnIndex)
            {
               ProductDL.products.Remove(p);
                ProductDL.storeData(path);
                databind();
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
