namespace Main_task
{
    partial class checkout
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
            this.cocardnumber = new System.Windows.Forms.Label();
            this.cocardnumbertxt = new System.Windows.Forms.TextBox();
            this.cogobackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cocardnumber
            // 
            this.cocardnumber.AutoSize = true;
            this.cocardnumber.Location = new System.Drawing.Point(300, 129);
            this.cocardnumber.Name = "cocardnumber";
            this.cocardnumber.Size = new System.Drawing.Size(142, 13);
            this.cocardnumber.TabIndex = 0;
            this.cocardnumber.Text = "Card number and expiry date";
            // 
            // cocardnumbertxt
            // 
            this.cocardnumbertxt.Location = new System.Drawing.Point(321, 163);
            this.cocardnumbertxt.Name = "cocardnumbertxt";
            this.cocardnumbertxt.Size = new System.Drawing.Size(100, 20);
            this.cocardnumbertxt.TabIndex = 1;
            // 
            // cogobackbtn
            // 
            this.cogobackbtn.Location = new System.Drawing.Point(50, 379);
            this.cogobackbtn.Name = "cogobackbtn";
            this.cogobackbtn.Size = new System.Drawing.Size(75, 23);
            this.cogobackbtn.TabIndex = 2;
            this.cogobackbtn.Text = "go back";
            this.cogobackbtn.UseVisualStyleBackColor = true;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cogobackbtn);
            this.Controls.Add(this.cocardnumbertxt);
            this.Controls.Add(this.cocardnumber);
            this.Name = "checkout";
            this.Text = "checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cocardnumber;
        private System.Windows.Forms.TextBox cocardnumbertxt;
        private System.Windows.Forms.Button cogobackbtn;
    }
}