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
    public partial class SeePlanForm : UserControl
    {
        int subscribeID;
        SqlConnection sqlConnection;
        SqlDataReader dr;
        public SeePlanForm()
        {
            InitializeComponent();
        }

        private void SeePlanForm_Load(object sender, EventArgs e)
        {
            lblNameSurname.Visible = false;
            lblEmail.Visible = false;
            lblPhone.Visible = false;
            txtBxEmail.Visible = false;
            txtBxNameSurname.Visible = false;
            txtBxPhone.Visible = false;
            btnConfirm.Visible = false;
            lblPayment.Visible = false;
            comboBox1.Visible = false;
        }

        private void btnTemel_Click(object sender, EventArgs e)
        {
            subscribeID = 1;
            lblNameSurname.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            txtBxEmail.Visible = true;
            txtBxNameSurname.Visible = true;
            txtBxPhone.Visible = true;
            btnConfirm.Visible = true;
            lblPayment.Visible = true;
            comboBox1.Visible = true;

            lblTemel.ForeColor = System.Drawing.Color.Red;
            lblTemel1.ForeColor = System.Drawing.Color.Red;
            lblTemel2.ForeColor = System.Drawing.Color.Red;

            lblStandart.ForeColor = System.Drawing.Color.Black;
            lblStandart1.ForeColor = System.Drawing.Color.Black;
            lblStandart2.ForeColor = System.Drawing.Color.Black;

            lblOzel.ForeColor = System.Drawing.Color.Black;
            lblOzel1.ForeColor = System.Drawing.Color.Black;
            lblOzel2.ForeColor = System.Drawing.Color.Black;

            lblVIP.ForeColor = System.Drawing.Color.Black;
            lblVIP1.ForeColor = System.Drawing.Color.Black;
            lblVIP2.ForeColor = System.Drawing.Color.Black;






        }

        private void btnStandart_Click(object sender, EventArgs e)
        {
            subscribeID = 2;
            lblNameSurname.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            txtBxEmail.Visible = true;
            txtBxNameSurname.Visible = true;
            txtBxPhone.Visible = true;
            btnConfirm.Visible = true;
            lblPayment.Visible = true;
            comboBox1.Visible = true;

            lblTemel.ForeColor = System.Drawing.Color.Black;
            lblTemel1.ForeColor = System.Drawing.Color.Black;
            lblTemel2.ForeColor = System.Drawing.Color.Black;

            lblStandart.ForeColor = System.Drawing.Color.Red;
            lblStandart1.ForeColor = System.Drawing.Color.Red;
            lblStandart2.ForeColor = System.Drawing.Color.Red;

            lblOzel.ForeColor = System.Drawing.Color.Black;
            lblOzel1.ForeColor = System.Drawing.Color.Black;
            lblOzel2.ForeColor = System.Drawing.Color.Black;

            lblVIP.ForeColor = System.Drawing.Color.Black;
            lblVIP1.ForeColor = System.Drawing.Color.Black;
            lblVIP2.ForeColor = System.Drawing.Color.Black;
        }

        private void btnOzel_Click(object sender, EventArgs e)
        {
            subscribeID = 3;
            lblNameSurname.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            txtBxEmail.Visible = true;
            txtBxNameSurname.Visible = true;
            txtBxPhone.Visible = true;
            btnConfirm.Visible = true;
            lblPayment.Visible = true;
            comboBox1.Visible = true;

            lblTemel.ForeColor = System.Drawing.Color.Black;
            lblTemel1.ForeColor = System.Drawing.Color.Black;
            lblTemel2.ForeColor = System.Drawing.Color.Black;

            lblStandart.ForeColor = System.Drawing.Color.Black;
            lblStandart1.ForeColor = System.Drawing.Color.Black;
            lblStandart2.ForeColor = System.Drawing.Color.Black;

            lblOzel.ForeColor = System.Drawing.Color.Red;
            lblOzel1.ForeColor = System.Drawing.Color.Red;
            lblOzel2.ForeColor = System.Drawing.Color.Red;

            lblVIP.ForeColor = System.Drawing.Color.Black;
            lblVIP1.ForeColor = System.Drawing.Color.Black;
            lblVIP2.ForeColor = System.Drawing.Color.Black;
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            subscribeID = 4;
            lblNameSurname.Visible = true;
            lblEmail.Visible = true;
            lblPhone.Visible = true;
            txtBxEmail.Visible = true;
            txtBxNameSurname.Visible = true;
            txtBxPhone.Visible = true;
            btnConfirm.Visible = true;
            lblPayment.Visible = true;
            comboBox1.Visible = true;


            lblTemel.ForeColor = System.Drawing.Color.Black;
            lblTemel1.ForeColor = System.Drawing.Color.Black;
            lblTemel2.ForeColor = System.Drawing.Color.Black;

            lblStandart.ForeColor = System.Drawing.Color.Black;
            lblStandart1.ForeColor = System.Drawing.Color.Black;
            lblStandart2.ForeColor = System.Drawing.Color.Black;

            lblOzel.ForeColor = System.Drawing.Color.Black;
            lblOzel1.ForeColor = System.Drawing.Color.Black;
            lblOzel2.ForeColor = System.Drawing.Color.Black;

            lblVIP.ForeColor = System.Drawing.Color.Red;
            lblVIP1.ForeColor = System.Drawing.Color.Red;
            lblVIP2.ForeColor = System.Drawing.Color.Red;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CustomerUserAccount (name,email,phone,subscribeID) VALUES(@name,@email,@phone,@subscribeID)";

            ProjectConnection newConnection = new ProjectConnection();
            newConnection.ConnectionToday();


            SqlCommand comm = new SqlCommand(query, sqlConnection);



            comm.Parameters.AddWithValue("@name", txtBxNameSurname.Text);
            comm.Parameters.AddWithValue("@email", txtBxEmail.Text);
            comm.Parameters.AddWithValue("@phone", txtBxPhone.Text);
            comm.Parameters.AddWithValue("@subscribeID", subscribeID);

            comm.Connection = ProjectConnection.conn;

            // comm.ExecuteNonQuery();
            try
            {
                if (comm.ExecuteNonQuery() > 0)
                    MessageBox.Show("Succesfully added!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error has occured", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,ToString());
            }

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

          
        }
    }
}
