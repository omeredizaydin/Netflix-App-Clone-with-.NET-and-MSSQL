using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace netflixApp
{
    public partial class UserList : Form
    {
        string connectionString;
        SqlConnection sqlConnection;
        SqlDataReader dr;
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
         /*   txtBxName.Visible = false;
            txtPhone.Visible = false;*/

            string query = "SELECT CustomerUserAccount.ID, CustomerUserAccount.name, CustomerUserAccount.email, CustomerUserAccount.subscribeID FROM CustomerUserAccount INNER JOIN Subscription ON CustomerUserAccount.subscribeID = Subscription.ID; ";

            ProjectConnection newConnection = new ProjectConnection();
            newConnection.ConnectionToday();

            SqlCommand comm = new SqlCommand(query, sqlConnection);
            comm.Connection = ProjectConnection.conn;

            SqlDataAdapter da = new SqlDataAdapter(comm);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnTotalPaid_Click(object sender, EventArgs e)
        {
            int total = 0;
            int specialTotal = 0;
            int mostSoldSub = 0;
            ArrayList arrEmpID = new ArrayList();
            ArrayList arr = new ArrayList();



            for (int i=1; i<=4; i++)
            {
               // string query = "SELECT COUNT(subscribeID) FROM CustomerUserAccount WHERE subscribeID = 1; ";
                string query = "SELECT COUNT(subscribeID) FROM CustomerUserAccount WHERE subscribeID="+i+";";

                ProjectConnection newConnection = new ProjectConnection();
                newConnection.ConnectionToday();

                SqlCommand comm = new SqlCommand(query, sqlConnection);
                comm.Connection = ProjectConnection.conn;

                if (i == 1)
                { 
                    total += 10 * (int)comm.ExecuteScalar();
                    specialTotal = 10 * (int)comm.ExecuteScalar();
                    mostSoldSub= (int)comm.ExecuteScalar();

                    arrEmpID.Add(specialTotal);
                    arr.Add(mostSoldSub);
                }
                if (i == 2)
                {
                    total += 18 * (int)comm.ExecuteScalar();
                    specialTotal = 18 * (int)comm.ExecuteScalar();
                    mostSoldSub = (int)comm.ExecuteScalar();

                    arrEmpID.Add(specialTotal);
                    arr.Add(mostSoldSub);

                }
                if (i == 3)
                {
                    total += 35 * (int)comm.ExecuteScalar();
                    specialTotal = 35 * (int)comm.ExecuteScalar();
                    mostSoldSub = (int)comm.ExecuteScalar();


                    arrEmpID.Add(specialTotal);
                    arr.Add(mostSoldSub);

                }
                if (i == 4)
                {
                    total += 350 * (int)comm.ExecuteScalar();
                    specialTotal = 350 * (int)comm.ExecuteScalar();
                    mostSoldSub = (int)comm.ExecuteScalar();

                    arrEmpID.Add(specialTotal);
                    arr.Add(mostSoldSub);

                }
            }
            int max = (int)arrEmpID[0];

            for (int i=0; i<arrEmpID.Count; i++)
            {
                if ((int)arrEmpID[i] > max)
                    max = (int)arrEmpID[i];

            }

            int maxMostSold = (int)arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                if ((int)arr[i] > maxMostSold)
                    maxMostSold = (int)arr[i];

            }

            int divide = max / mostSoldSub;
            String subType = "";
            if (divide == 10) subType = "7 Days";
            if (divide == 18) subType = "14 Days";
            if (divide == 35) subType = "30 Days (A month)";
            if (divide == 350) subType = "365 Days (A year)";
            lblTotalPaid.Text = "Total paid: " + total+"\n"+
                                "Most paid sub cost: "+max+"\n"+
                                "Count of most paid sub: "+maxMostSold+"\n"+
                                "Type of sub: "+subType;
           
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CustomerUserAccount SET name=@name, email=@email where ID=" + txtID.Text + "";
            //string query= "UPDATE CustomerUserAccount SET name=@name, email=@email WHERE name='Ahmet Opak' and email='opak@eskisehir.edu.tr'"

            ProjectConnection newConnection = new ProjectConnection();
            newConnection.ConnectionToday();

            SqlCommand comm = new SqlCommand(query, sqlConnection);
            comm.Connection = ProjectConnection.conn;
            comm.Parameters.AddWithValue("name",txtBxName.Text);
            comm.Parameters.AddWithValue("email", txtPhone.Text);//not phone don't forget it;

            if (comm.ExecuteNonQuery() > 0) MessageBox.Show("Succesfull");
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtBxName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE CustomerUserAccount SET name=@name, email=@email where ID=" + txtID.Text + "";
            string query= "delete from CustomerUserAccount where ID=" + txtID.Text + "";

            ProjectConnection newConnection = new ProjectConnection();
            newConnection.ConnectionToday();

            SqlCommand comm = new SqlCommand(query, sqlConnection);
            comm.Connection = ProjectConnection.conn;
                

            if (comm.ExecuteNonQuery() > 0) MessageBox.Show("Succesfull");
        }
    }
}
