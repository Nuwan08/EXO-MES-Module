namespace EXO_MES_Module
{
    partial class Administration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Navigetor = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.InsertData = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Refresh1 = new System.Windows.Forms.ToolStripButton();
            this.NewIndex = new System.Windows.Forms.ToolStripButton();
            this.DeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.GridView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODSTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESDataSet = new EXO_MES_Module.MESDataSet();
            this.pROD_STAFFTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_STAFFTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SysAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salesModuleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodCapacitiyPlanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobCostingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobCostSalesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobCostGPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobCostCostDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODSTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Silver;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Navigetor,
            this.Search,
            this.InsertData,
            this.Save,
            this.Refresh1,
            this.NewIndex,
            this.DeleteRecord,
            this.GridView,
            this.toolStripSeparator16});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "Main Menu";
            this.toolStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // Navigetor
            // 
            this.Navigetor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Navigetor.Image = ((System.Drawing.Image)(resources.GetObject("Navigetor.Image")));
            this.Navigetor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Navigetor.Name = "Navigetor";
            this.Navigetor.Size = new System.Drawing.Size(23, 22);
            this.Navigetor.Text = "Navigetor";
            this.Navigetor.ToolTipText = "Navigetor";
            // 
            // Search
            // 
            this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search.Enabled = false;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(23, 22);
            this.Search.Text = "Search";
            this.Search.ToolTipText = "Search";
            // 
            // InsertData
            // 
            this.InsertData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertData.Enabled = false;
            this.InsertData.Image = ((System.Drawing.Image)(resources.GetObject("InsertData.Image")));
            this.InsertData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(23, 22);
            this.InsertData.Text = "Add New Raw";
            this.InsertData.ToolTipText = "Add New Raw";
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Save";
            this.Save.ToolTipText = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Refresh1
            // 
            this.Refresh1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refresh1.Image = ((System.Drawing.Image)(resources.GetObject("Refresh1.Image")));
            this.Refresh1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh1.Name = "Refresh1";
            this.Refresh1.Size = new System.Drawing.Size(23, 22);
            this.Refresh1.Text = "Refresh";
            this.Refresh1.Click += new System.EventHandler(this.Refresh1_Click_1);
            // 
            // NewIndex
            // 
            this.NewIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewIndex.Enabled = false;
            this.NewIndex.Image = ((System.Drawing.Image)(resources.GetObject("NewIndex.Image")));
            this.NewIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewIndex.Name = "NewIndex";
            this.NewIndex.Size = new System.Drawing.Size(23, 22);
            this.NewIndex.Text = "New Serial";
            this.NewIndex.ToolTipText = "New Serial";
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteRecord.Enabled = false;
            this.DeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRecord.Image")));
            this.DeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(23, 22);
            this.DeleteRecord.Text = "Delete Record";
            this.DeleteRecord.ToolTipText = "Delete Record";
            // 
            // GridView
            // 
            this.GridView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GridView.Image = ((System.Drawing.Image)(resources.GetObject("GridView.Image")));
            this.GridView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(23, 22);
            this.GridView.Click += new System.EventHandler(this.GridView_Click_1);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator16.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.enableDataGridViewCheckBoxColumn,
            this.SysAdmin,
            this.salesModuleDataGridViewCheckBoxColumn,
            this.prodCapacitiyPlanDataGridViewCheckBoxColumn,
            this.jobCostingDataGridViewCheckBoxColumn,
            this.jobCostSalesDataGridViewCheckBoxColumn,
            this.jobCostGPDataGridViewCheckBoxColumn,
            this.jobCostCostDataGridViewCheckBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODSTAFFBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 11;
            // 
            // pRODSTAFFBindingSource
            // 
            this.pRODSTAFFBindingSource.DataMember = "PROD_STAFF";
            this.pRODSTAFFBindingSource.DataSource = this.mESDataSet;
            // 
            // mESDataSet
            // 
            this.mESDataSet.DataSetName = "MESDataSet";
            this.mESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROD_STAFFTableAdapter
            // 
            this.pROD_STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "USERID";
            this.dataGridViewTextBoxColumn1.HeaderText = "USERID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "****";
            dataGridViewCellStyle1.NullValue = "****";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // enableDataGridViewCheckBoxColumn
            // 
            this.enableDataGridViewCheckBoxColumn.DataPropertyName = "Enable";
            this.enableDataGridViewCheckBoxColumn.HeaderText = "Enable";
            this.enableDataGridViewCheckBoxColumn.Name = "enableDataGridViewCheckBoxColumn";
            // 
            // SysAdmin
            // 
            this.SysAdmin.DataPropertyName = "SysAdmin";
            this.SysAdmin.HeaderText = "SysAdmin";
            this.SysAdmin.Name = "SysAdmin";
            // 
            // salesModuleDataGridViewCheckBoxColumn
            // 
            this.salesModuleDataGridViewCheckBoxColumn.DataPropertyName = "SalesModule";
            this.salesModuleDataGridViewCheckBoxColumn.HeaderText = "Sales Module";
            this.salesModuleDataGridViewCheckBoxColumn.Name = "salesModuleDataGridViewCheckBoxColumn";
            // 
            // prodCapacitiyPlanDataGridViewCheckBoxColumn
            // 
            this.prodCapacitiyPlanDataGridViewCheckBoxColumn.DataPropertyName = "ProdCapacitiyPlan";
            this.prodCapacitiyPlanDataGridViewCheckBoxColumn.HeaderText = "Assign Worker Module";
            this.prodCapacitiyPlanDataGridViewCheckBoxColumn.Name = "prodCapacitiyPlanDataGridViewCheckBoxColumn";
            // 
            // jobCostingDataGridViewCheckBoxColumn
            // 
            this.jobCostingDataGridViewCheckBoxColumn.DataPropertyName = "JobCosting";
            this.jobCostingDataGridViewCheckBoxColumn.HeaderText = "Job Costing Module";
            this.jobCostingDataGridViewCheckBoxColumn.Name = "jobCostingDataGridViewCheckBoxColumn";
            // 
            // jobCostSalesDataGridViewCheckBoxColumn
            // 
            this.jobCostSalesDataGridViewCheckBoxColumn.DataPropertyName = "JobCostSales";
            this.jobCostSalesDataGridViewCheckBoxColumn.HeaderText = "View Sales";
            this.jobCostSalesDataGridViewCheckBoxColumn.Name = "jobCostSalesDataGridViewCheckBoxColumn";
            // 
            // jobCostGPDataGridViewCheckBoxColumn
            // 
            this.jobCostGPDataGridViewCheckBoxColumn.DataPropertyName = "JobCostGP";
            this.jobCostGPDataGridViewCheckBoxColumn.HeaderText = "View GP %";
            this.jobCostGPDataGridViewCheckBoxColumn.Name = "jobCostGPDataGridViewCheckBoxColumn";
            // 
            // jobCostCostDataGridViewCheckBoxColumn
            // 
            this.jobCostCostDataGridViewCheckBoxColumn.DataPropertyName = "JobCostCost";
            this.jobCostCostDataGridViewCheckBoxColumn.HeaderText = "View Cost";
            this.jobCostCostDataGridViewCheckBoxColumn.Name = "jobCostCostDataGridViewCheckBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODSTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private MESDataSet mESDataSet;
        private System.Windows.Forms.BindingSource pRODSTAFFBindingSource;
        private MESDataSetTableAdapters.PROD_STAFFTableAdapter pROD_STAFFTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Navigetor;
        public System.Windows.Forms.ToolStripButton Search;
        public System.Windows.Forms.ToolStripButton InsertData;
        public System.Windows.Forms.ToolStripButton Save;
        public System.Windows.Forms.ToolStripButton Refresh1;
        public System.Windows.Forms.ToolStripButton NewIndex;
        public System.Windows.Forms.ToolStripButton DeleteRecord;
        private System.Windows.Forms.ToolStripButton GridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SysAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn salesModuleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prodCapacitiyPlanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jobCostingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jobCostSalesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jobCostGPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jobCostCostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}