namespace Main_task
{
    partial class items
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cobrand1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coprice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coquantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cobrand1,
            this.coname1,
            this.coprice1,
            this.coID1,
            this.coquantity1});
            this.dataGridView1.Location = new System.Drawing.Point(150, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // cobrand1
            // 
            this.cobrand1.HeaderText = "Brand";
            this.cobrand1.Name = "cobrand1";
            // 
            // coname1
            // 
            this.coname1.HeaderText = "Name";
            this.coname1.Name = "coname1";
            // 
            // coprice1
            // 
            this.coprice1.HeaderText = "Price";
            this.coprice1.Name = "coprice1";
            // 
            // coID1
            // 
            this.coID1.HeaderText = "ID";
            this.coID1.Name = "coID1";
            // 
            // coquantity1
            // 
            this.coquantity1.HeaderText = "Quantity";
            this.coquantity1.Name = "coquantity1";
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "items";
            this.Size = new System.Drawing.Size(778, 525);
            this.Load += new System.EventHandler(this.items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobrand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coprice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coquantity1;
    }
}
