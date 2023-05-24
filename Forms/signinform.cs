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
    public partial class signinform : Form
    {
        public signinform()
        {
            InitializeComponent();
            
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {  
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            
            string path1 = "data.txt";
            string users = user.Text;
            string pass = password.Text;
            string rol = role.Text;
            Muser u = new Muser(users, pass, rol);
            MuserDL.storeData(path1);
            MuserDL.AddUserIntoList(u);
            MessageBox.Show(" you are sign in the data now you can login the system");
            cleardata();

        }
        private void cleardata()
        {
            user.Text = "";
            password.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new loginform();
            frm.Show();


        }
    }
}
