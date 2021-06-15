using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace netflixApp
{
    //OOP
    class ProjectConnection
    { 
        string connectionString=" Data Source=DESKTOP-N1FJBSD;Initial Catalog = DBMS; User ID = user; Password=12345";
        public static SqlConnection conn = null;
        
        public void ConnectionToday()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }
    }
}
