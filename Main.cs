using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;


namespace EXO_MES_Module
{
    public partial class MainForm : Form
    {

        
        
        private string  depatmentNo;
        private bool bol_SpliterFlag;



        private string SelectedFrm;
        
        public String NewDoNo, dono;
        public int donum, errorqty, barcodelen, rowcountDatagrid1;

        // public DataRow tempRow;

        /// <summary>
        /// /Data Forms ...........................................................
        /// </summary>
        
       
      //  private ListofValue LI;
       
       

        /// <summary>
        /// Procedures ............................................................
        /// </summary>
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        

        public MainForm( string workerName)
        {
            InitializeComponent();
            bol_SpliterFlag = true;

            this.Dashboard(workerName);
            this.Text = workerName;
            MainSpliterContainer.SplitterDistance = 450;
            MainSpliterContainer.Panel1Collapsed = false;
            MainSpliterContainer.Panel2Collapsed = true;
            dataGridView1.Visible = true;
            bol_SpliterFlag = true;
        }



        
        
         


        

      

        private void NavigetorDataLoad()

        {

            //db = new dbConnection();
            //NavigetorDataTable = db.connect("select * from navigation order by  precedence", "WMS_Navigation");
            //int M_Node, M1_Node;
            //M_Node = 0;
            //M1_Node = 0;
            //MainNavigeter1.Nodes.Add("");
            //MainNavigeter1.Nodes.Add("");
            //MainNavigeter1.Nodes.Add("");

            //for (int RecodeCount = 0; RecodeCount < NavigetorDataTable.Rows.Count; RecodeCount++)
            //{
            //    int test = int.Parse(NavigetorDataTable.Rows[RecodeCount]["TypeIndex"].ToString());
            //    switch (test)
            //    {
            //        case 1:
            //            MainNavigeter1.Nodes.Add(NavigetorDataTable.Rows[RecodeCount]["Name"].ToString());
            //            //MainNavigeter1.Nodes[M_Node].NodeFont = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //            M_Node = M_Node + 1;
            //            break;
            //        case 2:
            //            MainNavigeter1.Nodes[M_Node - 1].Nodes.Add(NavigetorDataTable.Rows[RecodeCount]["Name"].ToString());
            //            //MainNavigeter1.Nodes[M_Node - 1].Nodes[M1_Node].NodeFont = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //            MainNavigeter1.Nodes[M_Node - 1].Nodes[M1_Node].ForeColor = System.Drawing.SystemColors.WindowText;
            //            M1_Node = M1_Node + 1;
            //            break;
            //        case 3:
            //            MainNavigeter1.Nodes[M_Node - 1].Nodes[M1_Node - 1].Nodes.Add(NavigetorDataTable.Rows[RecodeCount]["Name"].ToString());
            //            break;

            //    }

            //}
            //MainNavigeter1.ExpandAll();
            //bol_SpliterFlag = true;
            //MainLIstViewDataload();

        }

        // Sub Window Load
        public void DataFormload(string selectedForm)
        {
            bool flag = true;
            
            SelectedFrm = selectedForm;

            //Tool trip  option  setings 
            Search.Enabled = true;

            InsertData.Enabled = false;
            Save.Enabled = false;
            SaveAll.Enabled = false;
            DeleteRecord.Enabled = false;
            NewIndex.Enabled = true;
            Refresh1.Enabled = false;

           
            flag = true;
            //TxtBarcodeReader.Select();

        }
        /// <summary>
        /// ..............These functions are used to pass the form objects ...........................
        /// </summary>
        /// <returns></returns>

      //  public Company ReturnCurrentForm() { return Subform; }

       
        //load Query Window.................................................................

       /* public query QueryFormload()
        {
            // New Form Load 
            query QueryWindow = new query();
            QueryWindow.GetCurrentSubForm(this, "Vendor");
            QueryWindow.Show();
            return QueryWindow;
        } */

        
        //-> Event Main Form Load 
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mESDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.mESDataSet.STAFF);


            try
            {
                this.pROD_JOBCARDTableAdapter.FillBy1(this.mESDataSet.PROD_JOBCARD);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        // load Employee Details



        //..........


    

       

        public void formclose()
        {
           // Obj_Goods_Issue_Note.Close();
        }

       

     


       

       

        



    
        
        

        //-> Event Navigetor Click
        private void MainNavigeter_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
        //-> Event MDI form Resize
        private void Main_Resize(object sender, EventArgs e)
        {
            //frmresize();
        }
        //-> Event query form Resize
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            findfrom();
        }

        ////...Tool StripMenu Functions... ////////////////////////////////////////////////////
        /// <summary>
        /// Main Form Tool Strip Menu  will heald the all INSERT,DELETE ,UPDATE & Connect DB Operation .
        /// </summary>


