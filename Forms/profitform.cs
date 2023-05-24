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


namespace Shop_management_system.Forms
{
    public partial class profitform : Form
    {
        public profitform()
        {
            InitializeComponent();
        }

        private void grv_profit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void databind()
        {
            grv_profit.DataSource = null;
            grv_profit.DataSource = soldtypeDL.solditmes;
            grv_profit.Refresh();
        }

        private void profitform_Load(object sender, EventArgs e)
        {
           
          
            
      
            string path = "sold.txt";
            soldtypeDL.readData(path);
            databind();
            string a = soldtypeDL.displayprofit(soldtypeDL.solditmes);
            lblprofit.Text = a;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblprofit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new menuform();
            frm.Show();
        }
    }
}
