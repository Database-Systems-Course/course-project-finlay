﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_Project
{
    class DBconnectioncs
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Project;Trusted_Connection=True;");
        public SqlCommand cmd = new SqlCommand();

        public DBconnectioncs()
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
            SqlDataAdapter dg = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dg.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
