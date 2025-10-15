using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHocVu_THL
{
    internal class DangKyLopHocBUS
    {
        DangKyLopHocDAL dal = new DangKyLopHocDAL();

        public bool DangKy(DangKyLopHocDTO dk)
        {
            if (string.IsNullOrEmpty(dk.MaSV) || string.IsNullOrEmpty(dk.MaLop) || string.IsNullOrEmpty(dk.MaHK))
                return false;

            // 🧩 Kiểm tra trùng trước khi thêm
            if (dal.KiemTraTrungDangKy(dk.MaSV, dk.MaLop, dk.MaHK))
            {
                MessageBox.Show("Sinh viên này đã đăng ký lớp này trong học kỳ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return dal.DangKyLopHoc(dk);
        }

        public DataTable LayDanhSachLop()
        {
            return dal.LayDanhSachLop();
        }

        // 🧩 Lấy lớp theo học kỳ
        public DataTable LayLopTheoHocKy(string maHK)
        {
            return dal.LayLopTheoHocKy(maHK);
        }

    }
}
