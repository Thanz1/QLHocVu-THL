using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocVu_THL.PhuongThuc
{
    public class MonHocBLL
    {
        private readonly DataAccess db = new DataAccess();

        // Lấy danh sách môn học
        public DataTable GetDanhSachMonHoc()
        {
            return db.GetMonHoc(); // Giả định db.GetMonHoc() trả về DataTable
        }

        // Tự sinh mã môn học (Logic nghiệp vụ)
        private string GenerateMaMH()
        {
            var dt = db.GetMonHoc();
            int count = dt.Rows.Count + 1;
            // D3 đảm bảo mã có 3 chữ số (001, 010, 100...)
            return "MH" + count.ToString("D3");
        }

        // Thêm môn học
        public void ThemMonHoc(string tenMH)
        {
            // Kiểm tra tên môn học đã được thực hiện ở UI, nhưng có thể thêm ở đây

            string maMH = GenerateMaMH();
            string sql = "INSERT INTO [Môn học] (MaMH, TenMH) VALUES (@MaMH, @TenMH)";

            // Giả định db.ExecuteNonQuery có thể nhận mảng SqlParameter
            db.ExecuteNonQuery(sql,
                new SqlParameter("@MaMH", maMH),
                new SqlParameter("@TenMH", tenMH));
        }

        // Sửa môn học
        public void SuaMonHoc(string maMH, string tenMH)
        {
            // Kiểm tra tính hợp lệ của dữ liệu đã được thực hiện ở UI

            string sql = "UPDATE [Môn học] SET TenMH = @TenMH WHERE MaMH = @MaMH";
            db.ExecuteNonQuery(sql,
                new SqlParameter("@TenMH", tenMH),
                new SqlParameter("@MaMH", maMH));
        }

        // Xóa môn học
        public void XoaMonHoc(string maMH)
        {
            // Kiểm tra ràng buộc khóa ngoại (Foreign Key)
            // Nếu có, cần xử lý lỗi hoặc xóa các bản ghi liên quan trước.

            string sql = "DELETE FROM [Môn học] WHERE MaMH = @MaMH";
            db.ExecuteNonQuery(sql, new SqlParameter("@MaMH", maMH));
        }
    }
}
