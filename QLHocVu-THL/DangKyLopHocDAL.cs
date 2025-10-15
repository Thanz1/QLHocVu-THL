using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLHocVu_THL;


namespace QLHocVu_THL
{
    internal class DangKyLopHocDAL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLHOCVU;Integrated Security=True";

        public bool DangKyLopHoc(DangKyLopHocDTO dk)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DangKyLopHoc (MaDangKy, MaSV, MaLop, MaHK) VALUES (@MaDangKy, @MaSV, @MaLop, @MaHK)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDangKy", dk.MaDangKy);
                cmd.Parameters.AddWithValue("@MaSV", dk.MaSV);
                cmd.Parameters.AddWithValue("@MaLop", dk.MaLop);
                cmd.Parameters.AddWithValue("@MaHK", dk.MaHK);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public DataTable LayDanhSachLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaLop, TenLop, MaHK FROM Lop";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 🆕 Lấy lớp theo học kỳ
        public DataTable LayLopTheoHocKy(string maHK)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaLop, TenLop FROM Lop WHERE MaHK = @MaHK";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaHK", maHK);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 🆕 Kiểm tra trùng đăng ký
        public bool KiemTraTrungDangKy(string maSV, string maLop, string maHK)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM DangKyLopHoc WHERE MaSV = @MaSV AND MaLop = @MaLop AND MaHK = @MaHK";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@MaHK", maHK);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
