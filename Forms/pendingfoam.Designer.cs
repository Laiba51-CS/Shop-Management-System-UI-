
namespace Shop_management_system.Forms
{
    partial class pendingfoam
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
            this.grv_pending = new System.Windows.Forms.DataGridView();
            this.COMPLETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_pending)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 62);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grv_pending);
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 529);
            this.panel3.TabIndex = 2;
            // 
            // grv_pending
            // 
            this.grv_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_pending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COMPLETE});
            this.grv_pending.Dock = System.Windows.Forms.DockStyle.Left;
            this.grv_pending.Location = new System.Drawing.Point(0, 0);
            this.grv_pending.Name = "grv_pending";
            this.grv_pending.RowHeadersWidth = 51;
            this.grv_pending.RowTemplate.Height = 24;
            this.grv_pending.Size = new System.Drawing.Size(733, 529);
            this.grv_pending.TabIndex = 0;
            this.grv_pending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_pending_CellContentClick);
            // 
            // COMPLETE
            // 
            this.COMPLETE.HeaderText = "COMPLETE";
            this.COMPLETE.MinimumWidth = 6;
            this.COMPLETE.Name = "COMPLETE";
            this.COMPLETE.Text = "COMPLETE";
            this.COMPLETE.UseColumnTextForButtonValue = true;
            this.COMPLETE.Width = 125;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(954, 680);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(171, 62);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pendingfoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 771);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pendingfoam";
            this.Text = "pendingfoam";
            this.Load += new System.EventHandler(this.pendingfoam_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_pending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grv_pending;
        private System.Windows.Forms.DataGridViewButtonColumn COMPLETE;
        private System.Windows.Forms.Button btnback;
    }
}