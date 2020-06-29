using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Data.Odbc;


namespace EXO_MES_Module
{
    public class dbConnectionMyob
    {
        private DataViewManager dsview;
        private DataTable datatable, Newdatatable;
        private String conectStr;
        SqlDataAdapter dataAdapter;
        private  SqlConnection conn;
        int totalRec = 0;
        private string StrDBtable;

        //DB Settings  be  Reded form XML or Text ????????
        public String DbConecct()
        {

            // Connection String /
            //string connectionString =  "Dsn=WMS;description=WMS;uid=root;app=Microsoft® Visual Studio® 2005;wsid=nuwan;database=WMS;trusted_connection=Yes";
            // conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            return global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString;

        }


        // connet the Sql Server , Return DataTable 
        public DataTable connect(string StrQuery, string StrTable)
        {
            conectStr = DbConecct();
            conn = new SqlConnection(conectStr);
            string commandString = StrQuery;
            dataAdapter = new SqlDataAdapter(commandString, conn);
            DataSet ds = new DataSet();


            dataAdapter.Fill(ds, StrTable);
            datatable = ds.Tables[StrTable];
            totalRec = datatable.Rows.Count;
            dsview = ds.DefaultViewManager;


            return datatable;
        }

        public SqlDataAdapter ReturnDataAdapter()
        {
            return dataAdapter;
        }

        public SqlConnection ReturnConncetion()
        {
            return conn;
        }

        // connet the Sql Server , Return Data Set 
        public DataSet ConnectDataSet(string StrQuery, string StrTable)
        {
            conectStr = DbConecct();
            
            conn = new SqlConnection(conectStr);
            string commandString = StrQuery;
            dataAdapter = new SqlDataAdapter(commandString, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, StrTable);
            StrDBtable = StrTable;
            return ds;
        }


        public void UpdateData(DataSet dbDataSet, string StrSqltable, string StrStdProcedure, params string[] StrParameterList)
        {

            SqlCommand updateCommand = new SqlCommand(StrStdProcedure, conn);
            updateCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.UpdateCommand = updateCommand;
            AddParams(dataAdapter.UpdateCommand, StrParameterList);
            dataAdapter.Update(dbDataSet, StrSqltable);
            dbDataSet.AcceptChanges();
        }

        public void InsertData(DataSet dbDataSet, string StrSqltable, string StrStdProcedure, params string[] StrParameterList)
        {

            SqlCommand Insertcommand = new SqlCommand(StrStdProcedure, conn);
            Insertcommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.InsertCommand = Insertcommand;
            AddParams(dataAdapter.InsertCommand, StrParameterList);
            UpdateData(dbDataSet, StrSqltable, StrStdProcedure, StrParameterList);

        }

        public void DeleteData(string StrStrodProcedure, string StrIndex, params string[] StrParameterList)
        {
            SqlCommand DeleteCommand = new SqlCommand(StrStrodProcedure, conn);
            DeleteCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.DeleteCommand = DeleteCommand;
            AddParams(dataAdapter.DeleteCommand, StrParameterList);
            DeleteCommand.Parameters[0].Value = StrIndex;
            conn.Open();
            int i = DeleteCommand.ExecuteNonQuery();
            conn.Close();

        }

        public string NewIndex(string StrStraoadProcedure, string StringIndexName)
        {
            string NewIndexNo;
            Newdatatable = connect("Select * From WMS_I_IndexTable where  IN_Name='" + StringIndexName + "'", "WMS_I_IndexTable");
            NewIndexNo = Newdatatable.Rows[0][3].ToString() + Newdatatable.Rows[0][2].ToString();

            SqlCommand IndexCommand = new SqlCommand(StrStraoadProcedure, conn);
            IndexCommand.CommandType = CommandType.StoredProcedure;
            IndexCommand.Parameters.Add(new SqlParameter("@IN_Name", SqlDbType.VarChar, 0, "IN_Name"));
            IndexCommand.Parameters[0].Value = StringIndexName;
            conn.Open();
            int i = IndexCommand.ExecuteNonQuery();
            conn.Close();

            return NewIndexNo;
        }

        private void AddParams(SqlCommand cmd, params string[] cols)
        {
            foreach (string col in cols)
            {
                string[] x = col.Split('$');
               
                switch (x[0])
                 {
                     case "C": cmd.Parameters.Add("@" + x[1], SqlDbType.Char, 0, x[1]); break;
                     case "N": cmd.Parameters.Add("@" + x[1], SqlDbType.Real, 0, x[1]); break;
                     case "D": cmd.Parameters.Add("@" + x[1], SqlDbType.DateTime, 0, x[1]); break;
                 }
            }
        }

    }
}
