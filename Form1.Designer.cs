namespace EXO_MES_Module
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PROD_JOBCARDTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_JOBCARDTableAdapter();
            this.PROD_JobCardViewTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_JobCardViewTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pRODJobCardViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MESDataSet = new EXO_MES_Module.MESDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROD_JOBCARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROD_JobCardViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pRODJobCardViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JOBCARDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JobCardViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PROD_JOBCARDTableAdapter
            // 
            this.PROD_JOBCARDTableAdapter.ClearBeforeFill = true;
            // 
            // PROD_JobCardViewTableAdapter
            // 
            this.PROD_JobCardViewTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pRODJobCardViewBindingSource;
            this.comboBox1.DisplayMember = "OPCode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // pRODJobCardViewBindingSource
            // 
            this.pRODJobCardViewBindingSource.DataMember = "PROD_JobCardView";
            this.pRODJobCardViewBindingSource.DataSource = this.MESDataSet;
            // 
            // MESDataSet
            // 
            this.MESDataSet.DataSetName = "MESDataSet";
            this.MESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Production Division";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pRODJobCardViewBindingSource, "OPCode", true));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "ProdJobCardView";
            reportDataSource1.Value = this.PROD_JobCardViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EXO_MES_Module.Report1 - Copy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 394);
            this.reportViewer1.TabIndex = 4;
            // 
            // PROD_JOBCARDBindingSource
            // 
            this.PROD_JOBCARDBindingSource.DataMember = "PROD_JOBCARD";
            this.PROD_JOBCARDBindingSource.DataSource = this.MESDataSet;
            // 
            // PROD_JobCardViewBindingSource
            // 
            this.PROD_JobCardViewBindingSource.DataMember = "PROD_JobCardView";
            this.PROD_JobCardViewBindingSource.DataSource = this.MESDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODJobCardViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JOBCARDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JobCardViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MESDataSetTableAdapters.PROD_JOBCARDTableAdapter PROD_JOBCARDTableAdapter;
        private MESDataSetTableAdapters.PROD_JobCardViewTableAdapter PROD_JobCardViewTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROD_JOBCARDBindingSource;
        private MESDataSet MESDataSet;
        private System.Windows.Forms.BindingSource pRODJobCardViewBindingSource;
        private System.Windows.Forms.BindingSource PROD_JobCardViewBindingSource;
    }
}