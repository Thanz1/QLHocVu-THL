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
    public partial class THL : Form
    {
        private string _role;
        private string _fullName;
        public THL(string role, string fullName)
        {
            InitializeComponent();
            _role = role;
            _fullName = fullName;
        }
        public THL()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();   // Mở form đăng nhập
            if (login.ShowDialog() == DialogResult.OK)
            {
                string role = login.Role;   // Lấy role từ form Login

                // Xóa menu cũ
                menuStrip1.Items.Clear();

                // Tạo menu gốc "Đăng xuất"
                ToolStripMenuItem logoutItem = new ToolStripMenuItem("Đăng xuất");
                logoutItem.Click += đăngXuấtToolStripMenuItem_Click;
                menuStrip1.Items.Add(logoutItem);

                //  Gọi hàm chỉ với role
                LoadMenuByRole(role);
            }
        }
        private void LoadMenuByRole(string role)
        {
            if (role == "SinhVien")
            {
                lịchHọcToolStripMenuItem.Visible = true;
                lịchThiToolStripMenuItem.Visible = true;
                đăngKýMônToolStripMenuItem.Visible = true;
                xemĐiểmRènLuyệnToolStripMenuItem.Visible = true;
                thanhToánToolStripMenuItem.Visible = true;
                thôngTinCáNhânToolStripMenuItem.Visible = true;
            }
            else if (role == "GiangVien")
            {
                lịchDạyToolStripMenuItem.Visible = true;
                nhậpĐiểmQuáTrìnhToolStripMenuItem.Visible = true;
                thôngTinCáNhânToolStripMenuItem.Visible = true;
            }
            else if (role == "VienDaoTao")
            {
                tạoLớpHọcToolStripMenuItem.Visible = true;
                thôngTinCáNhânToolStripMenuItem.Visible = true;
            }
            else if (role == "BanChamSoc")
            {
                chấmĐiểmRènLuyệnToolStripMenuItem.Visible = true;
                thôngTinCáNhânToolStripMenuItem.Visible = true;
            }
        }
        private void AddMenuItem(string text, EventHandler onClick)
        {
            var item = new ToolStripMenuItem(text);
            item.Click += onClick;
            menuStrip1.Items.Add(item);
        }
        private void HideAllMenuItems()
        {
            lịchHọcToolStripMenuItem.Visible = false;
            lịchThiToolStripMenuItem.Visible = false;
            lịchDạyToolStripMenuItem.Visible = false;
            đăngKýMônToolStripMenuItem.Visible = false;
            xemĐiểmRènLuyệnToolStripMenuItem.Visible = false;
            chấmĐiểmRènLuyệnToolStripMenuItem.Visible = false;
            tạoLớpHọcToolStripMenuItem.Visible = false;
            thanhToánToolStripMenuItem.Visible = false;
            nhậpĐiểmQuáTrìnhToolStripMenuItem.Visible = false;
            thôngTinCáNhânToolStripMenuItem.Visible = false;
        }




        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Items.Clear();
            menuStrip1.Items.Add("Đăng nhập", null, đăngNhậpToolStripMenuItem_Click);
        }

        private void THL_Load(object sender, EventArgs e)
        {
     
            // Ẩn tất cả trước
            HideAllMenuItems();

            // Nếu có role => đã đăng nhập
            if (!string.IsNullOrEmpty(_role))
            {
                // Đã đăng nhập
                đăngNhậpToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = true;

                // Hiện menu theo role
                LoadMenuByRole(_role);
            }
            else
            {
                // Chưa đăng nhập
                đăngNhậpToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = false;
            }
        }

        private void lịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
