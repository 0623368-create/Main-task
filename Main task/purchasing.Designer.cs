namespace Main_task
{
    partial class purchasing
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
            this.cogobackmenubtn = new System.Windows.Forms.Button();
            this.cothanksbye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cogobackmenubtn
            // 
            this.cogobackmenubtn.Location = new System.Drawing.Point(347, 259);
            this.cogobackmenubtn.Name = "cogobackmenubtn";
            this.cogobackmenubtn.Size = new System.Drawing.Size(75, 23);
            this.cogobackmenubtn.TabIndex = 3;
            this.cogobackmenubtn.Text = "Go back";
            this.cogobackmenubtn.UseVisualStyleBackColor = true;
            this.cogobackmenubtn.Click += new System.EventHandler(this.cogobackmenubtn_Click);
            // 
            // cothanksbye
            // 
            this.cothanksbye.AutoSize = true;
            this.cothanksbye.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.cothanksbye.ForeColor = System.Drawing.Color.HotPink;
            this.cothanksbye.Location = new System.Drawing.Point(101, 168);
            this.cothanksbye.Name = "cothanksbye";
            this.cothanksbye.Size = new System.Drawing.Size(598, 47);
            this.cothanksbye.TabIndex = 2;
            this.cothanksbye.Text = "Your order has been completed\r\n";
            // 
            // purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cogobackmenubtn);
            this.Controls.Add(this.cothanksbye);
            this.Name = "purchasing";
            this.Text = "purchasing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cogobackmenubtn;
        private System.Windows.Forms.Label cothanksbye;
    }
}