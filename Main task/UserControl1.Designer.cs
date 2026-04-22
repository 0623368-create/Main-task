namespace Main_task
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cointerface = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.coaddproducts = new System.Windows.Forms.Button();
            this.coeditproducts = new System.Windows.Forms.Button();
            this.cocheckout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cointerface.SuspendLayout();
            this.SuspendLayout();
            // 
            // cointerface
            // 
            this.cointerface.BackColor = System.Drawing.Color.HotPink;
            this.cointerface.Controls.Add(this.button4);
            this.cointerface.Controls.Add(this.cocheckout);
            this.cointerface.Controls.Add(this.coeditproducts);
            this.cointerface.Controls.Add(this.coaddproducts);
            this.cointerface.Location = new System.Drawing.Point(0, 0);
            this.cointerface.Name = "cointerface";
            this.cointerface.Size = new System.Drawing.Size(279, 429);
            this.cointerface.TabIndex = 0;
            this.cointerface.TabStop = false;
            this.cointerface.Text = "interface";
            this.cointerface.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // coaddproducts
            // 
            this.coaddproducts.Location = new System.Drawing.Point(0, 339);
            this.coaddproducts.Name = "coaddproducts";
            this.coaddproducts.Size = new System.Drawing.Size(86, 27);
            this.coaddproducts.TabIndex = 0;
            this.coaddproducts.Text = "add products";
            this.coaddproducts.UseVisualStyleBackColor = true;
            this.coaddproducts.Click += new System.EventHandler(this.coaddproducts_Click);
            // 
            // coeditproducts
            // 
            this.coeditproducts.Location = new System.Drawing.Point(105, 339);
            this.coeditproducts.Name = "coeditproducts";
            this.coeditproducts.Size = new System.Drawing.Size(84, 27);
            this.coeditproducts.TabIndex = 1;
            this.coeditproducts.Text = "edit products";
            this.coeditproducts.UseVisualStyleBackColor = true;
            this.coeditproducts.Click += new System.EventHandler(this.coeditproducts_Click);
            // 
            // cocheckout
            // 
            this.cocheckout.Location = new System.Drawing.Point(204, 339);
            this.cocheckout.Name = "cocheckout";
            this.cocheckout.Size = new System.Drawing.Size(75, 27);
            this.cocheckout.TabIndex = 2;
            this.cocheckout.Text = "checkout";
            this.cocheckout.UseVisualStyleBackColor = true;
            this.cocheckout.Click += new System.EventHandler(this.cocheckout_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cointerface);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(826, 558);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.cointerface.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cointerface;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button cocheckout;
        private System.Windows.Forms.Button coeditproducts;
        private System.Windows.Forms.Button coaddproducts;
    }
}
