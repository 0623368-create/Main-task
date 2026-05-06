namespace Main_task
{
    partial class aboutususercontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutususercontrol));
            this.coaboutustitle = new System.Windows.Forms.Label();
            this.coaboutusyap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coaboutustitle
            // 
            this.coaboutustitle.AutoSize = true;
            this.coaboutustitle.Font = new System.Drawing.Font("Microsoft Uighur", 45.25F);
            this.coaboutustitle.ForeColor = System.Drawing.Color.HotPink;
            this.coaboutustitle.Location = new System.Drawing.Point(305, 58);
            this.coaboutustitle.Name = "coaboutustitle";
            this.coaboutustitle.Size = new System.Drawing.Size(188, 80);
            this.coaboutustitle.TabIndex = 0;
            this.coaboutustitle.Text = "About us";
            // 
            // coaboutusyap
            // 
            this.coaboutusyap.AutoSize = true;
            this.coaboutusyap.Font = new System.Drawing.Font("Microsoft Uighur", 18.75F);
            this.coaboutusyap.ForeColor = System.Drawing.Color.HotPink;
            this.coaboutusyap.Location = new System.Drawing.Point(3, 149);
            this.coaboutusyap.Name = "coaboutusyap";
            this.coaboutusyap.Size = new System.Drawing.Size(794, 132);
            this.coaboutusyap.TabIndex = 1;
            this.coaboutusyap.Text = resources.GetString("coaboutusyap.Text");
            // 
            // aboutususercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.coaboutusyap);
            this.Controls.Add(this.coaboutustitle);
            this.Name = "aboutususercontrol";
            this.Size = new System.Drawing.Size(787, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coaboutustitle;
        private System.Windows.Forms.Label coaboutusyap;
    }
}
