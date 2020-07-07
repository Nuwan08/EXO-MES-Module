using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EXO_MES_Module
{
    public partial class Goods_Issue_Note: Form
    {
        private DataSet dbDataSet;
        private OdbcDataAdapter dbAdapter;
        private DataTable datatable, dbNewDatatable;
        private dbConnection db;
        private OdbcConnection conn;
        private string StrSqltable ,StrSQL ,NewIndexNo;
        private int currRecord;
        private MainForm M1;



        public Goods_Issue_Note()
        {
            //InitializeComponent();
           // {
               
           // }
        }
       /* public void CerateDocument()
        {
            db = new dbConnection();
            dbNewDatatable = db.connect("Select * From WMS_I_IndexTable where  IN_Name='Supplier_Invoice'", "WMS_I_IndexTable");
            NewIndexNo = dbNewDatatable.Rows[0][2].ToString() + dbNewDatatable.Rows[0][3].ToString() + dbNewDatatable.Rows[0][1].ToString();
            Dataload("Select * From WMS_T_INVOICE_PERTICULER where Invoice_NO =' " + NewIndexNo + "'", "WMS_T_INVOICE_PERTICULER");
            Dataload("Select * From mpo_line ", "mpo_line");
            ItemCode_txt.Text = NewIndexNo;
        }
        * /
       /* public  void GetMainObjects( Main sender )
        {
            M1 = sender;
        }
        */
        private void AddParams(OdbcCommand cmd, params string[] cols)
        {
            foreach (string col in cols)
            {
                cmd.Parameters.Add("@" + col, OdbcType.Char, 0, col);
               
            }

           
        }


        public void Dataload(string StrSql, string Strtable)
        {
         
            db = new dbConnection();
            dbDataSet = db.ConnectDataSet(StrSql, Strtable);
            datatable = dbDataSet.Tables[Strtable];
            SubFormGrid.DataSource = dbDataSet;
            SubFormGrid.DataMember = Strtable ;
            SubFormGrid.Refresh();
          
            dbAdapter = db.ReturnDataAdapter();
            StrSqltable = Strtable;
            StrSQL = StrSql;
            if (datatable.Rows.Count > 0)
            {
                currRecord = 0;
                //ValidateTextboxes();

            }
            else
            {
                MPOLineNo_txt.Text = "";
                MPO_txt.Text = "";
                ItemCode_txt.Text = "";
                ItemName_txt.Text = "";
                Color_txt.Text = "";
                cutPrGrpNo_txt.Text = "";
                Status_txt.Text = "";
                SawingIn_txt.Text = "";
                SawingOut_txt.Text = "";
                PackingOut_txt.Text = "";
                OrderQty_txt.Text = "";
                LineNo_txt.Text = "";
                //ProductionNo_txt.Text ="";
               
            }
             

            // Get Coonction
            conn = db.ReturnConncetion();

            

            ///thush
            
            // Preparing SQL Command for Insert
          
            OdbcCommand InsertCommand = new OdbcCommand("{CALL STP_MPOLine(?,?,?,?,?,?,?,?,?,?,?,?)}", conn);
            InsertCommand.CommandType = CommandType.StoredProcedure;
            dbAdapter.InsertCommand = InsertCommand;
            AddParams(dbAdapter.InsertCommand, "MPOLine", "ItemCode", "ItemName", "Color", "SewingIN", "Counting", "PackingOut", "OrderQty", "TRstatus", "MPONo", "CutProductionGroupNo", "LineNo");
            
            // Preparing SQL Command for update

             OdbcCommand updateCommand = new OdbcCommand("{CALL STP_MPOLine(?,?,?,?,?,?,?,?,?,?,?,?)}", conn);
             updateCommand.CommandType = CommandType.StoredProcedure;
             dbAdapter.UpdateCommand = updateCommand;
             AddParams(dbAdapter.UpdateCommand, "MPOLine", "ItemCode", "ItemName", "Color", "SewingIN", "Counting", "PackingOut", "OrderQty", "TRstatus", "MPONo", "CutProductionGroupNo", "LineNo");
             
                        
            // Preparing SQL Command for Delete

            OdbcCommand DeleteCommand = new OdbcCommand("{CALL STP_MPOLineDelete(?)}", conn);
            DeleteCommand.CommandType = CommandType.StoredProcedure;
            dbAdapter.DeleteCommand = DeleteCommand;
            AddParams(dbAdapter.DeleteCommand,  "LineNo");

            currRecord = 0;
            //insertrecode = 1;
        }

        public void FillControlers(int currentRec , bool PramerterFlag )
        {
            SubFormGrid.Refresh();
            if (PramerterFlag == true)
            {currRecord = currentRec;}
            
            if (currRecord >= 0 && currRecord < datatable.Rows.Count)
            {
                MPOLineNo_txt.Text = datatable.Rows[currRecord]["MPOLine"].ToString();
                MPO_txt.Text = datatable.Rows[currRecord]["MPONo"].ToString();
                ItemCode_txt.Text = datatable.Rows[currRecord]["ItemCode"].ToString();
                ItemName_txt.Text = datatable.Rows[currRecord]["ItemName"].ToString();
                Color_txt.Text = datatable.Rows[currRecord]["Color"].ToString();
                cutPrGrpNo_txt.Text = datatable.Rows[currRecord]["CutProductionGroupNo"].ToString();
                SawingIn_txt.Text = datatable.Rows[currRecord]["SewingIn"].ToString();
                SawingOut_txt.Text = datatable.Rows[currRecord]["Counting"].ToString();
                PackingOut_txt.Text = datatable.Rows[currRecord]["PackingOut"].ToString();
                OrderQty_txt.Text = datatable.Rows[currRecord]["orderQty"].ToString();
                LineNo_txt.Text = datatable.Rows[currRecord]["Lineno"].ToString();
                Status_txt.Text = datatable.Rows[currRecord]["TRStatus"].ToString();
                //ProductionNo_txt.Text = datatable.Rows[currRecord]["ProductionNO"].ToString();
               // Size_txt.Text = datatable.Rows[currRecord]["Size"].ToString();
                LineNo_txt.ReadOnly = true;
                Status_txt.ReadOnly = true;
                
            
            }

        }

       /* private void txtValidation()
         {
             if (MPOLineNo_txt.Text.Trim() == "") { MPOLineNo_txt.Text = (0).ToString(); }
             if (ItemCode_txt.Text.Trim() == "") { ItemCode_txt.Text = (0).ToString(); }
             if (ItemName_txt.Text.Trim() == "") { ItemName_txt.Text = (0).ToString(); }
             if (Color_txt.Text.Trim() == "") { Color_txt.Text = (0).ToString(); }
             if (SawingIn_txt.Text.Trim() == "") { SawingIn_txt.Text = (0).ToString(); }
             if (SawingOut_txt.Text.Trim() == "") { SawingOut_txt.Text = (0).ToString(); }
             if (PackingOut_txt.Text.Trim() == "") { PackingOut_txt.Text = (0).ToString(); }
             if (OrderQty_txt.Text.Trim() == "") { OrderQty_txt.Text = (0).ToString(); }
             if (MPO_txt.Text.Trim() == "") { MPO_txt.Text = (0).ToString(); }
             if (cutPrGrpNo_txt.Text.Trim() == "") { cutPrGrpNo_txt.Text = (0).ToString(); }
         
         }*/



       private void txtValidation()
        {          
            if (MPOLineNo_txt.Text.Trim() == "") { lbl_A.Text = "*"; }
            //if (IsNumber(MPOLineNo_txt.Text.Trim())) { lbl_A.Text = "**"; }

            if (ItemCode_txt.Text.Trim() == "") { lbl_D.Text = "*"; }
           // if (IsNumber(ItemCode_txt.Text.Trim())) { lbl_D.Text = "**"; }

            if (ItemName_txt.Text.Trim() == "") { lbl_E.Text = "*"; }
            //if (IsNumber(ItemName_txt.Text.Trim())) { lbl_E.Text = "**"; }

            if (Color_txt.Text.Trim() == "") { lbl_F.Text = "*"; }
            //if (IsNumber(Color_txt.Text.Trim())) { lbl_F.Text = "**"; }

            if (SawingIn_txt.Text.Trim() == "") { lbl_G.Text = "*"; }
            if (!IsNumber(SawingIn_txt.Text.Trim())) { lbl_G.Text = "*"; }

            if (SawingOut_txt.Text.Trim() == "") { lbl_H.Text = "*"; }
            if (!IsNumber(SawingOut_txt.Text.Trim())) { lbl_H.Text = "*"; }

            if (PackingOut_txt.Text.Trim() == "") { lbl_I.Text = "*"; }
            if (!IsNumber(PackingOut_txt.Text.Trim())) { lbl_I.Text = "*"; }

            if (OrderQty_txt.Text.Trim() == "") { lbl_J.Text = "*"; }
            if (!IsNumber(OrderQty_txt.Text.Trim())) { lbl_J.Text = "*"; }

            if (MPO_txt.Text.Trim() == "") { lbl_B.Text = "*"; }
            //if (IsNumber(MPO_txt.Text.Trim())) { lbl_B.Text = "**"; }

            if (cutPrGrpNo_txt.Text.Trim() == "") { lbl_C.Text = "*"; }
            //if (IsNumber(cutPrGrpNo_txt.Text.Trim())) { lbl_C.Text = "**"; }

        }


        static bool IsNumber(string value)
        {
            // Return true if this is a number.
            int number1;
            return int.TryParse(value, out number1);
            
        }


        public void SaveARecord()
        {

            try
            {
                DataRow row = datatable.Rows[currRecord];
                row.BeginEdit();
                row["MPOLine"] = MPOLineNo_txt.Text;
                row["MPOno"] = MPO_txt.Text;
                row["ItemCode"] = ItemCode_txt.Text;
                row["ItemName"] = ItemName_txt.Text;
                row["Color"] = Color_txt.Text;
                row["SewingIn"] = SawingIn_txt.Text;
                row["Counting"] = SawingOut_txt.Text;
                row["PackingOut"] = PackingOut_txt.Text;
                row["OrderQty"] = OrderQty_txt.Text;
                row["TRstatus"] = "Update";
                row["CutProductionGroupNo"] = cutPrGrpNo_txt.Text;
                row["LineNo"] = datatable.Rows[currRecord]["LineNo"];
                row.EndEdit();
                dbAdapter.Update(dbDataSet, StrSqltable);
                dbDataSet.AcceptChanges();
                Dataload(StrSQL, StrSqltable);
            }

            catch (Exception e)
            {
                txtValidation();
                MessageBox.Show("invalid arguments");

            }

        }


        /*public void SaveAsBatch()
        {
            dbAdapter.UpdateBatchSize = datatable.Rows.Count-2;
            dbAdapter.Update(dbDataSet, StrSqltable);
            dbDataSet.AcceptChanges();
        
        }*/


        public void InsertRecord()
        {
         // txtValidation();
           try
            {
                    DataRow row = datatable.NewRow();
                    datatable.Rows.Add(row);
                    currRecord = datatable.Rows.Count - 1;

                    row.BeginEdit();
                    row["SewingIn"] = SawingIn_txt.Text;
                    row["Counting"] = SawingOut_txt.Text;
                    row["PackingOut"] = PackingOut_txt.Text;
                    row["OrderQty"] = OrderQty_txt.Text;
                    row["MPOLine"] = MPOLineNo_txt.Text;
                    row["ItemCode"] = ItemCode_txt.Text;
                    row["ItemName"] = ItemName_txt.Text;
                    row["Color"] = Color_txt.Text;
                    row["MPONo"] = MPO_txt.Text;
                    row["CutProductionGroupNo"] = cutPrGrpNo_txt.Text;
                    row["TRstatus"] = "add";
                    row["LineNo"] = datatable.Rows[currRecord]["LineNo"];
                    row.EndEdit();
                    SubFormGrid.CurrentCell = SubFormGrid.Rows[currRecord].Cells[0];
                    dbAdapter.Update(dbDataSet, StrSqltable);
                    dbDataSet.AcceptChanges();
                    Dataload(StrSQL, StrSqltable);
                    SubFormGrid.Enabled = true;
                    SubFormGrid.Columns[9].ReadOnly = true;
                    LineNo_txt.ReadOnly = true;
                
            }

            catch (Exception e)
            {
                txtValidation();
                MessageBox.Show("invalid arguments");
              
            }
                      
        }


        public void NewRecord()
        {
            SubFormGrid.Enabled = false;
            MPOLineNo_txt.Clear();
            MPO_txt.Clear();
            ItemCode_txt.Clear();
            ItemName_txt.Clear();
            Color_txt.Clear();
            SawingIn_txt.Clear();
            SawingOut_txt.Clear();
            PackingOut_txt.Clear();
            OrderQty_txt.Clear();
            Status_txt.Clear();
            cutPrGrpNo_txt.Clear();
            //ProductionNo_txt.Clear();
            LineNo_txt.Clear();
            lbl_G.Text = "";
            lbl_I.Text = "";
            lbl_H.Text = "";
            lbl_J.Text = "";
            lbl_A.Text = "";
            lbl_B.Text = "";
            lbl_C.Text = "";
            lbl_D.Text = "";
            lbl_E.Text = "";
            lbl_F.Text = "";
            SubFormGrid.Enabled = true;

}

       public void DeleteRecord()
        {
           
            DialogResult res = MessageBox.Show("Are u Sure you want to delete this record", "confirm Record Deletion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                
                DataRow row = datatable.Rows[currRecord];
                row["LineNo"] = datatable.Rows[currRecord]["LineNo"];
                row.Delete();
                dbAdapter.Update(dbDataSet, StrSqltable);
                dbDataSet.AcceptChanges();
                currRecord = currRecord - 1;
                FillControlers(currRecord, true);
                
            }   
        }

        

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {  
        }

        private void SelectionChange(object sender, EventArgs e)
        {
        }

        private void Rowvalidation(object sender, DataGridViewCellEventArgs e)
        {        
        }

        private void Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            currRecord = e.RowIndex;
           //currntRec2.Text = currRecord.ToString();
            FillControlers( 0 , false);
        }

        private void Cell(object sender, DataGridViewCellEventArgs e)
        {
           //currRecord = e.RowIndex;
           //currntRec2.Text = currRecord.ToString();
            FillControlers(0, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {      
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Valideted(object sender, EventArgs e)
        {     
            //ValidateTextboxes();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
           // splitContainer232.SplitterDistance = 390;
        }

        private void Supplier_invoice_Load(object sender, EventArgs e)
        {
           // splitContainer232.SplitterDistance = 390;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListofValue LI = new ListofValue("Main");
            LI.GetCurrentSubForm(8,M1, "Supplier Profile");
            LI.Show();
        }

        private void ConfigerationGROup_Enter(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void MPOLineNo_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void currntRec2_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void tabPage6_Click(object sender, EventArgs e)
        {
        }

        private void close_MPO_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void close_MPO_TabIndexChanged(object sender, TabControlCancelEventArgs e)
        {
            this.Close();
        }

       

       
        
 
    }
}