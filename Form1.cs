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
    public partial class Form1 : Form
    {

        int SalesID;
        public Form1( int _SalesID)
        {

            SalesID = _SalesID;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MESDataSet.PROD_ROUTE' table. You can move, or remove it, as needed.
            this.PROD_ROUTETableAdapter.FillBy(this.MESDataSet.PROD_ROUTE, SalesID);
            // TODO: This line of code loads data into the 'MESDataSet.PROD_ROUTE' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
