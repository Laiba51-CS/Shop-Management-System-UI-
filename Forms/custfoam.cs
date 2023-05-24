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
    public partial class custfoam : Form
    {
        public custfoam()
        {
            InitializeComponent();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new buyfoam();
            f.Show();
        }

        private void custfoam_Load(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form frm = new datafoam();
            frm.Show();

        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new billpayfoam();
            f.Show();
        }

        private void btnreview_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new reviewfoam();
            f.Show();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
