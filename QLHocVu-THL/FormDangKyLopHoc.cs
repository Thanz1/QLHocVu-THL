using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHocVu_THL
{
    public partial class FormDangKyLopHoc : Form
    {
        DangKyLopHocBUS bus = new DangKyLopHocBUS();
        public FormDangKyLopHoc()
        {
            InitializeComponent();
        }

        private void FormDangKyLopHoc_Load(object sender, EventArgs e)
        {
            // Giả sử load danh sách học kỳ vào ComboBox
            DataTable dtHK = new DataTable();
            dtHK.Columns.Add("MaHK");
            dtHK.Columns.Add("TenHK");

            dtHK.Rows.Add("HK1", "Học kỳ 1");
            dtHK.Rows.Add("HK2", "Học kỳ 2");

            cbHocKy.DataSource = dtHK;
            cbHocKy.DisplayMember = "TenHK";
            cbHocKy.ValueMember = "MaHK";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maDangKy = Guid.NewGuid().ToString().Substring(0, 8);
            string maSV = txtMaSV.Text;
            string maLop = cbLop.SelectedValue.ToString();
            string maHK = cbHocKy.SelectedValue.ToString();

            DangKyLopHocDTO dk = new DangKyLopHocDTO(maDangKy, maSV, maLop, maHK);

            if (bus.DangKy(dk))
                MessageBox.Show("✅ Đăng ký lớp học thành công!");
            else
                MessageBox.Show("❌ Đăng ký thất bại hoặc trùng lớp!");
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHK = cbHocKy.SelectedValue.ToString();
            DataTable dtLop = bus.LayLopTheoHocKy(maHK);

            dgvLop.DataSource = dtLop;
            cbLop.DataSource = dtLop;
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }
    }
}
