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
    public partial class JobCard : Form
    {
        public int SalesID;
        public JobCard( int _SalesID)
        {

            SalesID = _SalesID;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JOBCARD' table. You can move, or remove it, as needed.
           // this.PROD_JOBCARDTableAdapter.Summary(this.MESDataSet.PROD_JOBCARD, SalesID);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JobCardView' table. You can move, or remove it, as needed.
            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);
           
           

            this.reportViewer1.RefreshReport();
        }
    }
}
