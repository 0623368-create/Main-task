namespace Main_task
{
    partial class menuUS
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.codonutdisturblab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // codonutdisturblab
            // 
            this.codonutdisturblab.AutoSize = true;
            this.codonutdisturblab.Font = new System.Drawing.Font("MV Boli", 51F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codonutdisturblab.ForeColor = System.Drawing.Color.HotPink;
            this.codonutdisturblab.Location = new System.Drawing.Point(88, 45);
            this.codonutdisturblab.Name = "codonutdisturblab";
            this.codonutdisturblab.Size = new System.Drawing.Size(504, 90);
            this.codonutdisturblab.TabIndex = 1;
            this.codonutdisturblab.Text = "Donut Disturb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(135, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "High quality donuts for you and your friends!";
            // 
            // menuUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codonutdisturblab);
            this.Name = "menuUS";
            this.Size = new System.Drawing.Size(689, 543);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label codonutdisturblab;
        private System.Windows.Forms.Label label2;
    }
}
