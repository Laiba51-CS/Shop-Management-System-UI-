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
    public partial class reviewform : Form
    {
      
        public reviewform()
        {
            InitializeComponent();
        }
        public void databind()
        {

           grv_reviews.DataSource = null;
            grv_reviews.DataSource = reviewDL.viewReviews();
            grv_reviews.Refresh();

        }
        private void reviewform_Load(object sender, EventArgs e)
        {
            string path = "reviews.txt";
           string a= reviewDL.viewReviews();

            if (a == "We have no reviews to show....!")
            {
                string b = "nothing to show";
                MessageBox.Show(b);
            }
            else
            {
                grv_reviews.DataSource = reviewDL.viewReviews();
                reviewDL.read_data(path);
                DataGridViewRow row = grv_reviews.CurrentRow;
            }
           

            databind();
            if (grv_reviews == null)
            {
                string msg = "right no customer added any reviews about product";
                MessageBox.Show(msg);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new menuform();
            f.Show();
        }
    }
}
