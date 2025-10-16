using QLHocVu_THL.PhuongThuc;
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
    public partial class FormDangKyMon : Form
    {
        private readonly DataAccess db = new DataAccess();
        private RegistrationWindow window;
        public FormDangKyMon()
        {
            InitializeComponent();
        }

        private void FormDangKyMon_Load(object sender, EventArgs e)
        {
            window = RegistrationWindow.Load();
            LoadAvailable();
            LoadDaDangKy();
            ShowWindowInfo();
        }
        private void ShowWindowInfo()
        {
            if (window == null)
                lblWindowInfo.Text = "Đăng ký: chưa được mở.";
            else
                lblWindowInfo.Text = $"Đăng ký mở: {window.Start:G} → {window.End:G}";
        }
        private void LoadAvailable()
        {
            // load danh sach lop con cho
            dgvLopConCho.DataSource = db.GetAvailableLop();
            dgvLopConCho.AutoResizeColumns();
        }
        private void LoadDaDangKy()
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                dgvDaDangKy.DataSource = null;
                return;
            }
            dgvDaDangKy.DataSource = db.GetLopDaDangKy(maSV);
            dgvDaDangKy.AutoResizeColumns();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Nhập MaSV trước khi đăng ký.");
                return;
            }

            // kiểm tra window
            if (window == null || !window.IsOpenNow())
            {
                MessageBox.Show("Hiện tại không trong khoảng thời gian đăng ký.");
                return;
            }

            if (dgvLopConCho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 lớp để đăng ký.");
                return;
            }

            string maLop = dgvLopConCho.SelectedRows[0].Cells["MaLop"].Value.ToString();

            bool ok = db.DangKy(maSV, maLop);
            if (ok)
            {
                MessageBox.Show("Đăng ký thành công.");
                LoadAvailable();
                LoadDaDangKy();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại — có thể lớp đã đủ hoặc bạn đã đăng ký trước đó.");
                LoadAvailable();
                LoadDaDangKy();
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Nhập MaSV trước khi hủy đăng ký.");
                return;
            }

            if (dgvDaDangKy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 dòng trong danh sách đã đăng ký để hủy.");
                return;
            }

            string maLop = dgvDaDangKy.SelectedRows[0].Cells["MaLop"].Value.ToString();

            bool ok = db.HuyDangKy(maSV, maLop);
            if (ok)
            {
                MessageBox.Show("Hủy đăng ký thành công.");
                LoadAvailable();
                LoadDaDangKy();
            }
            else
            {
                MessageBox.Show("Hủy đăng ký thất bại.");
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            LoadDaDangKy();
        }
    }
}
