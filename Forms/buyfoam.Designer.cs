
namespace Shop_management_system.Forms
{
    partial class buyfoam
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.grv_view = new System.Windows.Forms.DataGridView();
            this.txtbuy = new System.Windows.Forms.TextBox();
            this.lnlname = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.quant = new System.Windows.Forms.NumericUpDown();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 139);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grv_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 564);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.quant);
            this.panel3.Controls.Add(this.lblquant);
            this.panel3.Controls.Add(this.lnlname);
            this.panel3.Controls.Add(this.txtbuy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1384, 701);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 703);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1384, 137);
            this.panel4.TabIndex = 3;
            // 
            // grv_view
            // 
            this.grv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_view.Location = new System.Drawing.Point(0, 0);
            this.grv_view.Name = "grv_view";
            this.grv_view.RowHeadersWidth = 51;
            this.grv_view.RowTemplate.Height = 24;
            this.grv_view.Size = new System.Drawing.Size(732, 564);
            this.grv_view.TabIndex = 0;
            this.grv_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_view_CellContentClick);
            // 
            // txtbuy
            // 
            this.txtbuy.Location = new System.Drawing.Point(899, 136);
            this.txtbuy.Multiline = true;
            this.txtbuy.Name = "txtbuy";
            this.txtbuy.Size = new System.Drawing.Size(243, 39);
            this.txtbuy.TabIndex = 0;
            this.txtbuy.TextChanged += new System.EventHandler(this.txtbuy_TextChanged);
            // 
            // lnlname
            // 
            this.lnlname.AutoSize = true;
            this.lnlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlname.Location = new System.Drawing.Point(896, 66);
            this.lnlname.Name = "lnlname";
            this.lnlname.Size = new System.Drawing.Size(306, 25);
            this.lnlname.TabIndex = 1;
            this.lnlname.Text = "Enter the product you want to buy ";
            this.lnlname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(896, 216);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(233, 25);
            this.lblquant.TabIndex = 2;
            this.lblquant.Text = "Enter the product quantity\r\n";
            // 
            // quant
            // 
            this.quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quant.Location = new System.Drawing.Point(901, 272);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(241, 30);
            this.quant.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1165, 474);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(144, 60);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(795, 469);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(144, 70);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Location = new System.Drawing.Point(502, 80);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(46, 17);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "label1";
            // 
            // buyfoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 840);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "buyfoam";
            this.Text = "buyfoam";
            this.Load += new System.EventHandler(this.buyfoam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grv_view;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lnlname;
        private System.Windows.Forms.TextBox txtbuy;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.NumericUpDown quant;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblheader;
    }
}