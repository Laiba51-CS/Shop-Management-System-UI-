
namespace Shop_management_system.Forms
{
    partial class custfoam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblheader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreview = new System.Windows.Forms.Button();
            this.btnbill = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhead = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 143);
            this.panel1.TabIndex = 0;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(288, 51);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(623, 35);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "SPORTS SHOP MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnreview);
            this.panel2.Controls.Add(this.btnbill);
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.btnproduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 576);
            this.panel2.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Lavender;
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(0, 396);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(263, 92);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreview
            // 
            this.btnreview.BackColor = System.Drawing.Color.Lavender;
            this.btnreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreview.Location = new System.Drawing.Point(0, 297);
            this.btnreview.Name = "btnreview";
            this.btnreview.Size = new System.Drawing.Size(263, 99);
            this.btnreview.TabIndex = 3;
            this.btnreview.Text = "Add Review";
            this.btnreview.UseVisualStyleBackColor = false;
            this.btnreview.Click += new System.EventHandler(this.btnreview_Click);
            // 
            // btnbill
            // 
            this.btnbill.BackColor = System.Drawing.Color.Lavender;
            this.btnbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.Location = new System.Drawing.Point(0, 198);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(263, 99);
            this.btnbill.TabIndex = 2;
            this.btnbill.Text = "Bill Payment";
            this.btnbill.UseVisualStyleBackColor = false;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Lavender;
            this.btnorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(0, 99);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(263, 99);
            this.btnorder.TabIndex = 1;
            this.btnorder.Text = "Place Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.Lavender;
            this.btnproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.Location = new System.Drawing.Point(0, 0);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(263, 99);
            this.btnproduct.TabIndex = 0;
            this.btnproduct.Text = "Buy Product";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblhead);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(263, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 576);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shop_management_system.Properties.Resources.theme;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 576);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(65, 32);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(428, 39);
            this.lblhead.TabIndex = 1;
            this.lblhead.Text = "<<<CUSTOMER MODULE";
            // 
            // custfoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 719);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "custfoam";
            this.Text = "custfoam";
            this.Load += new System.EventHandler(this.custfoam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreview;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Label lblhead;
    }
}