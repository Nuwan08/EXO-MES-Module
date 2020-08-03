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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SubFormGrid = new System.Windows.Forms.DataGridView();
            this.sTAFFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mESDataSet = new EXO_MES_Module.MESDataSet();
            this.pRODSTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter1 = new EXO_MES_Module.MESDataSetTableAdapters.STAFFTableAdapter();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Navigetor = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.InsertData = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.SaveAll = new System.Windows.Forms.ToolStripButton();
            this.Refresh1 = new System.Windows.Forms.ToolStripButton();
            this.NewIndex = new System.Windows.Forms.ToolStripButton();
            this.DeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.GridView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.pROD_STAFFTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_STAFFTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SubFormGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODSTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubFormGrid
            // 
            this.SubFormGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SubFormGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubFormGrid.AutoGenerateColumns = false;
            this.SubFormGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.SubFormGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubFormGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.SubFormGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubFormGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubFormGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.enableDataGridViewCheckBoxColumn});
            this.SubFormGrid.DataSource = this.pRODSTAFFBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubFormGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubFormGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFormGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubFormGrid.Location = new System.Drawing.Point(0, 25);
            this.SubFormGrid.Name = "SubFormGrid";
            this.SubFormGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubFormGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubFormGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.SubFormGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubFormGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SubFormGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SubFormGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.SubFormGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubFormGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubFormGrid.Size = new System.Drawing.Size(800, 425);
            this.SubFormGrid.TabIndex = 16;
            this.SubFormGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubFormGrid_CellContentClick);
            // 
            // sTAFFBindingSource1
            // 
            this.sTAFFBindingSource1.DataMember = "STAFF";
            this.sTAFFBindingSource1.DataSource = this.mESDataSet;
            // 
            // mESDataSet
            // 
            this.mESDataSet.DataSetName = "MESDataSet";
            this.mESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODSTAFFBindingSource
            // 
            this.pRODSTAFFBindingSource.DataMember = "PROD_STAFF";
            this.pRODSTAFFBindingSource.DataSource = this.mESDataSet;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.mESDataSet;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Navigetor,
            this.Search,
            this.InsertData,
            this.Save,
            this.SaveAll,
            this.Refresh1,
            this.NewIndex,
            this.DeleteRecord,
            this.GridView,
            this.toolStripSeparator16,
            this.toolStripSeparator17});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 17;
            this.toolStrip.Text = "Main Menu";
            this.toolStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
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
            this.InsertData.Click += new System.EventHandler(this.InsertData_Click);
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
            // 
            // SaveAll
            // 
            this.SaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAll.Enabled = false;
            this.SaveAll.Image = ((System.Drawing.Image)(resources.GetObject("SaveAll.Image")));
            this.SaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(23, 22);
            this.SaveAll.Text = "Save All";
            this.SaveAll.ToolTipText = "Save All";
            // 
            // Refresh1
            // 
            this.Refresh1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refresh1.Image = ((System.Drawing.Image)(resources.GetObject("Refresh1.Image")));
            this.Refresh1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh1.Name = "Refresh1";
            this.Refresh1.Size = new System.Drawing.Size(23, 22);
            this.Refresh1.Text = "Refresh";
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
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator16.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator17.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // pROD_STAFFTableAdapter
            // 
            this.pROD_STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.DataSource = this.sTAFFBindingSource;
            this.userIDDataGridViewTextBoxColumn.DisplayMember = "NAME";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIDDataGridViewTextBoxColumn.ValueMember = "NAME";
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Admin",
            "Production Manager",
            "Production Planner",
            "Staff",
            "Team Member"});
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            this.userRoleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userRoleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            dataGridViewCellStyle3.Format = "*******";
            dataGridViewCellStyle3.NullValue = null;
            this.passwordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // enableDataGridViewCheckBoxColumn
            // 
            this.enableDataGridViewCheckBoxColumn.DataPropertyName = "Enable";
            this.enableDataGridViewCheckBoxColumn.HeaderText = "Enable";
            this.enableDataGridViewCheckBoxColumn.Name = "enableDataGridViewCheckBoxColumn";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillByToolStrip.TabIndex = 18;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.SubFormGrid);
            this.Controls.Add(this.toolStrip);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubFormGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODSTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubFormGrid;
        private MESDataSetTableAdapters.STAFFTableAdapter staffTableAdapter1;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private MESDataSet mESDataSet;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Navigetor;
        public System.Windows.Forms.ToolStripButton Search;
        public System.Windows.Forms.ToolStripButton InsertData;
        public System.Windows.Forms.ToolStripButton Save;
        public System.Windows.Forms.ToolStripButton SaveAll;
        public System.Windows.Forms.ToolStripButton Refresh1;
        public System.Windows.Forms.ToolStripButton NewIndex;
        public System.Windows.Forms.ToolStripButton DeleteRecord;
        private System.Windows.Forms.ToolStripButton GridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.BindingSource pRODSTAFFBindingSource;
        private MESDataSetTableAdapters.PROD_STAFFTableAdapter pROD_STAFFTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}