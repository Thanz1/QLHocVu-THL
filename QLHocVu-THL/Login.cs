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
        private readonly DataAccess db;
        public string Role { get; private set; }
        public string FullName { get; private set; }
        public Login(DataAccess dataAccess)
        {
            InitializeComponent();
            db = dataAccess;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            UserInfo user = db.Logindb(userID, password);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Role = user.Role;
                FullName = user.FullName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai UserID hoặc Password!");
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
