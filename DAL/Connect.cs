using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Connect
    {
        private const string ConnectionString = "Data Source = MSI\\MYSQL2022; Initial Catalog = qlluong; Integrated Security = True";
        SqlConnection conn = new SqlConnection(ConnectionString);

        public DataTable Load_DL(string sql)
        {
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return dt;
        }
        public void Exvecute(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
