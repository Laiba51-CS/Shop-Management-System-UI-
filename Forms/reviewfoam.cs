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
    public partial class reviewfoam : Form
    {
        public reviewfoam()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           string  revi = txtreview.Text;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new custfoam();
            f.Show();
        }
    }
}
