namespace EXO_MES_Module
{
    partial class JobCardRpt
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
            this.PROD_JOBCARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MESDataSet = new EXO_MES_Module.MESDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROD_JOBCARDTableAdapter = new EXO_MES_Module.MESDataSetTableAdapters.PROD_JOBCARDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JOBCARDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PROD_JOBCARDBindingSource
            // 
            this.PROD_JOBCARDBindingSource.DataMember = "PROD_JOBCARD";
            this.PROD_JOBCARDBindingSource.DataSource = this.MESDataSet;
            // 
            // MESDataSet
            // 
            this.MESDataSet.DataSetName = "MESDataSet";
            this.MESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PROD_JOBCARDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EXO_MES_Module.JobCard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(490, 357);
            this.reportViewer1.TabIndex = 0;
            // 
            // PROD_JOBCARDTableAdapter
            // 
            this.PROD_JOBCARDTableAdapter.ClearBeforeFill = true;
            // 
            // JobCardRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "JobCardRpt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROD_JOBCARDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MESDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROD_JOBCARDBindingSource;
        private MESDataSet MESDataSet;
        private MESDataSetTableAdapters.PROD_JOBCARDTableAdapter PROD_JOBCARDTableAdapter;
    }
}