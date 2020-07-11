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
using System.Data.SqlClient;

namespace EXO_MES_Module
{
    public partial class Form1 : Form
    {
        public int SalesID;
        public string IntArr;
        private string StrSqltable, StrSQL, StrSQL2;
        private DataSet dbDataSet;
        private DataTable datatable;
        private dbConnectionMyob db;
        private SqlConnection conn;
        public Form1(int _SalesID, string intArr)
        {

            SalesID = _SalesID;
            IntArr = intArr;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
            //this.PROD_JOBCARDTableAdapter.FillRouteCard(this.MESDataSet.PROD_JOBCARD);

            // this.PROD_JobCardViewTableAdapter.FillByLIstofLine(this.MESDataSet.PROD_JobCardView, SalesID, IntArr);
            StrSQL = @"SELECT        ADDRESS1, ADDRESS2, ADDRESS3, ADDRESS4, AddtionalNotes, AssignTo, BINCODE, CUSTORDERNO, CompleteDate, DESCRIPTION, DISPATCH_INFO, Division, Drawing, DueDate, EnableAddNote, EstimatedTime, 
                         FinFlientGrey, FinMatBlack, FinNoPaint, FinPaintWeldsOnly, FinPickle, FinPolishWelds, FinSilver, INSTRUCTIONS, InStage, MakeToStock, NAME, Note, OPCode, OpName, OrderDate, OrderQTY, PHONE, PlanProductionDate, 
                         PrintBy, ProductionComplete, ProductionQTY, ProductionStartDate, STOCKCODE, SalesEntered, SalesLineRef, ScrapQTY, SoSeqNo, StartDate, Status
FROM            PROD_JobCardView
WHERE        (SoSeqNo = " + SalesID + ") "

  + " AND (SalesLineRef  IN ( " + IntArr + "))";

            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            db = new dbConnectionMyob();
            conn = new SqlConnection(db.DbConecct());
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error with the databse connection");
            }
            dbDataSet = db.ConnectDataSet(StrSQL, "PROD_JobCardView");
            datatable = dbDataSet.Tables[0];

            //ReportDataSource reportDataSource = new ReportDataSource();
            // Must match the DataSet in the RDLC
            //reportDataSource.Name = "MESDataSet";
            //reportDataSource.Value = datatable;
            var reportDataSource1 = new ReportDataSource("ProdJobCardView", datatable);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EXO_MES_Module.Report1.rdlc";
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string tempvalues = comboBox1.Text;
            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);

            //this.reportViewer1.LocalReport.DataSources.Clear();
            // ReportDataSource datasource = new ReportDataSource(pRODJobCardViewBindingSource.DataMember);
            // this.reportViewer1.LocalReport.DataSources.Add(datasource);

            // ReportParameterCollection rptparamter = new ReportParameterCollection();
            // rptparamter.Add(new ReportParameter("PrintBy", this.Text));
            // rptparamter.Add(new Microsoft.Reporting.WinForms.ReportParameter("OperationCode", tempvalues));

            // this.reportViewer1.LocalReport.SetParameters(rptparamter);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
