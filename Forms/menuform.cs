using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_management_system.Forms
{
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }

        

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form f = new Forms.form4();
            f.Show();
        }

        private void lblheader_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new viewform();
            f.Show();
        }

        private void menuform_Load(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new Editform();
            f.Show();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new orderfoam();
            f.Show();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new stockfoam();
            f.Show();
        }

        private void btnprofit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new profitform();
            frm.Show();
        }

        private void btnsorted_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new sortedform();
            frm.Show();
        }

        private void btnreviews_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new reviewform();
            frm.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instruction_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new labfoam();
            f.Show();
        }
    }
}
