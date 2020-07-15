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

namespace EXO_MES_Module
{
    public partial class PrintByJob : Form
    {

        private int SalesID;
        public PrintByJob( int _salesID)
        {
            SalesID = _salesID;
            InitializeComponent();
        }

        private void PrintByJob_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            // TODO: This line of code loads data into the 'MESDataSet.PROD_JobCardView' table. You can move, or remove it, as needed.
            this.PROD_JobCardViewTableAdapter.Fill(this.MESDataSet.PROD_JobCardView, SalesID);

            this.reportViewer1.RefreshReport();
        }
    }
}
