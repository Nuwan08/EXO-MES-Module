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
    public partial class JoboneLinebyDiv : Form
    {
        private int SalesID, SalesLine;
        public JoboneLinebyDiv( int _salesId , int _SalesLine)
        {
            SalesID = _salesId;

            SalesLine = _SalesLine;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tempvalues = comboBox1.Text;
            this.PROD_JobCardViewTableAdapter.FillBy(this.MESDataSet.PROD_JobCardView, SalesID, SalesLine, comboBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void JoboneLinebyDiv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MESDataSet.PROD_JobCardView' table. You can move, or remove it, as needed.
            this.PROD_JobCardViewTableAdapter.FillBySalesLineRef(this.MESDataSet.PROD_JobCardView,SalesID, SalesLine);

           
        }
    }
}
