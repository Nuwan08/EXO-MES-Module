using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO_MES_Module
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {

                MainForm M1 = new MainForm(comboBox1.SelectedValue.ToString());
                this.Hide();
                M1.Show();

            }

           // this.Close();



        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mesDataSet1.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.mesDataSet1.STAFF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
