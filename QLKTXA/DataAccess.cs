using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTXA
{
    internal class DataAccess
    {
        private static string DuongDan = @"Data Source=MINHTHUW\MAY1;Initial Catalog=dbQLKTX;Integrated Security=True;Encrypt=False";
        // phương thức tạo kết nối
        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(DuongDan);
        }

        // phương thức lấy dữ liệu từ database
        public static DataTable GetTable(string sql)
        {
            SqlConnection DuongOng = TaoKetNoi();
            DuongOng.Open();
            SqlDataAdapter MayHut = new SqlDataAdapter(sql, DuongOng);
            DataTable ThungChua = new DataTable();
            MayHut.Fill(ThungChua);
            DuongOng.Close();
            MayHut.Dispose();
            return ThungChua;
        }

        // phương thức thêm - sửa - xóa
        public static void AddEditDelete(string sql)
        {
            SqlConnection DuongOng = new SqlConnection(DuongDan);
            DuongOng.Open();
            SqlCommand cmd = new SqlCommand(sql, DuongOng);
            cmd.ExecuteNonQuery();
            DuongOng.Close();
            cmd.Dispose();

        }
    }


}
