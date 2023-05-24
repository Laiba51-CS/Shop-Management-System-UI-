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
    public partial class orderfoam : Form
    {
        public orderfoam()
        {
            InitializeComponent();
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new compleorderfoam();
            frm.Show();
        }

        private void btnpend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new pendingfoam();
            f.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new menuform();
            f.Show();
        }

        private void orderfoam_Load(object sender, EventArgs e)
        {

        }
    }
}
