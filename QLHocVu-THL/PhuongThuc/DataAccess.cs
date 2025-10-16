using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHocVu_THL
{
    public class DataAccess
    {
        private readonly string connStr;

        public DataAccess()
        {
            connStr = ConfigurationManager.ConnectionStrings["QLHOCVUConnection"].ConnectionString;
        }

        public UserInfo Logindb(string userID, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT [Role], Ho_Ten FROM Users WHERE UserID = @user AND [Password] = @pass";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", userID);
                    cmd.Parameters.AddWithValue("@pass", password);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                return new UserInfo
                                {
                                    Role = dr["Role"].ToString(),
                                    FullName = dr["Ho_Ten"].ToString()
                                };
                            }
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi CSDL: " + ex.Message);
                        return null;
                    }
                }
            }
        }
        public DataTable GetMonHoc()
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand("SELECT MaMH, TenMH FROM [Môn học]", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void TaoLop(string maLop, string tenLop, string maGV, string maHK, string maMH, int soLuong)
        {
            string sql = @"INSERT INTO [Lớp] ([Mã Lớp],[Tên Lớp],[MaGV],[MaHK],[Mã MH],[SoLuongSV],[Siso],[Trạng thái])
                           VALUES (@MaLop,@TenLop,@MaGV,@MaHK,@MaMH,@SoLuong,0,'Mở')";
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                cmd.Parameters.AddWithValue("@MaGV", maGV ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaHK", maHK ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaMH", maMH ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAllLop()
        {
            string sql = @"SELECT [Mã Lớp] AS MaLop, [Tên Lớp] AS TenLop, [Mã MH] AS MaMH, SoLuongSV, Siso, [Trạng thái] 
                           FROM [Lớp]";
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public int GetRegisteredCount(string maLop)
        {
            string sql = "SELECT COUNT(*) FROM [Đăng ký lớp học] WHERE [Mã Lớp] = @MaLop";
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public (int SoLuongSV, int Siso) GetLopCapacityAndSiso(string maLop)
        {
            string sql = "SELECT SoLuongSV, Siso FROM [Lớp] WHERE [Mã Lớp] = @MaLop";
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        int s = rdr["SoLuongSV"] != DBNull.Value ? Convert.ToInt32(rdr["SoLuongSV"]) : 0;
                        int si = rdr["Siso"] != DBNull.Value ? Convert.ToInt32(rdr["Siso"]) : 0;
                        return (s, si);
                    }
                }
            }
            return (0, 0);
        }
        public bool DangKy(string maSV, string maLop)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Transaction = tran;

                    // 1. lấy SoLuongSV, Siso
                    cmd.CommandText = "SELECT SoLuongSV FROM [Lớp] WHERE [Mã Lớp] = @MaLop";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    object o = cmd.ExecuteScalar();
                    if (o == null)
                    {
                        tran.Rollback();
                        return false;
                    }
                    int capacity = o != DBNull.Value ? Convert.ToInt32(o) : 0;

                    // 2. đếm đăng ký hiện tại
                    cmd.CommandText = "SELECT COUNT(*) FROM [Đăng ký lớp học] WHERE [Mã Lớp] = @MaLop";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    int current = Convert.ToInt32(cmd.ExecuteScalar());

                    if (current >= capacity)
                    {
                        tran.Rollback();
                        return false; // đầy
                    }

                    // 3. kiểm tra sinh viên đã đăng ký cùng lớp chưa
                    cmd.CommandText = "SELECT COUNT(*) FROM [Đăng ký lớp học] WHERE MaSV = @MaSV AND [Mã Lớp] = @MaLop";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    int existed = Convert.ToInt32(cmd.ExecuteScalar());
                    if (existed > 0)
                    {
                        tran.Rollback();
                        return false; // đã đăng ký
                    }

                    // 4. insert vào [Đăng ký lớp học]
                    cmd.CommandText = "INSERT INTO [Đăng ký lớp học] (MaSV, [Mã Lớp]) VALUES (@MaSV, @MaLop)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.ExecuteNonQuery();

                    // 5. cập nhật Siso trong [Lớp] (tùy script bạn có Siso cột)
                    cmd.CommandText = "UPDATE [Lớp] SET Siso = ISNULL(Siso,0) + 1 WHERE [Mã Lớp] = @MaLop";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
            }
        }
        public bool HuyDangKy(string maSV, string maLop)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Transaction = tran;

                    // Xóa đăng ký
                    cmd.CommandText = "DELETE FROM [Đăng ký lớp học] WHERE MaSV = @MaSV AND [Mã Lớp] = @MaLop";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                    {
                        tran.Rollback();
                        return false;
                    }

                    // Giảm Siso
                    cmd.CommandText = "UPDATE [Lớp] SET Siso = CASE WHEN Siso IS NULL THEN 0 ELSE Siso-1 END WHERE [Mã Lớp] = @MaLop";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    cmd.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
            }
        }
        public DataTable GetAvailableLop()
        {
            string sql = @"
                SELECT L.[Mã Lớp] AS MaLop, L.[Tên Lớp] AS TenLop, L.[Mã MH] AS MaMH, L.SoLuongSV,
                       ISNULL((SELECT COUNT(*) FROM [Đăng ký lớp học] D WHERE D.[Mã Lớp] = L.[Mã Lớp]),0) AS DangKy
                FROM [Lớp] L
                WHERE ISNULL(L.SoLuongSV,0) > ISNULL((SELECT COUNT(*) FROM [Đăng ký lớp học] D WHERE D.[Mã Lớp] = L.[Mã Lớp]),0)";
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetLopDaDangKy(string maSV)
        {
            string sql = @"SELECT D.[Mã Lớp] AS MaLop, L.[Tên Lớp] AS TenLop, L.[Mã MH] AS MaMH
                           FROM [Đăng ký lớp học] D
                           JOIN [Lớp] L ON L.[Mã Lớp] = D.[Mã Lớp]
                           WHERE D.MaSV = @MaSV";
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetGV()
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand("SELECT MaGV, BoMon, SDT, NamSinh, Email, GioiTinh, HoTen, HocVi, V.[Tên Viện] FROM [Giảng Viên] GV left join [Viện] V on GV.[Mã Viện] = V.[Mã Viện]", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetHK()
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand("SELECT [Mã HK], [Tên HK], [Năm] FROM [Học Kỳ]", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetPhong()
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand("SELECT [MaPhong], [TenPhong], [SucChua] FROM [PhongHoc]", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void ExecuteNonQuery(string sql, params SqlParameter[] prms)
        {
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (prms != null)
                    cmd.Parameters.AddRange(prms);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}