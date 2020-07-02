namespace EXO_MES_Module
{
    partial class JobCard
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
            this.PROD_JobCardViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MESDataSet = new EXO_MES_Module.MESDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROD_JOBCARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROD_JOBCARDTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_JOBCARDTableAdapter();
            this.PROD_JobCardViewTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_JobCardViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JobCardViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JOBCARDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PROD_JobCardViewBindingSource
            // 
            this.PROD_JobCardViewBindingSource.DataMember = "PROD_JobCardView";
            this.PROD_JobCardViewBindingSource.DataSource = this.MESDataSet;
            // 
            // MESDataSet
            // 
            this.MESDataSet.DataSetName = "MESDataSet";
            this.MESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProdJobCardView";
            reportDataSource1.Value = this.PROD_JobCardViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EXO_MES_Module.JobCardView.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PROD_JOBCARDBindingSource
            // 
            this.PROD_JOBCARDBindingSource.DataMember = "PROD_JOBCARD";
            this.PROD_JOBCARDBindingSource.DataSource = this.MESDataSet;
            // 
            // PROD_JOBCARDTableAdapter
            // 
            this.PROD_JOBCARDTableAdapter.ClearBeforeFill = true;
            // 
            // PROD_JobCardViewTableAdapter
            // 
            this.PROD_JobCardViewTableAdapter.ClearBeforeFill = true;
            // 
            // JobCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "JobCard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JobCardViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JOBCARDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROD_JOBCARDBindingSource;
        private MESDataSet MESDataSet;
        private MESDataSetTableAdapters.PROD_JOBCARDTableAdapter PROD_JOBCARDTableAdapter;
        private System.Windows.Forms.BindingSource PROD_JobCardViewBindingSource;
        private MESDataSetTableAdapters.PROD_JobCardViewTableAdapter PROD_JobCardViewTableAdapter;
    }
}