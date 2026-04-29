namespace Main_task
{
    partial class Form1
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
            this.comenu = new System.Windows.Forms.Button();
            this.coaboutus = new System.Windows.Forms.Button();
            this.cocheckout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.comenu);
            this.panel1.Controls.Add(this.coaboutus);
            this.panel1.Controls.Add(this.cocheckout);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 452);
            this.panel1.TabIndex = 0;
            // 
            // comenu
            // 
            this.comenu.Location = new System.Drawing.Point(38, 51);
            this.comenu.Name = "comenu";
            this.comenu.Size = new System.Drawing.Size(75, 23);
            this.comenu.TabIndex = 0;
            this.comenu.Text = "menu";
            this.comenu.UseVisualStyleBackColor = true;
            this.comenu.Click += new System.EventHandler(this.comenu_Click);
            // 
            // coaboutus
            // 
            this.coaboutus.Location = new System.Drawing.Point(38, 110);
            this.coaboutus.Name = "coaboutus";
            this.coaboutus.Size = new System.Drawing.Size(75, 23);
            this.coaboutus.TabIndex = 1;
            this.coaboutus.Text = "about us";
            this.coaboutus.UseVisualStyleBackColor = true;
            // 
            // cocheckout
            // 
            this.cocheckout.Location = new System.Drawing.Point(38, 178);
            this.cocheckout.Name = "cocheckout";
            this.cocheckout.Size = new System.Drawing.Size(75, 23);
            this.cocheckout.TabIndex = 2;
            this.cocheckout.Text = "checkout";
            this.cocheckout.UseVisualStyleBackColor = true;
            this.cocheckout.Click += new System.EventHandler(this.cocheckout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(166, -1);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(883, 452);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1047, 449);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button comenu;
        private System.Windows.Forms.Button coaboutus;
        private System.Windows.Forms.Button cocheckout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlContent;
    }
}

