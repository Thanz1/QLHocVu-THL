using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHocVu_THL
{
    internal class DangKyLopHocDTO
    {
        public string MaDangKy { get; set; }
        public string MaSV { get; set; }
        public string MaLop { get; set; }
        public string MaHK { get; set; }

        public DangKyLopHocDTO() { }

        public DangKyLopHocDTO(string maDangKy, string maSV, string maLop, string maHK)
        {
            MaDangKy = maDangKy;
            MaSV = maSV;
            MaLop = maLop;
            MaHK = maHK;
        }
    }
}
