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
    public partial class Login : Form
    {

        private SqlConnection conn;
        
        private dbConnectionMyob db;
        private string StrSqltable, StrSQL;
        private DataSet dbDataSet;
        private DataTable datatable;
        private int currRecord;
        public Login()
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

        private void ButtLogin_Click(object sender, EventArgs e)
        {
            if (textPass.Text == "" || TxtUserID.Text == "" )
            {
                MessageBox.Show("Empty Login Name or Password ");

            }
            else
            {
                StrSQL = "Select ID from PROD_Staff where ENABLE =1 and password = '" + textPass.Text + "' and UserId = '" + TxtUserID.Text + "'";
                StrSqltable = "PROD_STAFF";
                dbDataSet = db.ConnectDataSet(StrSQL, StrSqltable);
                datatable = dbDataSet.Tables[StrSqltable];

                if (datatable.Rows.Count > 0)
                {

                    MainForm M1 = new MainForm(datatable.Rows[0][0].ToString());
                    this.Hide();
                    M1.Show();
                    
                }else

                {

                    MessageBox.Show("Invalid Login Name or Password ");

                }


            }
            
            
           

           // this.Close();



        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mesDataSet1.STAFF' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
