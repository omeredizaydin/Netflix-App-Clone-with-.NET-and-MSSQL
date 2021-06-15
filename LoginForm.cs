using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace netflixApp
{
    public partial class LoginForm : Form
    {
        string connectionString;
        SqlConnection sqlConnection;
        SqlDataReader dr;


        public LoginForm()
        {
           
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            /// added some values into another table to try whether it's working or not.
            /*  ProjectConnection newConnection = new ProjectConnection();
              newConnection.ConnectionToday();

              SqlCommand comm = new SqlCommand();
              comm.Connection = ProjectConnection.conn;

              comm.CommandText = "insert into DenemeTable values (@name)";
              comm.Parameters.AddWithValue("name", txtUserName.Text);
              comm.ExecuteNonQuery();

              MessageBox.Show(txtUserName.Text + " added.", "Added");
              txtUserName.Clear();
            */

            string user = txtUserName.Text;
            string phone = txtBxPassword.Text;
            string query = "SELECT * FROM CustomerUserAccount where email=@user AND phone=@password";

            ProjectConnection newConnection = new ProjectConnection();
            newConnection.ConnectionToday();

            SqlCommand comm = new SqlCommand(query, sqlConnection);
            comm.Parameters.AddWithValue("@user", txtUserName.Text);
            comm.Parameters.AddWithValue("@password", txtBxPassword.Text);
            comm.Connection = ProjectConnection.conn;
            dr = comm.ExecuteReader();



            if (dr.Read())
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your email/username or password", "Login Error");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            
            signUpForm.Show();
        }
    }
}
