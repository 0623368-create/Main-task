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
            this.components = new System.ComponentModel.Container();
            this.cointerface = new System.Windows.Forms.GroupBox();
            this.cobrandtb = new System.Windows.Forms.TextBox();
            this.coIDtb = new System.Windows.Forms.TextBox();
            this.conametb = new System.Windows.Forms.TextBox();
            this.coID = new System.Windows.Forms.Label();
            this.coname = new System.Windows.Forms.Label();
            this.coprice = new System.Windows.Forms.Label();
            this.copricetb = new System.Windows.Forms.TextBox();
            this.codeleteproductstb = new System.Windows.Forms.TextBox();
            this.codeleteproducts = new System.Windows.Forms.Button();
            this.cobrand = new System.Windows.Forms.Label();
            this.cocheckout = new System.Windows.Forms.Button();
            this.coeditproducts = new System.Windows.Forms.Button();
            this.coaddproducts = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cobrand0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coname0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coprice0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coID0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cointerface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cointerface
            // 
            this.cointerface.BackColor = System.Drawing.Color.HotPink;
            this.cointerface.Controls.Add(this.cobrandtb);
            this.cointerface.Controls.Add(this.coIDtb);
            this.cointerface.Controls.Add(this.conametb);
            this.cointerface.Controls.Add(this.coID);
            this.cointerface.Controls.Add(this.coname);
            this.cointerface.Controls.Add(this.coprice);
            this.cointerface.Controls.Add(this.copricetb);
            this.cointerface.Controls.Add(this.codeleteproductstb);
            this.cointerface.Controls.Add(this.codeleteproducts);
            this.cointerface.Controls.Add(this.cobrand);
            this.cointerface.Controls.Add(this.cocheckout);
            this.cointerface.Controls.Add(this.coeditproducts);
            this.cointerface.Controls.Add(this.coaddproducts);
            this.cointerface.Location = new System.Drawing.Point(3, 12);
            this.cointerface.Name = "cointerface";
            this.cointerface.Size = new System.Drawing.Size(279, 424);
            this.cointerface.TabIndex = 0;
            this.cointerface.TabStop = false;
            this.cointerface.Text = "interface";
            this.cointerface.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cobrandtb
            // 
            this.cobrandtb.Location = new System.Drawing.Point(65, 60);
            this.cobrandtb.Name = "cobrandtb";
            this.cobrandtb.Size = new System.Drawing.Size(100, 20);
            this.cobrandtb.TabIndex = 11;
            // 
            // coIDtb
            // 
            this.coIDtb.Location = new System.Drawing.Point(65, 96);
            this.coIDtb.Name = "coIDtb";
            this.coIDtb.Size = new System.Drawing.Size(100, 20);
            this.coIDtb.TabIndex = 10;
            // 
            // conametb
            // 
            this.conametb.Location = new System.Drawing.Point(65, 136);
            this.conametb.Name = "conametb";
            this.conametb.Size = new System.Drawing.Size(100, 20);
            this.conametb.TabIndex = 9;
            // 
            // coID
            // 
            this.coID.AutoSize = true;
            this.coID.Location = new System.Drawing.Point(6, 103);
            this.coID.Name = "coID";
            this.coID.Size = new System.Drawing.Size(18, 13);
            this.coID.TabIndex = 8;
            this.coID.Text = "ID";
            // 
            // coname
            // 
            this.coname.AutoSize = true;
            this.coname.Location = new System.Drawing.Point(6, 139);
            this.coname.Name = "coname";
            this.coname.Size = new System.Drawing.Size(33, 13);
            this.coname.TabIndex = 7;
            this.coname.Text = "name";
            // 
            // coprice
            // 
            this.coprice.AutoSize = true;
            this.coprice.Location = new System.Drawing.Point(6, 180);
            this.coprice.Name = "coprice";
            this.coprice.Size = new System.Drawing.Size(30, 13);
            this.coprice.TabIndex = 6;
            this.coprice.Text = "price";
            // 
            // copricetb
            // 
            this.copricetb.Location = new System.Drawing.Point(65, 180);
            this.copricetb.Name = "copricetb";
            this.copricetb.Size = new System.Drawing.Size(100, 20);
            this.copricetb.TabIndex = 5;
            // 
            // codeleteproductstb
            // 
            this.codeleteproductstb.Location = new System.Drawing.Point(132, 387);
            this.codeleteproductstb.Name = "codeleteproductstb";
            this.codeleteproductstb.Size = new System.Drawing.Size(100, 20);
            this.codeleteproductstb.TabIndex = 4;
            // 
            // codeleteproducts
            // 
            this.codeleteproducts.Location = new System.Drawing.Point(0, 383);
            this.codeleteproducts.Name = "codeleteproducts";
            this.codeleteproducts.Size = new System.Drawing.Size(108, 27);
            this.codeleteproducts.TabIndex = 3;
            this.codeleteproducts.Text = "delete products";
            this.codeleteproducts.UseVisualStyleBackColor = true;
            // 
            // cobrand
            // 
            this.cobrand.AutoSize = true;
            this.cobrand.Location = new System.Drawing.Point(6, 67);
            this.cobrand.Name = "cobrand";
            this.cobrand.Size = new System.Drawing.Size(34, 13);
            this.cobrand.TabIndex = 4;
            this.cobrand.Text = "brand";
            // 
            // cocheckout
            // 
            this.cocheckout.Location = new System.Drawing.Point(204, 339);
            this.cocheckout.Name = "cocheckout";
            this.cocheckout.Size = new System.Drawing.Size(75, 27);
            this.cocheckout.TabIndex = 2;
            this.cocheckout.Text = "checkout";
            this.cocheckout.UseVisualStyleBackColor = true;
            // 
            // coeditproducts
            // 
            this.coeditproducts.Location = new System.Drawing.Point(105, 339);
            this.coeditproducts.Name = "coeditproducts";
            this.coeditproducts.Size = new System.Drawing.Size(84, 27);
            this.coeditproducts.TabIndex = 1;
            this.coeditproducts.Text = "edit products";
            this.coeditproducts.UseVisualStyleBackColor = true;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cobrand0,
            this.coname0,
            this.coprice0,
            this.coID0});
            this.dataGridView1.Location = new System.Drawing.Point(308, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 424);
            this.dataGridView1.TabIndex = 3;
            // 
            // cobrand0
            // 
            this.cobrand0.HeaderText = "Brand";
            this.cobrand0.Name = "cobrand0";
            this.cobrand0.ReadOnly = true;
            // 
            // coname0
            // 
            this.coname0.HeaderText = "Name";
            this.coname0.Name = "coname0";
            this.coname0.ReadOnly = true;
            // 
            // coprice0
            // 
            this.coprice0.HeaderText = "Price";
            this.coprice0.Name = "coprice0";
            this.coprice0.ReadOnly = true;
            // 
            // coID0
            // 
            this.coID0.HeaderText = "ID";
            this.coID0.Name = "coID0";
            this.coID0.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(746, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(8, 3);
            this.dataGridView2.TabIndex = 4;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cointerface);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(826, 558);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.cointerface.ResumeLayout(false);
            this.cointerface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cointerface;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button codeleteproducts;
        private System.Windows.Forms.Button cocheckout;
        private System.Windows.Forms.Button coeditproducts;
        private System.Windows.Forms.Button coaddproducts;
        private System.Windows.Forms.TextBox copricetb;
        private System.Windows.Forms.TextBox codeleteproductstb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Label cobrand;
        private System.Windows.Forms.Label coID;
        private System.Windows.Forms.Label coname;
        private System.Windows.Forms.Label coprice;
        private System.Windows.Forms.TextBox cobrandtb;
        private System.Windows.Forms.TextBox coIDtb;
        private System.Windows.Forms.TextBox conametb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobrand0;
        private System.Windows.Forms.DataGridViewTextBoxColumn coname0;
        private System.Windows.Forms.DataGridViewTextBoxColumn coprice0;
        private System.Windows.Forms.DataGridViewTextBoxColumn coID0;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
