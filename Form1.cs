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
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MP2O6F5;Initial Catalog=db_LoginFormSQL;Integrated Security=True");

            //Exception Handling Statement (try, catch, finally)
            try
            {
                sqlCon.Open();

                SqlCommand SqlComm = new SqlCommand (@"select * FROM loginsTable WHERE username =@txtUserLog 
                and and password=@txtPwdLog", sqlCon);

                /*A params approach to avoid SQL injection problems and move the job of properly
                 quoting values to the framework code*/
                SqlComm.Parameters.AddWithValue("@txtUserLog", txtUserLog.Text);
                SqlComm.Parameters.AddWithValue("@txtPwdLog", txtPwdLog.Text); //gotta make safer later

                int result = (int)SqlComm.ExecuteScalar();

                if (result > 0)
                    MessageBox.Show("Login successful. Welcome " + txtUserLog.Text + "!");
                else
                    MessageBox.Show("This username and password combination does not exist!" +
                        "\nPlease try again.", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }
            /*The Finally block, while optional, is actually obliatory when working with databases
             because it's the block that closes the connection*/
        }
    }
}
