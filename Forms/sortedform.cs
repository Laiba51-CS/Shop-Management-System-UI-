using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_management_system.DL;
using Shop_management_system.Resources.BL;

namespace Shop_management_system.Forms
{
    public partial class sortedform : Form
    {
        public sortedform()
        {
            InitializeComponent();
        }

        private void sortedform_Load(object sender, EventArgs e)
        {
            string path = "product.txt";
            ProductDL.readdatafromfile(path);

            List<Product> p = ProductDL.sortedlist();
            grv_sort.DataSource = p;
        }

        private void grv_sort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm=new menuform();
            frm.Show();
        }
    }
}
