
namespace Shop_management_system.Forms
{
    partial class profitform
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblprofit = new System.Windows.Forms.Label();
            this.grv_profit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_profit)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 125);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.profit);
            this.panel3.Controls.Add(this.lblprofit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(557, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 640);
            this.panel3.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Location = new System.Drawing.Point(432, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(160, 62);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblprofit
            // 
            this.lblprofit.AutoSize = true;
            this.lblprofit.Location = new System.Drawing.Point(185, 134);
            this.lblprofit.Name = "lblprofit";
            this.lblprofit.Size = new System.Drawing.Size(16, 17);
            this.lblprofit.TabIndex = 0;
            this.lblprofit.Text = "0\r\n";
            this.lblprofit.Click += new System.EventHandler(this.lblprofit_Click);
            // 
            // grv_profit
            // 
            this.grv_profit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_profit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_profit.Location = new System.Drawing.Point(0, 125);
            this.grv_profit.Name = "grv_profit";
            this.grv_profit.RowHeadersWidth = 51;
            this.grv_profit.RowTemplate.Height = 24;
            this.grv_profit.Size = new System.Drawing.Size(557, 640);
            this.grv_profit.TabIndex = 3;
            this.grv_profit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_profit_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPORTS SHOP MANAGEMENT SYSTEM";
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.profit.Location = new System.Drawing.Point(131, 62);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(108, 29);
            this.profit.TabIndex = 2;
            this.profit.Text = "PROFIT:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(3, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 60);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.btnback);
            this.panel4.Location = new System.Drawing.Point(6, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 60);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(6, 482);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(632, 60);
            this.panel5.TabIndex = 4;
            // 
            // profitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 765);
            this.Controls.Add(this.grv_profit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "profitform";
            this.Text = "profitform";
            this.Load += new System.EventHandler(this.profitform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_profit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grv_profit;
        private System.Windows.Forms.Label lblprofit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}