
namespace Shop_management_system.Forms
{
    partial class placeorder
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.quant = new System.Windows.Forms.NumericUpDown();
            this.lblquant = new System.Windows.Forms.Label();
            this.lnlname = new System.Windows.Forms.Label();
            this.txtbuy = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grv_view = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quant)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 121);
            this.panel1.TabIndex = 0;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(408, 46);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(471, 29);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "SPORTS SHOP MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.lblprice);
            this.panel2.Controls.Add(this.quant);
            this.panel2.Controls.Add(this.lblquant);
            this.panel2.Controls.Add(this.lnlname);
            this.panel2.Controls.Add(this.txtbuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(613, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 610);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(23, 472);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(144, 70);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(393, 477);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(144, 60);
            this.btnorder.TabIndex = 14;
            this.btnorder.Text = "PLace order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(25, 335);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(219, 48);
            this.txtprice.TabIndex = 13;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(33, 272);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(190, 25);
            this.lblprice.TabIndex = 12;
            this.lblprice.Text = "your payable price is";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // quant
            // 
            this.quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quant.Location = new System.Drawing.Point(25, 195);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(241, 30);
            this.quant.TabIndex = 11;
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(33, 140);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(233, 25);
            this.lblquant.TabIndex = 10;
            this.lblquant.Text = "Enter the product quantity\r\n";
            // 
            // lnlname
            // 
            this.lnlname.AutoSize = true;
            this.lnlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlname.Location = new System.Drawing.Point(18, 21);
            this.lnlname.Name = "lnlname";
            this.lnlname.Size = new System.Drawing.Size(306, 25);
            this.lnlname.TabIndex = 9;
            this.lnlname.Text = "Enter the product you want to buy ";
            // 
            // txtbuy
            // 
            this.txtbuy.Location = new System.Drawing.Point(23, 63);
            this.txtbuy.Multiline = true;
            this.txtbuy.Name = "txtbuy";
            this.txtbuy.Size = new System.Drawing.Size(243, 39);
            this.txtbuy.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grv_view);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 610);
            this.panel3.TabIndex = 2;
            // 
            // grv_view
            // 
            this.grv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_view.Location = new System.Drawing.Point(0, 0);
            this.grv_view.Name = "grv_view";
            this.grv_view.RowHeadersWidth = 51;
            this.grv_view.RowTemplate.Height = 24;
            this.grv_view.Size = new System.Drawing.Size(615, 610);
            this.grv_view.TabIndex = 0;
            // 
            // placeorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 731);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "placeorder";
            this.Text = "placeorder";
            this.Load += new System.EventHandler(this.placeorder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quant)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.NumericUpDown quant;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Label lnlname;
        private System.Windows.Forms.TextBox txtbuy;
        private System.Windows.Forms.DataGridView grv_view;
    }
}