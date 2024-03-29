﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Configuration;

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
            //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MP2O6F5;Initial Catalog=db_LoginSQL;Integrated Security=True");


            //preferred way below. This is acheived manipulating the app.config
            SqlConnection sqlCon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString);
            string query = "SELECT * FROM loginsTable WHERE username = '" + txtUserLog + "' and password='" + txtPwdLog + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

            DataTable datatbl = new DataTable();

            sda.Fill(datatbl);

            if (datatbl.Rows.Count == 1)
                MessageBox.Show("Login successful. Welcome " + txtUserLog.Text + "!");
            else
                MessageBox.Show("This username and password combination does not exist!" +
                    "\nPlease try again.", "Error", MessageBoxButtons.OK);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide(); ///hides current window
            SignUpForm suf = new SignUpForm(); //opens other new window
            suf.ShowDialog(); //shows aforementioned window
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //dozens of mistakes, this doesn't seem to want to work...
        }
    }
}
