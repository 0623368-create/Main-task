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
            this.coitemsbtn = new System.Windows.Forms.Button();
            this.comenu = new System.Windows.Forms.Button();
            this.coaboutus = new System.Windows.Forms.Button();
            this.cocheckout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.aboutus1 = new Main_task.aboutus();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.coitemsbtn);
            this.panel1.Controls.Add(this.comenu);
            this.panel1.Controls.Add(this.coaboutus);
            this.panel1.Controls.Add(this.cocheckout);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 452);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // coitemsbtn
            // 
            this.coitemsbtn.Location = new System.Drawing.Point(38, 165);
            this.coitemsbtn.Name = "coitemsbtn";
            this.coitemsbtn.Size = new System.Drawing.Size(75, 23);
            this.coitemsbtn.TabIndex = 3;
            this.coitemsbtn.Text = "items";
            this.coitemsbtn.UseVisualStyleBackColor = true;
            this.coitemsbtn.Click += new System.EventHandler(this.coitemsbtn_Click_1);
            // 
            // comenu
            // 
            this.comenu.Location = new System.Drawing.Point(38, 51);
            this.comenu.Name = "comenu";
            this.comenu.Size = new System.Drawing.Size(75, 23);
            this.comenu.TabIndex = 0;
            this.comenu.Text = "home";
            this.comenu.UseVisualStyleBackColor = true;
            this.comenu.Click += new System.EventHandler(this.comenu_Click);
            // 
            // coaboutus
            // 
            this.coaboutus.Location = new System.Drawing.Point(38, 106);
            this.coaboutus.Name = "coaboutus";
            this.coaboutus.Size = new System.Drawing.Size(75, 23);
            this.coaboutus.TabIndex = 1;
            this.coaboutus.Text = "about us";
            this.coaboutus.UseVisualStyleBackColor = true;
            this.coaboutus.Click += new System.EventHandler(this.coaboutus_Click);
            // 
            // cocheckout
            // 
            this.cocheckout.Location = new System.Drawing.Point(38, 223);
            this.cocheckout.Name = "cocheckout";
            this.cocheckout.Size = new System.Drawing.Size(75, 23);
            this.cocheckout.TabIndex = 2;
            this.cocheckout.Text = "checkout";
            this.cocheckout.UseVisualStyleBackColor = true;
            this.cocheckout.Click += new System.EventHandler(this.cocheckout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.aboutus1);
            this.pnlContent.Location = new System.Drawing.Point(166, -1);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(883, 452);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // aboutus1
            // 
            this.aboutus1.Location = new System.Drawing.Point(0, -26);
            this.aboutus1.Name = "aboutus1";
            this.aboutus1.Size = new System.Drawing.Size(858, 612);
            this.aboutus1.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(38, 286);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button comenu;
        private System.Windows.Forms.Button coaboutus;
        private System.Windows.Forms.Button cocheckout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlContent;
        private aboutus aboutus1;
        private System.Windows.Forms.Button coitemsbtn;
        private System.Windows.Forms.Button btnPay;
    }
}

