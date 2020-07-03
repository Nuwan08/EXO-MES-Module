using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EXO_MES_Module
{
    public partial class Form1 : Form
    {
        public int SalesID;
        public Form1(int _SalesID)
        {

            SalesID = _SalesID;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
            //this.PROD_JOBCARDTableAdapter.FillRouteCard(this.MESDataSet.PROD_JOBCARD);

            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);

           // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tempvalues = comboBox1.Text;
            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource(pRODJobCardViewBindingSource.DataMember);
            this.reportViewer1.LocalReport.DataSources.Add(datasource);

            ReportParameterCollection rptparamter = new ReportParameterCollection();
            rptparamter.Add(new Microsoft.Reporting.WinForms.ReportParameter("PrintBy", this.Text));
            rptparamter.Add(new Microsoft.Reporting.WinForms.ReportParameter("OperationCode", tempvalues));

            this.reportViewer1.LocalReport.SetParameters(rptparamter);
            
            this.reportViewer1.LocalReport.Refresh();
        }
    }
}
