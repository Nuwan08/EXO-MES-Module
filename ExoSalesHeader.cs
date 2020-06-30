using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EXO_MES_Module
{
    public partial class ExoSalesHeader : Form
    {
        private int childFormNumber = 0;
        private SqlConnection conn;
       // private OdbcCommand com;
        private dbConnectionMyob db;
        private string StrSqltable, StrSQL;
        private DataSet dbDataSet;
        private DataTable datatable;
        private int currRecord;

        public ExoSalesHeader()
        {
            InitializeComponent();

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
        }

        public void FillControlers(int currentRec, bool PramerterFlag)
        {
            SubFormGrid.Refresh();
            if (PramerterFlag == true)
            { currRecord = currentRec; }

            if (currRecord >= 0 && currRecord < datatable.Rows.Count)
            {

                SaleID.Text = datatable.Rows[currRecord]["Sales Order"].ToString();
                label1.Text = SaleID.Text;
                label3.Text = SaleID.Text;




            }

        }
        private void MainLIstViewDataload()
        {

            StrSqltable = "PROD_SALESHEADER";
            StrSQL = "SELECT [Sales Order],[Invoice Account] ,[Customer Name] ,[Order Date] ,[Due Date] ,[Customer Ref] ,[Status]"
        + "FROM [PROD_SALESHEADER]"
        + " Where[PROD_SALESHEADER].[StatusID] < 2 order by [Sales Order] desc";


            dbDataSet = db.ConnectDataSet(StrSQL, StrSqltable);
            datatable = dbDataSet.Tables[StrSqltable];
            SubFormGrid.DataSource = dbDataSet;
            SubFormGrid.DataMember = StrSqltable;
            SubFormGrid.Refresh();
            SubFormGrid.SelectedRows.Equals(0);

            InsertData.Enabled = false;
            Save.Enabled = false;
            SaveAll.Enabled = false;
            DeleteRecord.Enabled = false;
            NewIndex.Enabled = true;
            Refresh1.Enabled = false;


            if (datatable.Rows.Count > 0)
            {
                currRecord = 0;
                //ValidateTextboxes();

            }
            else
            {
                SaleID.Text = "";
            }

        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            currRecord = e.RowIndex;
         
            FillControlers(0, false);
            
        }

        private void Doubleclick(object sender, DataGridViewCellEventArgs e)
        {
            currRecord = e.RowIndex;

            FillControlers(0, false);
            ExoJobOrder salesline = new ExoJobOrder(Int32.Parse(SaleID.Text.ToString()));
            salesline.Show();
            this.Hide();
        }

        private void SubFormGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void ExoSalesHeader_Load(object sender, EventArgs e)
        {
            MainLIstViewDataload();
        }
    }
}