        private void toolStripButton7_Click(object sender, EventArgs e)
        {
          /*  switch (SelectedFrm)
            {
                case "Vendor": Subform.InsertRecord(); InsertData.Enabled = true; break;
                case "Location": Obj_Location.InsertRecord(); break;
                // case "Invoice Perticuler": Obj_supplierInvoice.InsertRecord(); Save.Enabled = true; break;
                case "Supplier Profile": Obj_supplier.InsertRecord(); break;
                case "Buyer Profile": Obj_Buyer.InsertRecord(); break;
                case "Tea Grading Index": Obj_MaterialMaster.InsertRecord(); break;
                case "Goods Recive Note": Obj_Goods_Recive_Note.InsertRecord(); break;
                case "MPO": Obj_Goods_Issue_Note.InsertRecord(); Refresh1.Enabled = true; InsertData.Enabled = false; break;
            } */
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
         

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
        

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
          /*  switch (SelectedFrm)
            {
                case "Vendor": Subform.DeleteRecord(); break;
                case "Departments": Obj_Department.DeleteRecord(); break;
                //case "Invoice Perticuler": Obj_supplierInvoice.DeleteRecord(); break;
                case "Supplier Profile": Obj_supplier.DeleteRecord(); break;
                case "Goods Recive Note": Obj_Goods_Recive_Note.DeleteRecord(); break;
                case "Location": Obj_Location.DeleteRecord(); break;
                case "MPO": Obj_Goods_Issue_Note.DeleteRecord(); break;
                // default: M1.DeleteRecord1(); DeleteRecord.Enabled = true; break;  
            }*/

        }


      

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
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
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          Select_Vendor(); DeleteRecord.Enabled = false;
               
        }

       

  
     

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.Dashboard(this.Text);
        }

     
        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripButton6_Click(sender, e);
        }

        private void insertLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton10_Click(sender, e);
        }






       


       

        
        static bool IsNumber(string value)
        {
            // Return true if this is a number.
            int number1;
            return int.TryParse(value, out number1);

        }


        private void Txt_Quantity_TextChanged(object sender, EventArgs e)
        {

           
            
        }
      
              
        public void getDept(string dept)
        {
            depatmentNo = dept;

            // MessageBox.Show(depatmentNo);

        }

        public void getInitialBarcodelen(int len)
        {
            barcodelen = len;

            //MessageBox.Show("Barcode length " +barcodelen);

        }


        public void CerateDocument()
        {


        }

        public void Select_Vendor()
        {
            // New Form Load 
         /*   query QueryWindow = new query();
            if (Depatment.Text == "WashingRec")
            { QueryWindow.GetCurrentSubForm(this, "recycle"); }
            else
            { QueryWindow.GetCurrentSubForm(this, "Main"); }
            QueryWindow.Show();*/

        }


    


       

       

       
      

        private void keypress(object sender, KeyPressEventArgs e)
        {


        
                
                    
         
         
        }

        private void KeypresswashRead(string barcodeID)
        {

           
           
        }

        private void KeypressNomal(string barcodeID)
        {


          
           
        }


        
      
          
        
        private void manualMPOToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           /* ManualMPO mpo = new ManualMPO();
            mpo.ShowDialog();*/
        }

       
        
        

      
        private void deliveryQuentityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           /* frmInventry_Trans inventry = new frmInventry_Trans();
            inventry.ShowDialog();*/
        }

        private void mPOToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void fromSubjectReceivedSizeCategoriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void mPOLineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void venderOrProductionLineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void mPOLineDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OperationMaster OperationMaster = new OperationMaster();
            OperationMaster.Show();

        }

        private void dODataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void MainSpliterContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateCutQtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // string inputline = UpdateCutQty("SELECT * from mpo_line  ", "mpo_line");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bundleTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mPOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void Navigetor_Click(object sender, EventArgs e)
        {
            if (bol_SpliterFlag == true)
            {
                MainSpliterContainer.SplitterDistance = 10;
                bol_SpliterFlag = false;
            }
            else
            {
                MainSpliterContainer.SplitterDistance = 250;
                bol_SpliterFlag = true;
            }
        }

      
        private void dd(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
        



        public void findfrom()
        {
           
            
        }

        private void Depatment_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SubFormGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salesOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExoSalesHeader salesheader = new ExoSalesHeader();
            salesheader.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label_QTY_Click(object sender, EventArgs e)
        {

        }

        public void addqtyfrom()
        {

           /* if (TXT_DO.Text != "" && comboBox2.Text != "" )
            {
              dataGridView1.Enabled = false;
            Obj_frmAddQTY = new frmAddQTY();
            Obj_frmAddQTY.Show();
            Obj_frmAddQTY.GetCurrentSubForm(this);

            }
            else
            {
                MessageBox.Show(" Please Enter Delivery order NO and Vender details..Then Scan barcode");
            }*/
        }


        public void updateqty( string qty)
        {
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            
            addqtyfrom();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            addqtyfrom();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           
            addqtyfrom();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
           
            addqtyfrom();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            addqtyfrom();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
           
            addqtyfrom();
        }

        

       

       
        private void TxtBarcodeReader_TextChanged(object sender, EventArgs e)
        {

        }

        private void sTAFFBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sMVImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ImportSMV SMV = new ImportSMV();
           // SMV.ShowDialog();
        }

        private void swingOutTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmswingToday Today = new frmswingToday();
           // Today.ShowDialog();
        }

        private void weeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // fmSwingOut swing = new fmSwingOut();
           // swing.ShowDialog();
        }

        private void lineByLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmSewngOutbyItemcode Itemcode = new frmSewngOutbyItemcode();
           // Itemcode.ShowDialog();
        }

        private void deliveryOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmDOno DO = new frmDOno();
           // DO.ShowDialog();
        }

        private void sewingInTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmSewingInReport sewing = new frmSewingInReport();
           // sewing.ShowDialog();
        }

        private void packingInTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPackingIn packingIn = new frmPackingIn();
            //packingIn.ShowDialog();
        }

        private void packingOutTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmPackingOut PackingOut = new frmPackingOut();
           // PackingOut.ShowDialog();
        }

        private void washingTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  frmWashingRec washingRec = new frmWashingRec();
          //  washingRec.ShowDialog();
        }

        private void weeklyReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  fmSwingOut swing = new fmSwingOut();
          //  swing.ShowDialog();
        }

        private void dailyCuttingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  frmDailyCuttingReport cutting = new frmDailyCuttingReport();
          //  cutting.ShowDialog();
        }

        private void upadateSTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmUpdateSTF STF = new frmUpdateSTF();
           // STF.ShowDialog ();
        }

        private void sTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmSTF stf = new frmSTF();
           // stf.ShowDialog();
        }

        private void Dashboard( string worker)
        {
            try
            {
                this.pROD_DashboardTableAdapter.FillBy(this.mESDataSet.PROD_Dashboard, worker.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


         

        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ExoJobOrder salesline = new ExoJobOrder(Int32.Parse(SalesID.Text.ToString()));
            salesline.Show();
            

        }



        private void dailySewingInReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmDailyCutting SewingIn = new frmDailyCutting();
           // SewingIn.ShowDialog();
        }

        private void changeTheLineNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmChangeLine LineNo = new frmChangeLine();
           // LineNo.ShowDialog();
        }

        private void cutToShipReconcilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  frmCut_TO_Ship CutReport = new frmCut_TO_Ship();
          //  CutReport.ShowDialog();
        }

        private void dailySewingInReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  frmDailyCutting SewingIn = new frmDailyCutting();
          //  SewingIn.ShowDialog();
        }

       
        private void sewingInByItemCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmSewngInbyItemcode sewingIn = new frmSewngInbyItemcode();
           // sewingIn.ShowDialog();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExoJobOrder salesline = new ExoJobOrder(Int32.Parse(SalesID.Text.ToString()));
            salesline.Show();
        }

        private void MainSpliterContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mainToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROD_JOBCARDTableAdapter.Main(this.mESDataSet.PROD_JOBCARD);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mainToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROD_JOBCARDTableAdapter.Main(this.mESDataSet.PROD_JOBCARD);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pRODJOBCARDBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (JobIDtxt.Text == "" )
            {
                  MessageBox.Show("Please select sales Line", JobIDtxt.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {

                if (e.ColumnIndex == 7)
                {

                    // MessageBox.Show("Please select sales Line", e.ColumnIndex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    JobCardRpt jobcard = new JobCardRpt(Int32.Parse(JobIDtxt.Text));
                    jobcard.Text = "JOB CARD " + JobIDtxt.Text;
                    jobcard.Show();
                }
                else if (e.ColumnIndex == 8)
                {
                    ExoJobOrder salesline = new ExoJobOrder(Int32.Parse(JobIDtxt.Text));
                    salesline.Show();

                }
                 

            }


        }

        private void Navigetor_Click_1(object sender, EventArgs e)
        {

        }

        private void Navigetor_Click_2(object sender, EventArgs e)
        {
            if (bol_SpliterFlag == true)
            {
                MainSpliterContainer.SplitterDistance = 5;
                MainSpliterContainer.Panel1Collapsed = true;
                MainSpliterContainer.Panel2Collapsed = false;
                dataGridView1.Visible = false;
                bol_SpliterFlag = false;
            }
            else
            {
                MainSpliterContainer.SplitterDistance = 450;
                MainSpliterContainer.Panel1Collapsed = false;
                MainSpliterContainer.Panel2Collapsed = true;
                dataGridView1.Visible = true;
                bol_SpliterFlag = true;

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODJOBCARDBindingSource.EndEdit();
            this.pROD_JOBCARDTableAdapter.Update(this.mESDataSet.PROD_JOBCARD);
        }

        private void cumulativeSTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmNewCumilative Cumulative = new frmNewCumilative();
           // Cumulative.ShowDialog();
        }

        private void ironersDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmIronerInsert ironres = new frmIronerInsert();
           // ironres.ShowDialog();
        }

        private void bundleTicketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void changeTheEmpDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
       }
                                               
      }
    }

    
