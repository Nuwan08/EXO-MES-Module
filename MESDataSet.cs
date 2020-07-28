using System;
using System.Data;

namespace EXO_MES_Module
{


    partial class MESDataSet
    {
        partial class PROD_ROUTEDataTable
        {
        }
    }
}

namespace EXO_MES_Module.MESDataSetTableAdapters
{
    partial class PROD_JobCardViewTableAdapter
    {
    }

    partial class PROD_DashboardTableAdapter
    {
    }

    partial class PROD_JOBCARDTableAdapter
    {
        internal int FillBy1(DataTable datatable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[2];
            

            int returnValue = this.Adapter.Fill(datatable);
            return returnValue;
        }
    }

    public partial class PROD_ROUTETableAdapter {
    }
}
