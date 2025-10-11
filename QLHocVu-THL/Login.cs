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
using System.Configuration;

namespace QLHocVu_THL
{
    public partial class Login : Form
    {
        public string Role { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["QLHOCVUConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Users WHERE UserID = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string role = dr["Role"].ToString();
                    string fullName = dr["Ho"].ToString() + " " + dr["Ten"].ToString();

                    MessageBox.Show("Đăng nhập thành công!");

                    // Mở form chính, truyền role và họ tên
                    THL frmMain = new THL(role, fullName);
                    this.Hide();  // Ẩn form login
                    frmMain.ShowDialog();
                    this.Close(); // Đóng form login khi form chính tắt
                }
                else
                {
                    MessageBox.Show("Sai UserID hoặc Password!");
                }
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
