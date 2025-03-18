using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHoaChat.Models;

namespace QLHoaChat
{
    class DBadapter
    {
        public DBadapter()
        {

        }
        SqlDataAdapter da;
        SqlCommand cmd;
        public DataTable Table(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public void Command(string sql) //them sua xoa  
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
