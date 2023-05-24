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

    public partial class datafoam : Form
    {
        int quantity;
        string phoneno;
        string address;
        string cname;
        string name;


        public datafoam()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            

            string msg = "order added successfully";
            MessageBox.Show(msg);
            cleardata();
        }
        public void cleardata()
        {
           
               txtpname.Text="";
            txtquant.Text="";
             txtcname.Text="";
           txtaddres.Text="";
            txtphone.Text="";

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new custfoam();
            f.Show();
        }

        private void datafoam_Load(object sender, EventArgs e)
        {
       


            try
            {
                quantity = int.Parse(txtquant.Text);
            }
            catch(Exception m)
            {

                MessageBox.Show(m.Message);
            }
            try
            {
                 name = txtpname.Text;
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
            try
            {
                 address = txtaddres.Text;
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
            try
            {
                phoneno = txtphone.Text;
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
            try
            {
                cname = txtcname.Text;
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }



            string path = "order.txt";
            

           
            
            order o = new order(name, cname, quantity, address, phoneno);
            orderDL.addintolist(o);
            orderDL.storedata(path);
        }

        private void txtpname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
