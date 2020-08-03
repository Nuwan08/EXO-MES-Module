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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mESDataSet.PROD_STAFF' table. You can move, or remove it, as needed.
            this.pROD_STAFFTableAdapter.Fill(this.mESDataSet.PROD_STAFF);
           

        }

        private void SubFormGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GetallUsers()
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            conn.Open();

            // 1.  create a command object identifying
              SqlCommand cmd = new SqlCommand("X_UpdateProdStaff", conn);

            // 2. set the command object so it knows
            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            // cmd.Parameters.Add(new SqlParameter("@GUID", new System.Nullable<System.Guid>(new System.Guid(RefUID.Text))));
            // cmd.Parameters.Add(new SqlParameter("@UpdateType", UpdateType));
            // execute the command
            rdr = cmd.ExecuteReader();

        }

        private void GridView_Click(object sender, EventArgs e)
        {
            this.GetallUsers();
            //this.pROD_STAFFTableAdapter.Fill(this.mESDataSet.PROD_STAFF);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.pROD_STAFFTableAdapter.FillBy1(this.mESDataSet.PROD_STAFF);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SysAdmin_CheckedChanged(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void SaveRecord()
        {
           this.Validate();
           this.pROD_STAFFTableAdapter.Update(this.mESDataSet.PROD_STAFF);
         

        }

        

       

        private void Save_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           
            
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void pRODSTAFFBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

       

        private void AssignJob_CheckedChanged(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void Refresh1_Click(object sender, EventArgs e)
        {
            this.pROD_STAFFTableAdapter.Fill(this.mESDataSet.PROD_STAFF);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void GridView_Click_1(object sender, EventArgs e)
        {
            this.GetallUsers();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.SaveRecord();
        }

        private void Refresh1_Click_1(object sender, EventArgs e)
        {
            this.pROD_STAFFTableAdapter.Fill(this.mESDataSet.PROD_STAFF);
        }
    }
}
