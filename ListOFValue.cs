using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXO_MES_Module
{
    public partial class ListofValue : Form
    {
        private MainForm MDIMain;
        private DataTable dbTable;
        private DataSet dbDataSet;
        private string Navi_Selected, tableName, SQLstr;
        private int Fieldindex;
        //private int currRec = 1;


        public ListofValue( string _TableName , MainForm M2)
        {
            tableName = _TableName;
            MDIMain = M2;
            InitializeComponent();
        }
        public void GetCurrentSubForm(int fieldindex, MainForm sender, string SelectedFrm)
        {   MDIMain = sender;
            Navi_Selected = SelectedFrm;
            Fieldindex = fieldindex;
        } 
        private void query_Load(object sender, EventArgs e)
        {
        }


        public void LoadData()
        {
            String StrSQL = "SELECT top 300 Active, AddtionalNotes, Color, Cost, Division, Drawing, DueDate, EnableAddNote, FinFlientGrey, FinMatBlack, FinNoPaint, FinPaintWeldsOnly, FinPickle, FinPolishWelds, FinSilver, GP, ID, InStage, MakeToStock, Note, OrderDate, OrderQTY, PlanProductionDate, ProductionComplete, ProductionStartDate, STOCKCODE, Sales, SalesID, SalesLine, Status FROM PROD_JOBCARD" +
                 " WHERE (Active IS NULL)";



           
            for (int RecodeCount = 0; RecodeCount < dataGridView1.Rows.Count; RecodeCount++)
            {
                if (dataGridView1[2, RecodeCount].Value != null & dataGridView1[3, RecodeCount].Value != null)
                {
                    

                        StrSQL = StrSQL + "  and ";

                   


                    if (dataGridView1[1, RecodeCount].Value.ToString() == "INT")
                    {
                        switch (dataGridView1[2, RecodeCount].Value.ToString())
                        {
                            case "like":
                                StrSQL = StrSQL + dataGridView1[0, RecodeCount].Value + " " + dataGridView1[2, RecodeCount].Value + "'" + dataGridView1[3, RecodeCount].Value + "%'";
                                break;
                            case "=":
                                StrSQL = StrSQL + dataGridView1[0, RecodeCount].Value + " " + dataGridView1[2, RecodeCount].Value + " " + dataGridView1[3, RecodeCount].Value + " ";
                                break;

                            default:
                                StrSQL = StrSQL + dataGridView1[0, RecodeCount].Value + " " + dataGridView1[2, RecodeCount].Value + " " + dataGridView1[3, RecodeCount].Value + " ";
                                break;
                        }

                    }
                    else
                    {

                        switch (dataGridView1[2, RecodeCount].Value.ToString())
                        {
                            case "like":
                                StrSQL = StrSQL + dataGridView1[0, RecodeCount].Value + " " + dataGridView1[2, RecodeCount].Value + " '" + dataGridView1[3, RecodeCount].Value + "%'";
                                break;
                            case "==":
                                StrSQL = StrSQL + dataGridView1[0, RecodeCount].Value + " " + dataGridView1[2, RecodeCount].Value + " '" + dataGridView1[3, RecodeCount].Value + "'";
                                break;

                            default:
                                StrSQL = StrSQL + dataGridView1[0, RecodeCount].Value + " " + dataGridView1[2, RecodeCount].Value + " '" + dataGridView1[3, RecodeCount].Value + "'";
                                break;
                        }


                    }



                   
                }
            }

            StrSQL += " order by salesID Desc";
            QueryBox.Text = StrSQL;


            MDIMain.fillter(StrSQL);

          /*  dbConnectionMyob db = new dbConnectionMyob();
            dbDataSet = db.ConnectDataSet(StrSQL, tableName);
            dbTable = dbDataSet.Tables[tableName];
            dataGridView2.DataSource = dbDataSet;
            dataGridView2.DataMember = tableName;
            dataGridView2.Refresh();*/
        }

        private void GO_Click(object sender, EventArgs e)
        {
            this.LoadData();
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbTable.Rows.Count > e.RowIndex)
            {
                switch (Navi_Selected)
                {
                    case "Company":  break;
                    case "Departments":  break;
                    case "Buyer Profile":// MDIMain.Obj_Buyer.txtStoreLoca.Text = dbTable.Rows[e.RowIndex][1].ToString(); break;
                   
                    case "Invoice Perticuler":
                          switch (Fieldindex)
                              {
                              case 8:  
                                     
                                  
                                  break;
                                   case 9:// MDIMain.Obj_supplierInvoice.txtLocationId.Text = dbTable.Rows[e.RowIndex][0].ToString();
                                      // MDIMain.Obj_supplierInvoice.txtLocationName.Text = dbTable.Rows[e.RowIndex][1].ToString();
                                       break;
                                   case 10:// MDIMain.Obj_supplierInvoice.txtGrade.Text = dbTable.Rows[e.RowIndex][1].ToString();
                                       break;
                                   case 11: //MDIMain.Obj_supplierInvoice.txtPackingType.Text = dbTable.Rows[e.RowIndex][1].ToString();
                                       break;
                                   case 12:// MDIMain.Obj_supplierInvoice.txtOwnerShip.Text = dbTable.Rows[e.RowIndex][0].ToString();
                                       break;
                                      
                             }break;
                    case "Location"://MDIMain.Obj_Location.txtCompCode.Text = dbTable.Rows[e.RowIndex][1].ToString();
                                    //MDIMain.Obj_Location.txtCompName.Text = dbTable.Rows[e.RowIndex][0].ToString(); break;


                                case "Goods Recive Note": //MDIMain.Obj_Goods_Recive_Note.txtEstateID.Text = dbTable.Rows[e.RowIndex][3].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtInvoiceYear.Text = dbTable.Rows[e.RowIndex][23].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtPlantaionName.Text = dbTable.Rows[e.RowIndex][2].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtElavation.Text = dbTable.Rows[e.RowIndex][15].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtLocationName.Text = dbTable.Rows[e.RowIndex][24].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtMark.Text = dbTable.Rows[e.RowIndex][8].ToString() + dbTable.Rows[e.RowIndex][9].ToString() + dbTable.Rows[e.RowIndex][7].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtinvoiceRef.Text = dbTable.Rows[e.RowIndex][1].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtSuppINvo.Text = dbTable.Rows[e.RowIndex][0].ToString();
                                    //MDIMain.Obj_Goods_Recive_Note.txtLocID.Text = dbTable.Rows[e.RowIndex][20].ToString();
                        
                                    break;
                }
            
          }

        }

        

        private void ListofValue_Load(object sender, EventArgs e)
        {
            dbConnectionMyob db = new dbConnectionMyob();
            //tableName = "select * from Navigation where Name = '" + Navi_Selected + "'";
           // dbTable = db.connect(tableName, "Navigation");
           // tableName = 
            SQLstr = "select * from X_PROD_QueryIndex where Q_TableName ='" + tableName + "'";
            
            
        
            dbTable = db.connect(SQLstr, "QueryIndex");
            for (int RecodeCount = 0; RecodeCount < dbTable.Rows.Count; RecodeCount++)
            {
                switch (dbTable.Rows[RecodeCount][3].ToString())
                {
                    case "Dat":
                        dataGridView1.Rows.Add(dbTable.Rows[RecodeCount][2].ToString(), dbTable.Rows[RecodeCount][3].ToString(), " = ");
                        break;

                    default:
                        dataGridView1.Rows.Add(dbTable.Rows[RecodeCount][2].ToString(), dbTable.Rows[RecodeCount][3].ToString(), "like");
                        break; 
                }
                       

            }
            LoadData(); 

        }

        private void GO_Click_1(object sender, EventArgs e)
        {

            this.LoadData();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }












    }
}