﻿using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO_MES_Module
{
    public partial class JobCard : Form
    {
        public int SalesID, LineNo;
        public JobCard( int _SalesID, int _LineNo)
        {

            SalesID = _SalesID;
            LineNo = _LineNo;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
            // this.PROD_JOBCARDTableAdapter.Summary(this.MESDataSet.PROD_JOBCARD, SalesID);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JobCardView' table. You can move, or remove it, as needed.
            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);

            // ReportParameterCollection rptparamter = new ReportParameterCollection();
            // rptparamter.Add(new Microsoft.Reporting.WinForms.ReportParameter("PrintBy", this.Text) );

           

            //  this.reportViewer1.LocalReport.SetParameters(rptparamter);
            this.reportViewer1.RefreshReport();
            
            //this.reportViewer1.SetPageSettings(setup);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
