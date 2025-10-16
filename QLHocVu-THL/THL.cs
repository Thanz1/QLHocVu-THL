using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace QLHocVu_THL
{
    public partial class THL : Form
    {
        private string _role;
        private string _fullName;
        private readonly DataAccess db = new DataAccess();
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
        private void HideAllMenuItems()
        {
            lịchHọcToolStripMenuItem.Visible = false;
            lịchThiToolStripMenuItem.Visible = false;
            lịchDạyToolStripMenuItem.Visible = false;
            đăngKýMônToolStripMenuItem.Visible = false;
            xemĐiểmRènLuyệnToolStripMenuItem.Visible = false;
            chấmĐiểmRènLuyệnToolStripMenuItem.Visible = false;
            TaoLopHocToolStripMenuItem.Visible = false;
            thanhToánToolStripMenuItem.Visible = false;
            nhậpĐiểmQuáTrìnhToolStripMenuItem.Visible = false;
            thôngTinCáNhânToolStripMenuItem.Visible = false;
            QLTKToolStripMenuItem.Visible = false;
        }
        private void LoadMenuByRole(string role)
        {

            HideAllMenuItems();
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
                TaoLopHocToolStripMenuItem.Visible = true;
                QLTKToolStripMenuItem.Visible = true;
                thôngTinCáNhânToolStripMenuItem.Visible = true;
            }
            else if (role == "BanChamSoc")
            {
                chấmĐiểmRènLuyệnToolStripMenuItem.Visible = true;
                thôngTinCáNhânToolStripMenuItem.Visible = true;
            }
        }
        private async void THL_Load(object sender, EventArgs e)
        {
            HideAllMenuItems();
            if (!string.IsNullOrEmpty(_role))
            {
                DNToolStripMenuItem.Visible = false;
                DXToolStripMenuItem.Visible = true;
                LoadMenuByRole(_role);
            }
            else
            {
                DNToolStripMenuItem.Visible = true;
                DXToolStripMenuItem.Visible = false;
            }
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://tdmu.edu.vn/");
        }

        private void lịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(db);
            this.Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                _role = login.Role;
                _fullName = login.FullName;
                DNToolStripMenuItem.Visible = false;
                DXToolStripMenuItem.Visible = true;
                LoadMenuByRole(_role);
            }
            this.Show();
        }

        private void DXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _role = null;
            _fullName = null;
            DNToolStripMenuItem.Visible = true;
            DXToolStripMenuItem.Visible = false;
            HideAllMenuItems();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            
        }

        private void THL_Resize(object sender, EventArgs e)
        {
            
        }

        private void TaoLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoLopHoc taoLopHoc = new FormTaoLopHoc();
            this.Hide();
            taoLopHoc.ShowDialog();
            this.Show();
        }

        private void đăngKýMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKyMon dangKyMon = new FormDangKyMon();
            this.Hide();
            dangKyMon.ShowDialog();
            this.Show();
        }
    }
}
