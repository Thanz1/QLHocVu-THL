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
        private readonly DataAccess db = new DataAccess();
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
                dgvMonHoc.DataSource = db.GetMonHoc();
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
                selectedMaMH = row.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = row.Cells["TenMH"].Value.ToString();
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
                // Tự sinh mã môn học, ví dụ MH + số tăng tự động (dựa theo số lượng hiện có)
                var dt = db.GetMonHoc();
                int count = dt.Rows.Count + 1;
                string maMH = "MH" + count.ToString("D3");

                string sql = "INSERT INTO [Môn học] (MaMH, TenMH) VALUES (@MaMH, @TenMH)";
                db.ExecuteNonQuery(sql, new System.Data.SqlClient.SqlParameter("@MaMH", maMH),
                                         new System.Data.SqlClient.SqlParameter("@TenMH", tenMH));

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
                string sql = "UPDATE [Môn học] SET TenMH = @TenMH WHERE MaMH = @MaMH";
                db.ExecuteNonQuery(sql,
                    new System.Data.SqlClient.SqlParameter("@TenMH", tenMH),
                    new System.Data.SqlClient.SqlParameter("@MaMH", selectedMaMH));

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
                string sql = "DELETE FROM [Môn học] WHERE MaMH = @MaMH";
                db.ExecuteNonQuery(sql, new System.Data.SqlClient.SqlParameter("@MaMH", selectedMaMH));

                MessageBox.Show("Xóa môn học thành công!");
                txtTenMH.Clear();
                selectedMaMH = null;
                LoadMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa môn học: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
