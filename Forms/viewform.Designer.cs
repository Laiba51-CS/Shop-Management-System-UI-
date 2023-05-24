
namespace Shop_management_system.Forms
{
    partial class viewform
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.grv_view = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 140);
            this.panel1.TabIndex = 0;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblheader.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(188, 39);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(830, 46);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "SPORTS SHOP MANAGEMENT SYSYEM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 577);
            this.panel2.TabIndex = 1;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(48, 459);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(146, 70);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(998, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 577);
            this.panel3.TabIndex = 2;
            // 
            // grv_view
            // 
            this.grv_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_view.Location = new System.Drawing.Point(200, 140);
            this.grv_view.Name = "grv_view";
            this.grv_view.RowHeadersWidth = 51;
            this.grv_view.RowTemplate.Height = 24;
            this.grv_view.Size = new System.Drawing.Size(798, 577);
            this.grv_view.TabIndex = 3;
            this.grv_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_view_CellContentClick);
            // 
            // viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 717);
            this.Controls.Add(this.grv_view);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "viewform";
            this.Text = "viewform";
            this.Load += new System.EventHandler(this.viewform_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grv_view;
        private System.Windows.Forms.Button btnback;
    }
}