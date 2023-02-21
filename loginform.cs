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

namespace Shop_management_system
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            string path1 = "data.txt";
            
            
            MuserDL.readData(path1);

            


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string pass = password.Text;
            Muser users = new Muser(username, pass, null);
            string validuser = MuserDL.isExist(users);
            if (validuser =="admin"|| validuser=="Admin")
            {

                changeform();
            }
            else if(validuser=="customer")
            {

                changefoam2();
            }
            cleardata();

        }
        public void changefoam2()
        {
            this.Hide();
            Form f = new Forms.custfoam();
            f.Show();

        }
        private void cleardata()
        {
            user.Text = "";
            password.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
        private void changeform()
        {
            this.Hide();
            Form frm = new Forms.menuform();
            frm.Show();

        }

        private void forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new Forms.signinform();
            frm.Show();
            
            
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
