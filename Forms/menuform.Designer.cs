
namespace Shop_management_system.Forms
{
    partial class menuform
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreviews = new System.Windows.Forms.Button();
            this.btnsorted = new System.Windows.Forms.Button();
            this.btnprofit = new System.Windows.Forms.Button();
            this.btnstock = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltext = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 202);
            this.panel1.TabIndex = 0;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblheader.Location = new System.Drawing.Point(3, 137);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(841, 51);
            this.lblheader.TabIndex = 1;
            this.lblheader.Text = "SPORTS SHOP MANAGEMENT SYSTEM";
            this.lblheader.Click += new System.EventHandler(this.lblheader_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 62);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.instruction);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnreviews);
            this.panel2.Controls.Add(this.btnsorted);
            this.panel2.Controls.Add(this.btnprofit);
            this.panel2.Controls.Add(this.btnstock);
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 746);
            this.panel2.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(0, 581);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(280, 74);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreviews
            // 
            this.btnreviews.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnreviews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreviews.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreviews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreviews.Location = new System.Drawing.Point(0, 516);
            this.btnreviews.Name = "btnreviews";
            this.btnreviews.Size = new System.Drawing.Size(280, 65);
            this.btnreviews.TabIndex = 17;
            this.btnreviews.Text = "Reviews";
            this.btnreviews.UseVisualStyleBackColor = false;
            this.btnreviews.Click += new System.EventHandler(this.btnreviews_Click);
            // 
            // btnsorted
            // 
            this.btnsorted.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnsorted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsorted.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsorted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsorted.Location = new System.Drawing.Point(0, 438);
            this.btnsorted.Name = "btnsorted";
            this.btnsorted.Size = new System.Drawing.Size(280, 78);
            this.btnsorted.TabIndex = 16;
            this.btnsorted.Text = "Sorted prices";
            this.btnsorted.UseVisualStyleBackColor = false;
            this.btnsorted.Click += new System.EventHandler(this.btnsorted_Click);
            // 
            // btnprofit
            // 
            this.btnprofit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnprofit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnprofit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprofit.Location = new System.Drawing.Point(0, 357);
            this.btnprofit.Name = "btnprofit";
            this.btnprofit.Size = new System.Drawing.Size(280, 81);
            this.btnprofit.TabIndex = 14;
            this.btnprofit.Text = "Profit and loss";
            this.btnprofit.UseVisualStyleBackColor = false;
            this.btnprofit.Click += new System.EventHandler(this.btnprofit_Click);
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstock.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstock.Location = new System.Drawing.Point(0, 276);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(280, 81);
            this.btnstock.TabIndex = 13;
            this.btnstock.Text = "Manage stock";
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnorder.Location = new System.Drawing.Point(0, 202);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(280, 74);
            this.btnorder.TabIndex = 9;
            this.btnorder.Text = "Manage orders";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnedit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(0, 140);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(280, 62);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnview.Location = new System.Drawing.Point(0, 69);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(280, 71);
            this.btnview.TabIndex = 7;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(0, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(280, 69);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbltext);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 544);
            this.panel3.TabIndex = 2;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.Location = new System.Drawing.Point(17, 27);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(499, 29);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "<<<<<Select your option from the given menu";
            // 
            // instruction
            // 
            this.instruction.BackColor = System.Drawing.SystemColors.HotTrack;
            this.instruction.Dock = System.Windows.Forms.DockStyle.Left;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instruction.Location = new System.Drawing.Point(0, 655);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(280, 91);
            this.instruction.TabIndex = 19;
            this.instruction.Text = "Instruction manual";
            this.instruction.UseVisualStyleBackColor = false;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shop_management_system.Properties.Resources.ball;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 746);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "menuform";
            this.Text = "form3";
            this.Load += new System.EventHandler(this.menuform_Load);
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
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreviews;
        private System.Windows.Forms.Button btnsorted;
        private System.Windows.Forms.Button btnprofit;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button instruction;
    }
}