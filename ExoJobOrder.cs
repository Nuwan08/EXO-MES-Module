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
    public partial class ExoJobOrder : Form
    {
        
        private bool bol_SpliterFlag;
        
        private dbConnectionMyob db;
        
       
        private string StrSqltable, StrSQL, StrSQL2;
        private DataSet dbDataSet;
        private DataTable datatable, datatable2;
        private int currRecord;
        private SqlConnection conn;

        public ExoJobOrder( int SEQNO )
        {
            InitializeComponent();
            TxtOrderId.Text= SEQNO.ToString();
           // soSeqNoToolStripTextBox.Text = SEQNO.ToString();
            this.Text = "Production Order " + TxtOrderId.Text;
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

            

            // Load Sales order lines 
            MainLIstViewDataload();

            //
            FillControlers( 0, false);

            

            OperationLoad();
           

            try
            {
                this.pROD_JOBCARDTableAdapter.Summary(this.mESDataSet.PROD_JOBCARD, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            if (pROD_ROUTEDataGridView.RowCount > 0 )
            {
                tabControl1.SelectedIndex = 0;
                InsertData.Enabled = true;
                Save.Enabled = true;

                GridView.Enabled = false;
                DeleteRecord.Enabled = true;
                NewIndex.Enabled = false;
                Refresh1.Enabled = true;

            }

            if (checkBox1.CheckState == CheckState.Checked)
            {
                richTextBox2.Visible = true;


            }
            else
            { richTextBox2.Visible = false; }
        }


        public void FillControlers(int currentRec, bool PramerterFlag)
        {
            SubFormGrid.Refresh();
            if (PramerterFlag == true)
            { currRecord = currentRec; }

            if (currRecord >= 0 && currRecord < datatable.Rows.Count)
            {

              SalesLine.Text = datatable.Rows[currRecord]["SEQNO"].ToString();
              StockItem.Text = datatable.Rows[currRecord]["STOCKCODE"].ToString();

                // Initalized operations 
                InitOperations("NoOperation", 0);
            }

            if (SalesLine.Text == null)
             SalesLine.Text ="0";
            StrSQL2 = "SELECT * FROM dbo.PROD_ROUTE where STOCKCODE = '" + StockItem.Text
                + "' and SoSeqNo = " + TxtOrderId.Text + " and SalesLineRef = " + SalesLine.Text;

            DataloadtoList(StrSQL2, "PROD_ROUTE");

            RefreshProdRoute();

            attionalSkechbox();

        }

        private void OperationLoad()
        {
            try
            {

                this.pROD_ROUTETableAdapter.FillBy(this.mESDataSet.PROD_ROUTE, ((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int)))));

                // TODO: This line of code loads data into the 'mESDataSet.PROD_JOBCOST' table. You can move, or remove it, as needed.
                if (RefUID.Text != "")
                { this.proD_JOBCOSTTableAdapter1.Fill(this.mESDataSet.PROD_JOBCOST, new System.Nullable<System.Guid>(new System.Guid(RefUID.Text))); }


              
               this.pROD_JOBCARDTableAdapter.FillBy(this.mESDataSet.PROD_JOBCARD, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(SalesLine.Text, typeof(int))))), StockItem.Text);

               this.pROD_JOBCARDTableAdapter.Summary(this.mESDataSet.PROD_JOBCARD, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void MainLIstViewDataload()
        {

            StrSqltable = "SALESORD_LINES";
            StrSQL = "SELECT [SeqNO],[STOCKCODE],[DESCRIPTION] "
      + ",[ORD_QUANT],[INV_QUANT],[UNITPRICE] ,[LOCATION]"
      + " FROM [SALESORD_LINES] where X_PRODUCTIONREQUIRED ='Y' and HDR_SEQNO =" + TxtOrderId.Text;


            try
            {
                this.pROD_SALESHEADERTableAdapter.Fill(this.mESDataSet.PROD_SALESHEADER, ((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



            dbDataSet = db.ConnectDataSet(StrSQL, StrSqltable);
            datatable = dbDataSet.Tables[StrSqltable];
            SubFormGrid.DataSource = dbDataSet; 
            SubFormGrid.DataMember = StrSqltable;
            SubFormGrid.Refresh();
            SubFormGrid.SelectedRows.Equals(0);

            InsertData.Enabled = false;
            Save.Enabled = true;
            splitContainer1.SplitterDistance = 25;
           
            DeleteRecord.Enabled = false;
            NewIndex.Enabled = false;
            Refresh1.Enabled = false;

            


            if (datatable.Rows.Count > 0)
            {
                currRecord = 0;
                

            }
            

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            currRecord = e.RowIndex;

            FillControlers(0, false);

        }
        private void ExoSalesLine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mESDataSet.PROD_DRAWING' table. You can move, or remove it, as needed.
        
            try
            {
                this.pROD_SALESHEADERTableAdapter.Fill(this.mESDataSet.PROD_SALESHEADER, ((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            // TODO: This line of code loads data into the 'mESDataSet.SALESORD_HDR' table. You can move, or remove it, as needed.
           // this.sALESORD_HDRTableAdapter.Fill(this.mESDataSet.SALESORD_HDR);
            // TODO: This line of code loads data into the 'mESDataSet.STOCK_ITEMS' table. You can move, or remove it, as needed.
            this.sTOCK_ITEMSTableAdapter.Fill(this.mESDataSet.STOCK_ITEMS);


            // TODO: This line of code loads data into the 'mESDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.mESDataSet.STAFF);
            // TODO: This line of code loads data into the 'mESDataSet.PROD_ROUTE' table. You can move, or remove it, as needed.
            this.pROD_ROUTETableAdapter.Fill(this.mESDataSet.PROD_ROUTE, (int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))));


            // TODO: This line of code loads data into the 'mESDataSet.PROD_JOBCOST' table. You can move, or remove it, as needed.
            if (RefUID.Text != "")
            { this.proD_JOBCOSTTableAdapter1.Fill(this.mESDataSet.PROD_JOBCOST, new System.Nullable<System.Guid>(new System.Guid(RefUID.Text))); }
            if (TxtDueDate.Text.ToString().Length > 4)
            {
                DateTime now = DateTime.Today;
                TimeSpan Diff = now.Subtract(DateTime.Parse (TxtDueDate.Text));
                TxtOverDue.Text = Diff.ToString();
            }
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void OperationView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BttComplete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you have captured all materials and labor cost ?  Once production order ended, system not allowed to report additional material or labor cost for this production order ", "End Production Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (RefUID.Text != "")
                    this.SheduleJob(RefUID.Text, 500);
            }
            
            
           this.Validate();
           this.pROD_ROUTEBindingSource.EndEdit();
           this.pROD_ROUTETableAdapter.Update(this.mESDataSet.PROD_ROUTE);
           this.tableAdapterManager.UpdateAll(this.mESDataSet);
        }

        private void BttStart_Click(object sender, EventArgs e)
        {
            if (RefUID.Text != "")
                this.SheduleJob(RefUID.Text, 400);
        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pROD_ROUTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROD_ROUTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mESDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROD_ROUTETableAdapter.FillBy(this.mESDataSet.PROD_ROUTE, (int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void OperationView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

       private void saveProdRoute()
        {
            this.Validate();
            this.pROD_ROUTEBindingSource.EndEdit();
            this.pROD_ROUTETableAdapter.Update(this.mESDataSet.PROD_ROUTE);

           
        }

        private void saveJobCard()
        {
            this.Validate();
            this.pRODJOBCARDBindingSource.EndEdit();
            this.pROD_JOBCARDTableAdapter.Update(this.mESDataSet.PROD_JOBCARD);


        }

        private void saveJobCostLine()
        {
            this.Validate();
           
            this.pRODJOBCOSTBindingSource.EndEdit();
            this.proD_JOBCOSTTableAdapter1.Update(this.mESDataSet.PROD_JOBCOST);


        }



        private void sOIDToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROD_ROUTETableAdapter.Fill(this.mESDataSet.PROD_ROUTE, ((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void Save_Click(object sender, EventArgs e)
        {
            

            this.saveJobCard();

            this.saveProdRoute();
        }

        private void pROD_JOBCOSTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RefUID.Text != "")
                this.SheduleJob(RefUID.Text, 0);

        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            if (RefUID.Text != "")
                this.SheduleJob(RefUID.Text, 300);
        }

       
        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void Navigetor_Click(object sender, EventArgs e)
        {
            if (bol_SpliterFlag == true)
            {
                splitContainer1.SplitterDistance = 150;
                bol_SpliterFlag = false;
            }
            else
            {
                splitContainer1.SplitterDistance = 25;
                bol_SpliterFlag = true;
            }

            
        }

        private void EditJobcostline(object sender, DataGridViewCellEventArgs e)
        {
            this.PostJobCost((int)(System.Convert.ChangeType(RecID.Text, typeof(int))), 0);
        }

       

        

        private void saveJobCardRec(object sender, EventArgs e)
        {
            this.saveJobCard();
        }

        private void Cellclick(object sender, MouseEventArgs e)
        {
           
        }

        private void Cellclick(object sender, EventArgs e)
        {
            
        }

        private void SubFormGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currRecord = e.RowIndex;

            FillControlers(0, false);
        }

      

      

        private void summaryToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void summaryToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void DataloadtoList(string StrSql, string Strtable)
        {

            db = new dbConnectionMyob();
            dbDataSet = db.ConnectDataSet(StrSql, Strtable);
            datatable2 = dbDataSet.Tables[Strtable];


            ListBoxAll.Items.Clear();
            listBoxSelected.Items.Clear();

            foreach (DataRow row in datatable2.Rows)
            {

                if (Convert.ToBoolean(row["Enable"].ToString()))
                {
                    listBoxSelected.Items.Add(row["OPCode"].ToString());
                }
                else
                {
                    ListBoxAll.Items.Add(row["OPCode"].ToString());
                }

            }





            
        }


        public void DataloadtoDrawingList(string StrSql, string Strtable)
        {

            db = new dbConnectionMyob();
            dbDataSet = db.ConnectDataSet(StrSql, Strtable);
            datatable2 = dbDataSet.Tables[Strtable];


            
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            this.CostCalculation((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))), 100);
            this.pROD_JOBCARDTableAdapter.Summary(this.mESDataSet.PROD_JOBCARD, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))))));




        }

        private void TabChange(object sender, EventArgs e)
        {
           if( tabControl1.SelectedIndex == 0)
            {

                InsertData.Enabled = false;
                Save.Enabled = true;

                GridView.Enabled = false;
                DeleteRecord.Enabled = false;
                NewIndex.Enabled = false;
                Refresh1.Enabled = false;
            }

           else  if (tabControl1.SelectedIndex == 1 && RecID.Text != "")
                {

                    InsertData.Enabled = true;
                    Save.Enabled = true;

                    GridView.Enabled = false;
                    DeleteRecord.Enabled = true;
                    NewIndex.Enabled = false;
                    Refresh1.Enabled = true;
                }

            else if (tabControl1.SelectedIndex == 2)
            {

                InsertData.Enabled = false;
                Save.Enabled = false;

                GridView.Enabled = true;
                DeleteRecord.Enabled = false;
                NewIndex.Enabled = false;
                Refresh1.Enabled = false;
            }



        }

        private void RecID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pROD_ROUTEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && RecID.Text != "")
            {

                InsertData.Enabled = true;
                Save.Enabled = true;

                GridView.Enabled = false;
                DeleteRecord.Enabled = true;
                NewIndex.Enabled = false;
                Refresh1.Enabled = true;


                if ( TxtStatusID.Text.Trim() == "Start" || TxtStatusID.Text.Trim() == "End")
                {

                    pROD_ROUTEDataGridView.ReadOnly = true;

                }
                else
                {
                    pROD_ROUTEDataGridView.ReadOnly = false;
                }

                try
                {
                    

                    this.proD_JOBCOSTTableAdapter1.Fill(this.mESDataSet.PROD_JOBCOST, new System.Nullable<System.Guid>(new System.Guid(RefUID.Text)));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
               






            


                

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void RefreshProdRoute()
        {


            this.pROD_JOBCARDTableAdapter.FillBy(this.mESDataSet.PROD_JOBCARD, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(SalesLine.Text, typeof(int))))), StockItem.Text);

            if (checkBox1.Checked)
            {
                richTextBox2.Visible = true;


            }

            //  StrSQL3 = "SELECT * FROM dbo.PROD_ROUTE where SoSeqNo = " + TxtOrderId.Text;

            //  StrSqltable3 = "PROD_ROUTE";
            //  dbDataSet = db.ConnectDataSet(StrSQL3, StrSqltable3);
            //   datatableProdRoute = dbDataSet.Tables[StrSqltable3];


        }
            

        //load default operations frist time when order intiate 
        private void InitOperations( string OPCode ,int UpdateType)
        {

            SqlConnection conn = null;
            SqlDataReader rdr = null;
            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            conn.Open();

            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("UPDATE_PRODCTION_ROUTE", conn);

            // 2. set the command object so it knows
            //    to execute a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@SalesSeqno", Int32.Parse(TxtOrderId.Text)));
            cmd.Parameters.Add(new SqlParameter("@StockItem", StockItem.Text));
            cmd.Parameters.Add(new SqlParameter("@SalesLineSEQ", Int32.Parse(SalesLine.Text.ToString())));
            cmd.Parameters.Add(new SqlParameter("@OPCODE", OPCode));
            cmd.Parameters.Add(new SqlParameter("@UpdateType", UpdateType));
            
            // execute the command
            rdr = cmd.ExecuteReader();


            this.pROD_ROUTETableAdapter.Fill(this.mESDataSet.PROD_ROUTE, (int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))));

        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            if(RecID.Text != "")
            this.PostJobCost((int)(System.Convert.ChangeType(RecID.Text, typeof(int))), 999);
        }


        private void chanageStatus()
        {
            if (TxtStatusID.Text.Trim() == "Start")
            {
                BttComplete.Enabled = true;
                dataGridView1.ReadOnly = false;
                InsertData.Enabled = true;
                DeleteRecord.Enabled = true;
                BttStart.Enabled = false;

            }
            else if (TxtStatusID.Text.Trim() == "End")
            {
                InsertData.Enabled = false;
                DeleteRecord.Enabled = false;
                BttComplete.Enabled = false;
                BttStart.Enabled = false;
                dataGridView1.ReadOnly = true;

            }
            else if (TxtStatusID.Text.Trim() == "Created")
            {
                InsertData.Enabled = false;
                DeleteRecord.Enabled = false;
                BttComplete.Enabled = false;
                BttStart.Enabled = false;
                dataGridView1.ReadOnly = true;

            }
            else if (TxtStatusID.Text.Trim() == "schedule")
            {
                InsertData.Enabled = false;
                DeleteRecord.Enabled = false;
                BttComplete.Enabled = false;
                BttStart.Enabled = true;
                dataGridView1.ReadOnly = true;

            }
            else
            {
               /* InsertData.Enabled = true;
                DeleteRecord.Enabled = true;
                BttComplete.Enabled = true;
                BttStart.Enabled = false;
                dataGridView1.ReadOnly = false;*/

            }

        }

        private void pROD_ROUTEDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            this.chanageStatus();
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
         

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DivisionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            JobCard jobcard = new JobCard((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))), (int)(System.Convert.ChangeType(SalesLine.Text, typeof(int))));
            jobcard.Text = this.Text;
            jobcard.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 jobcard2 = new Form1((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))));
            jobcard2.Text = this.Text;
            jobcard2.Show();
        }

        private void attionalSkechbox()
        {

            if (checkBox1.CheckState == CheckState.Checked)
            {

                // richTextBox2.Top
                if (this.Height < 671)
                {
                    this.Height = this.Height + 110;

                    richTextBox2.Height = 90;
                    richTextBox2.Visible = true;
                }



            }
            else
            {
                if (this.Height > 561)
                {
                    this.Height = this.Height - 110;
                }
                //  checkBox2.Top = 3;
                richTextBox2.Height = 10;
                richTextBox2.Visible = false;
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            attionalSkechbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListBoxAll.SelectedItem != null)
            {
                InitOperations(ListBoxAll.SelectedItem.ToString(), 100);
                listBoxSelected.Items.Add(ListBoxAll.SelectedItem);
                ListBoxAll.Items.Remove(ListBoxAll.SelectedItem);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxSelected.SelectedItem != null)
            {
                InitOperations(listBoxSelected.SelectedItem.ToString(), 200);
                ListBoxAll.Items.Add(listBoxSelected.SelectedItem);
                listBoxSelected.Items.Remove(listBoxSelected.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JoboneLinebyDiv jobcard = new JoboneLinebyDiv((int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))), (int)(System.Convert.ChangeType(SalesLine.Text, typeof(int))));
            jobcard.Text = this.Text;
            jobcard.Show();
        }

        private void SheduleJob(string UID, int UpdateType)
        {

            this.saveProdRoute();

            SqlConnection conn = null;
            SqlDataReader rdr = null;
            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            conn.Open();

            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("UPDATE_PRODCTION_ROUTEJOBCOST", conn);

            // 2. set the command object so it knows
            //    to execute a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@GUID", new System.Nullable<System.Guid>(new System.Guid(RefUID.Text))));
            cmd.Parameters.Add(new SqlParameter("@UpdateType", UpdateType));
            // execute the command
            rdr = cmd.ExecuteReader();

            
           

            try
            {
                if(UpdateType!= 300)
                this.pROD_ROUTETableAdapter.Fill(this.mESDataSet.PROD_ROUTE, (int)(System.Convert.ChangeType(TxtOrderId.Text, typeof(int))));

                this.proD_JOBCOSTTableAdapter1.Fill(this.mESDataSet.PROD_JOBCOST, new System.Nullable<System.Guid>(new System.Guid(RefUID.Text)));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


           

        }



        private void PostJobCost( int recid, int UpdateType)
        {
            this.saveJobCostLine();

            SqlConnection conn = null;
            SqlDataReader rdr = null;
            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            conn.Open();

            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("UPDATE_PRODCTION_JobCostLine", conn);

            // 2. set the command object so it knows
            //    to execute a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@RecId", (int)(System.Convert.ChangeType(RecID.Text, typeof(int)))));
            cmd.Parameters.Add(new SqlParameter("@UpdateType", UpdateType));
            // execute the command
            rdr = cmd.ExecuteReader();

           


            try
            {
                this.proD_JOBCOSTTableAdapter1.Fill(this.mESDataSet.PROD_JOBCOST, new System.Nullable<System.Guid>(new System.Guid(RefUID.Text)));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            

        }


        private void CostCalculation(int SalesOrderID, int UpdateType)
        {


            SqlConnection conn = null;
            SqlDataReader rdr = null;
            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            conn.Open();

            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("Prod_CostCalculation", conn);

            // 2. set the command object so it knows
            //    to execute a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@SalesSeqno", SalesOrderID));
            cmd.Parameters.Add(new SqlParameter("@UpdateType", UpdateType));
            // execute the command
            rdr = cmd.ExecuteReader();


        }
    }
}
