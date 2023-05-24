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
    public partial class form4 : Form
    {
        string name = "";
        int price;
        int quantity;
            string brand = "";
        int threshold;


        public form4()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string path = "product.txt";
            
          
            
            try
            {
                 name = txtname.Text;
            
                
            
                price = int.Parse(txtprice.Text);
           
                if(price < 20 || price > 2000)
                {
                    throw new Exception("Invalid Price price should be in greater than 20 !");

                }
                int quantity = int.Parse(txtquant.Text);
            
           
                 brand = combobrand.Text;
            
               
            
                brand = combobrand.Text;
            
                 threshold = int.Parse(txtthreshold.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
            Product p = new Product(name, price, quantity, brand, threshold);
            ProductDL.addproductsintoList(p);
            ProductDL.addintotextFile(path, p);
            
            cleardata();

        }
        private void cleardata()
        {
            string name = "";
            int price = 0;
            int quantity = 0;
            string brand = "";
            int threshold = 0;

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new menuform();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form4_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
