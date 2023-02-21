
namespace Shop_management_system
{
    partial class loginform
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
            this.linklbl1 = new System.Windows.Forms.LinkLabel();
            this.user = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.forget = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblheader2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklbl1
            // 
            this.linklbl1.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.linklbl1.AutoSize = true;
            this.linklbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl1.LinkColor = System.Drawing.Color.Navy;
            this.linklbl1.Location = new System.Drawing.Point(507, 267);
            this.linklbl1.Name = "linklbl1";
            this.linklbl1.Size = new System.Drawing.Size(0, 20);
            this.linklbl1.TabIndex = 33;
            this.linklbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.user.Location = new System.Drawing.Point(347, 26);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(261, 49);
            this.user.TabIndex = 29;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(142, 113);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(183, 29);
            this.lblpass.TabIndex = 38;
            this.lblpass.Text = "Enter Password";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ControlText;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(347, 290);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(217, 74);
            this.Login.TabIndex = 31;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(138, 26);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(187, 29);
            this.lblname.TabIndex = 39;
            this.lblname.Text = "Enter Username";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password.Location = new System.Drawing.Point(347, 113);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(261, 51);
            this.password.TabIndex = 37;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // forget
            // 
            this.forget.ActiveLinkColor = System.Drawing.Color.DarkOrchid;
            this.forget.AutoSize = true;
            this.forget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget.Location = new System.Drawing.Point(598, 188);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(153, 24);
            this.forget.TabIndex = 40;
            this.forget.TabStop = true;
            this.forget.Text = "forgot password?";
            this.forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forget);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 531);
            this.panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shop_management_system.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 531);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblheader2
            // 
            this.lblheader2.AutoSize = true;
            this.lblheader2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblheader2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblheader2.Location = new System.Drawing.Point(272, 21);
            this.lblheader2.Name = "lblheader2";
            this.lblheader2.Size = new System.Drawing.Size(336, 28);
            this.lblheader2.TabIndex = 42;
            this.lblheader2.Text = "login to continue the system";
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 608);
            this.Controls.Add(this.lblheader2);
            this.Controls.Add(this.linklbl1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(870, 655);
            this.MinimumSize = new System.Drawing.Size(870, 655);
            this.Name = "loginform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklbl1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel forget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblheader2;
    }
}

