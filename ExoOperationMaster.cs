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
    public partial class OperationMaster : Form
    {
        private int childFormNumber = 0;

        public OperationMaster()
        {
            InitializeComponent();
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

        private void OperationMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mESDataSet.OperationMaster' table. You can move, or remove it, as needed.
            this.operationMasterTableAdapter.Fill(this.mESDataSet.OperationMaster);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.operationMasterTableAdapter.Fill(this.mESDataSet.OperationMaster);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operationMasterBindingSource.EndEdit();
            this.operationMasterTableAdapter.Update(this.mESDataSet.OperationMaster);
            
        }


        private void UpdateOperation( String opcode , int updatetype )
        {


            SqlConnection conn = null;
            SqlDataReader rdr = null;
            conn = new SqlConnection(global::EXO_MES_Module.Properties.Settings.Default.UpgradeConnectionString);
            conn.Open();

            // 1.  create a command object identifying
            //     the stored procedure
            SqlCommand cmd = new SqlCommand("PROD_UpdateOperationMaster", conn);

            // 2. set the command object so it knows
            //    to execute a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            //    will be passed to the stored procedure
            cmd.Parameters.Add(new SqlParameter("@OPCode", opcode));
            cmd.Parameters.Add(new SqlParameter("@UpdateType", updatetype));
            // execute the command
            rdr = cmd.ExecuteReader();






        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            this.UpdateOperation(textBox1.Text, 1);
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            this.UpdateOperation(textBox1.Text, 999);
        }
    }
}
