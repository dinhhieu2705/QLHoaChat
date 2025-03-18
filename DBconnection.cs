using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLHoaChat.Models
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            // Sửa chuỗi kết nối cho phù hợp với máy của bạn
            return new SqlConnection(@"Data Source=DESKTOP-S7RSO8B;Initial Catalog=BTLtrain;Integrated Security=True;");
        }
    }
}
