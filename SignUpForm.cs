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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MP2O6F5;Initial Catalog=db_LoginSQL;Integrated Security=True");

            string query = "SELECT * FROM loginsTable WHERE username = '" + txtUserSign + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

            DataTable datatbl = new DataTable();

            sda.Fill(datatbl);

            if (datatbl.Rows.Count > 0)
                MessageBox.Show("Username has already been registered");
            else
                MessageBox.Show("This username and password combination does not exist!" +
                    "\nPlease try again.", "Error", MessageBoxButtons.OK);
        }

        private void newUser()
        {
            //Exception Handling Statement (try, catch, finally)
            try
            {
                string commString = "INSERT into loginsTable(username, password) VALUES (@txtUserSign, @txtPwdSign)";
                string conString = @"Data Source=DESKTOP-MP2O6F5;Initial Catalog=db_LoginSQL;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(conString))
                {

                    using (SqlCommand comm = new SqlCommand(conString)) {

                        comm.Connection = conn;
                        comm.CommandText = commString;

                        /*A params approach to avoid SQL injection problems and move the job of properly
                         quoting values to the framework code*/
                        comm.Parameters.AddWithValue("@txtPwdSign", txtUserSign.Text);
                        comm.Parameters.AddWithValue("@txtPwdLog", txtPwdSign.Text); //gotta make safer later and do that double check

                        conn.Open();
                    }
                }

            MessageBox.Show("Login successful. Welcome " + txtUserLog.Text + "!");

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
