using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scope  = Database Conection ,Conection String  Read From XML ,all Views ,Query ,Update & Delete Operation
// Developer = Nuwan Liyanage
// Date = 2008 .11.27

using System.Data;
using System.Data.Odbc;


namespace EXO_MES_Module
{
    public class dbConnection
    {
        private DataViewManager dsview;
        private DataTable datatable, Newdatatable;
        private String conectStr;
        private OdbcDataAdapter dataAdapter;
        private OdbcConnection conn;
        int totalRec = 0;
        private string StrDBtable;

        //DB Settings  be  Reded form XML or Text ????????
        public String DbConecct()
        {

            // Connection String /
            //string connectionString =  "Dsn=WMS;description=WMS;uid=root;app=Microsoft® Visual Studio® 2005;wsid=nuwan;database=WMS;trusted_connection=Yes";
           // string connectionString = "Dsn=wms1";
            return global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString;

        }


        // connet the Sql Server , Return DataTable 
        public DataTable connect(string StrQuery, string StrTable)
        {
            conectStr = DbConecct();
            conn = new OdbcConnection(conectStr);
            string commandString = StrQuery;
            dataAdapter = new OdbcDataAdapter(commandString, conn);
            DataSet ds = new DataSet();


            dataAdapter.Fill(ds, StrTable);
            datatable = ds.Tables[StrTable];
            totalRec = datatable.Rows.Count;
            dsview = ds.DefaultViewManager;


            return datatable;
        }

        public OdbcDataAdapter ReturnDataAdapter()
        {
            return dataAdapter;
        }

        public OdbcConnection ReturnConncetion()
        {
            return conn;
        }

        // connet the Sql Server , Return Data Set 
        public DataSet ConnectDataSet(string StrQuery, string StrTable)
        {
            conectStr = DbConecct();
            conn = new OdbcConnection(conectStr);
            string commandString = StrQuery;
            dataAdapter = new OdbcDataAdapter(commandString, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, StrTable);
            StrDBtable = StrTable;
            return ds;
        }


        public void UpdateData(DataSet dbDataSet, string StrSqltable, string StrStdProcedure, params string[] StrParameterList)
        {

            OdbcCommand updateCommand = new OdbcCommand(StrStdProcedure, conn);
            updateCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.UpdateCommand = updateCommand;
            AddParams(dataAdapter.UpdateCommand, StrParameterList);
            dataAdapter.Update(dbDataSet, StrSqltable);
            dbDataSet.AcceptChanges();
        }

        public void InsertData(DataSet dbDataSet, string StrSqltable, string StrStdProcedure, params string[] StrParameterList)
        {

            OdbcCommand Insertcommand = new OdbcCommand(StrStdProcedure, conn);
            Insertcommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.InsertCommand = Insertcommand;
            AddParams(dataAdapter.InsertCommand, StrParameterList);
            UpdateData(dbDataSet, StrSqltable, StrStdProcedure, StrParameterList);

        }

        public void DeleteData(string StrStrodProcedure, string StrIndex, params string[] StrParameterList)
        {
            OdbcCommand DeleteCommand = new OdbcCommand(StrStrodProcedure, conn);
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

            OdbcCommand IndexCommand = new OdbcCommand(StrStraoadProcedure, conn);
            IndexCommand.CommandType = CommandType.StoredProcedure;
            IndexCommand.Parameters.Add(new OdbcParameter("@IN_Name", OdbcType.VarChar, 0, "IN_Name"));
            IndexCommand.Parameters[0].Value = StringIndexName;
            conn.Open();
            int i = IndexCommand.ExecuteNonQuery();
            conn.Close();

            return NewIndexNo;
        }

        private void AddParams(OdbcCommand cmd, params string[] cols)
        {
            foreach (string col in cols)
            {
                string[] x = col.Split('$');
                switch (x[0])
                {
                    case "C": cmd.Parameters.Add("@" + x[1], OdbcType.Char, 0, x[1]); break;
                    case "N": cmd.Parameters.Add("@" + x[1], OdbcType.Numeric, 0, x[1]); break;
                    case "D": cmd.Parameters.Add("@" + x[1], OdbcType.DateTime, 0, x[1]); break;
                }
            }
        }

    }
}
