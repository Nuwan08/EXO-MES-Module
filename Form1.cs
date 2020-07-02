using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;

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
            // this.PROD_JOBCARDTableAdapter.Summary(this.MESDataSet.PROD_JOBCARD, SalesID);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JobCardView' table. You can move, or remove it, as needed.
            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);

            ReportParameterCollection rptparamter = new ReportParameterCollection();
            rptparamter.Add(new Microsoft.Reporting.WinForms.ReportParameter("PrintBy", this.Text));

            this.reportViewer1.LocalReport.SetParameters(rptparamter);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
