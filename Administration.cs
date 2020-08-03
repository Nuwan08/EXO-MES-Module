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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mESDataSet.PROD_STAFF' table. You can move, or remove it, as needed.
            this.pROD_STAFFTableAdapter.Fill(this.mESDataSet.PROD_STAFF);

        }

        private void SubFormGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsertData_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROD_STAFFTableAdapter.FillBy(this.mESDataSet.PROD_STAFF);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
