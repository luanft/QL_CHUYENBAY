using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
   public  class DataConnection
    {

        private static DataConnection instance;
        string strConnection;
        SqlConnection _con;

        private DataConnection()
        { }

        public static DataConnection getInstance()
        {
            if (instance == null)
                instance = new DataConnection();
            return instance;
        }

        public void SetupConnection(string path, string databaseName)
        {
            strConnection = @"Data Source=" + path + "; Initial Catalog =" + databaseName + ";Integrated Security=True";
            _con = new SqlConnection(strConnection);
        }

        public void SetupConnection(string path)
        {
            strConnection = @"Data Source=" + path + ";Integrated Security=True";
            _con = new SqlConnection(strConnection);
        }

        private SqlConnection OpenConnnection()
        {
            if (_con.State != System.Data.ConnectionState.Open)
            {
                _con.Open();
            }
            return _con;
        }
        //ghi xuống database
        public DataTable Read(string sql_query)
        {
            //mo ket noi
            SqlConnection sql_con = OpenConnnection();
            DataTable data_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_query, sql_con);
            adapter.Fill(data_table);
            adapter.Dispose();
            return data_table;
        }
        public DataSet Read(string sql_query, string table_name)
        {
            SqlConnection sql_con = OpenConnnection();
            DataSet data_set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_query, sql_con);
            adapter.Fill(data_set, table_name);
            adapter.Dispose();
            return data_set;
        }
        public void Write(string sql_query)
        {
            SqlConnection sql_con = OpenConnnection();
            SqlCommand sql_cmd = new SqlCommand(sql_query, sql_con);
            sql_cmd.ExecuteNonQuery();
            sql_cmd.Dispose();
        }
    }
}
