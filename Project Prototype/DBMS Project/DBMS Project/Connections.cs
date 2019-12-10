using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Project
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DBMS_Project
    {
        class Connections
        {
            public SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PBLF4VVJ;Database = Project;Integrated Security=True;User ID=sa;Password=");
            public SqlCommand cmd = new SqlCommand();

            public Connections()
            { }



            public void Inserts(string query) // insert / update / delete
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();


            }

            public DataTable Select(string query) // select query
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                da.Dispose();
                return dt;
            }
        }
    }

}
