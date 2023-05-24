
namespace Shop_management_system.Forms
{
    partial class billpayfoam
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.grv_view = new System.Windows.Forms.DataGridView();
            this.lnlname = new System.Windows.Forms.Label();
            this.txtbuy = new System.Windows.Forms.TextBox();
            this.lblquant = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 121);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grv_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 615);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnenter);
            this.panel3.Controls.Add(this.lblquant);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lnlname);
            this.panel3.Controls.Add(this.txtbuy);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.lblprice);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(474, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 615);
            this.panel3.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(655, 459);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(180, 80);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(46, 331);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(264, 29);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "your total price to pay is";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(45, 437);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(309, 49);
            this.txtprice.TabIndex = 3;
            // 
            // grv_view
            // 
            this.grv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_view.Location = new System.Drawing.Point(0, 0);
            this.grv_view.Name = "grv_view";
            this.grv_view.RowHeadersWidth = 51;
            this.grv_view.RowTemplate.Height = 24;
            this.grv_view.Size = new System.Drawing.Size(474, 615);
            this.grv_view.TabIndex = 0;
            this.grv_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lnlname
            // 
            this.lnlname.AutoSize = true;
            this.lnlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlname.Location = new System.Drawing.Point(60, 26);
            this.lnlname.Name = "lnlname";
            this.lnlname.Size = new System.Drawing.Size(306, 25);
            this.lnlname.TabIndex = 5;
            this.lnlname.Text = "Enter the product you want to buy ";
            // 
            // txtbuy
            // 
            this.txtbuy.Location = new System.Drawing.Point(63, 96);
            this.txtbuy.Multiline = true;
            this.txtbuy.Name = "txtbuy";
            this.txtbuy.Size = new System.Drawing.Size(243, 39);
            this.txtbuy.TabIndex = 4;
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(48, 168);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(260, 25);
            this.lblquant.TabIndex = 7;
            this.lblquant.Text = "ENter the quantity of the item";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 238);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 39);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shop_management_system.Properties.Resources.bat;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 615);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnenter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnenter.Location = new System.Drawing.Point(396, 353);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(137, 73);
            this.btnenter.TabIndex = 8;
            this.btnenter.Text = "ENTER";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // billpayfoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 736);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "billpayfoam";
            this.Text = "billpayfoam";
            this.Load += new System.EventHandler(this.billpayfoam_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.DataGridView grv_view;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lnlname;
        private System.Windows.Forms.TextBox txtbuy;
        private System.Windows.Forms.Button btnenter;
    }
}