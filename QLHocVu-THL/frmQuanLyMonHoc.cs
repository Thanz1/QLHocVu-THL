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
    public partial class frmQuanLyMonHoc : Form
    {
        private readonly MonHocBLL monHocBLL = new MonHocBLL();
        private string selectedMaMH = null;
        public frmQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            dgvMonHoc.AutoResizeColumns();
        }
        private void LoadMonHoc()
        {
            try
            {
                // Gọi BLL để lấy dữ liệu
                dgvMonHoc.DataSource = monHocBLL.GetDanhSachMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu môn học: " + ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadMonHoc();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMonHoc.Rows[e.RowIndex];
                // Đảm bảo cột MaMH và TenMH tồn tại trong DataSource
                selectedMaMH = row.Cells["MaMH"].Value?.ToString();
                txtTenMH.Text = row.Cells["TenMH"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMH = txtTenMH.Text.Trim();
            if (string.IsNullOrEmpty(tenMH))
            {
                MessageBox.Show("Vui lòng nhập tên môn học.");
                return;
            }

            try
            {
                // Gọi BLL để thực hiện thêm
                monHocBLL.ThemMonHoc(tenMH);

                MessageBox.Show("Thêm môn học thành công!");
                txtTenMH.Clear();
                LoadMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaMH == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa.");
                return;
            }

            string tenMH = txtTenMH.Text.Trim();
            if (string.IsNullOrEmpty(tenMH))
            {
                MessageBox.Show("Tên môn học không được để trống.");
                return;
            }

            try
            {
                // Gọi BLL để thực hiện sửa
                monHocBLL.SuaMonHoc(selectedMaMH, tenMH);

                MessageBox.Show("Sửa môn học thành công!");
                txtTenMH.Clear();
                selectedMaMH = null;
                LoadMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa môn học: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaMH == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                // Gọi BLL để thực hiện xóa
                monHocBLL.XoaMonHoc(selectedMaMH);

                MessageBox.Show("Xóa môn học thành công!");
                txtTenMH.Clear();
                selectedMaMH = null;
                LoadMonHoc();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ràng buộc khóa ngoại
                if (ex.Message.Contains("REFERENCE constraint"))
                {
                    MessageBox.Show("Lỗi: Không thể xóa môn học này vì đã có lớp học sử dụng. Vui lòng xóa các lớp học liên quan trước.");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa môn học: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
