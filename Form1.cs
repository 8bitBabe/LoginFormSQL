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

namespace LoginFormSQL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-MP2O6F5;Initial Catalog=db_LoginFormSQL;Integrated Security=True");
            
            string query = "select * from loginsTable where username =" + txtUserLog.Text.Trim() + "and password='" + txtPwdLog.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                FrmMain objFrmMain = new FrmMain();
                this.Hide();
                objFrmMain.Show();
            }
            else
                MessageBox.Show("This username and password combination \ndoes not exist.", "Error", MessageBoxButtons.OK);

        }
    }
}
