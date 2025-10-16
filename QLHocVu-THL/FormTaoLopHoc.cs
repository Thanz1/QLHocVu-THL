using QLHocVu_THL.PhuongThuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHocVu_THL
{
    public partial class FormTaoLopHoc : Form
    {
        private readonly DataAccess db = new DataAccess();
        private RegistrationWindow window;
        public FormTaoLopHoc()
        {
            InitializeComponent();

        }

        private void FormTaoLopHoc_Load(object sender, EventArgs e)
        {
            comboboxTaoLopHoc_Load();
        }
        private void comboboxTaoLopHoc_Load()
        {
            var dt = db.GetMonHoc();
            cboMonHoc.DisplayMember = "TenMH";
            cboMonHoc.ValueMember = "MaMH";
            cboMonHoc.DataSource = dt;

            // default soLuong = 60
            numSoLuong.Value = 60;

            LoadGridLop();

            // load registration window setting
            window = RegistrationWindow.Load();
            ShowWindowInfo();
        }
        private void ShowWindowInfo()
        {
            if (window == null)
            {
                lblWindowInfo.Text = "Chưa set thời gian đăng ký.";
            }
            else
            {
                lblWindowInfo.Text = $"Đăng ký: {window.Start:G} → {window.End:G}";
            }
        }
        private void LoadGridLop()
        {
            dgvLopDaTao.DataSource = db.GetAllLop();
            dgvLopDaTao.AutoResizeColumns();
        }

        private void btnTaoLop_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string maMH = cboMonHoc.SelectedValue?.ToString();
            int sl = (int)numSoLuong.Value;

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maMH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp, Tên lớp, chọn Môn học.");
                return;
            }

            try
            {
                // MaGV và MaHK để null tạm thời; bạn có thể cho chọn nếu muốn
                db.TaoLop(maLop, tenLop, null, null, maMH, sl);
                MessageBox.Show("Tạo lớp thành công.");
                LoadGridLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo lớp: " + ex.Message);
            }
        }

        private void btnSetWindow_Click(object sender, EventArgs e)
        {
            var start = dtpStart.Value;
            var end = dtpEnd.Value;
            if (end < start)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu.");
                return;
            }
            window = new RegistrationWindow { Start = start, End = end };
            window.Save();
            ShowWindowInfo();
            MessageBox.Show("Thiết lập thời gian đăng ký đã lưu.");
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            frmQuanLyMonHoc frm = new frmQuanLyMonHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            comboboxTaoLopHoc_Load();
        }

        private void btnChonGV_Click(object sender, EventArgs e)
        {
            dgvLopDaTao.DataSource = db.GetGV();
        }

        private void dgvLopDaTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLopDaTao.Columns.Contains("MaGV") && e.RowIndex >= 0)
            {
                txtMaGV.Text = dgvLopDaTao.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
            }
            else if (dgvLopDaTao.Columns.Contains("Mã HK") && e.RowIndex >= 0)
            {
                txtMaHK.Text = dgvLopDaTao.Rows[e.RowIndex].Cells["Mã HK"].Value.ToString();
            }
            else if (dgvLopDaTao.Columns.Contains("MaPhong") && e.RowIndex >= 0)
            {
                txtMaPhong.Text = dgvLopDaTao.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            }
        }

        private void btnChonHK_Click(object sender, EventArgs e)
        {
            dgvLopDaTao.DataSource = db.GetHK();
        }

        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            dgvLopDaTao.DataSource = db.GetPhong();
        }

        private void btnLoadLop_Click(object sender, EventArgs e)
        {
            LoadGridLop();
        }
    }
}
