using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO_MES_Module
{
    public partial class JobCardRpt : Form
    {

        int SalesID; 
        public JobCardRpt( int _SalesID)
        {

            SalesID = _SalesID;
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
            this.PROD_JOBCARDTableAdapter.Summary(this.MESDataSet.PROD_JOBCARD, SalesID);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
           // this.PROD_JOBCARDTableAdapter.Summary(this.MESDataSet.PROD_JOBCARD, SalesID);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
