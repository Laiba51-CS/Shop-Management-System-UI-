
namespace Shop_management_system.Forms
{
    partial class signinform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblheader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblrole = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.password.Location = new System.Drawing.Point(354, 282);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(261, 51);
            this.password.TabIndex = 42;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(146, 195);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(187, 29);
            this.lblname.TabIndex = 44;
            this.lblname.Text = "Enter Username";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(150, 282);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(183, 29);
            this.lblpass.TabIndex = 43;
            this.lblpass.Text = "Enter Password";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.user.Location = new System.Drawing.Point(354, 195);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(261, 49);
            this.user.TabIndex = 40;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 123);
            this.panel1.TabIndex = 45;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(318, 47);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(139, 38);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "Sign in ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblrole);
            this.panel2.Controls.Add(this.Login);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.lblpass);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 733);
            this.panel2.TabIndex = 46;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.Location = new System.Drawing.Point(153, 380);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(149, 32);
            this.lblrole.TabIndex = 49;
            this.lblrole.Text = "Enter Role";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ControlText;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(477, 540);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(217, 74);
            this.Login.TabIndex = 47;
            this.Login.Text = "Save";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.role.Location = new System.Drawing.Point(354, 369);
            this.role.Multiline = true;
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(261, 56);
            this.role.TabIndex = 48;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlText;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(135, 540);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(217, 74);
            this.back.TabIndex = 47;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shop_management_system.Properties.Resources.sports;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 733);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.panel2);
            this.Name = "signinform";
            this.Text = "form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox role;
    }
}