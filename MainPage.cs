using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace netflixApp
{
    public partial class MainPage : Form
    {
        string connectionString;
        SqlConnection sqlConnection;
        SqlDataReader dr;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            UserList userList = new UserList();
            this.Hide();
            userList.Show();


        }
    }
}
