using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHocVu_THL
{
    public class DataAccess
    {
        private readonly string connStr;

        public DataAccess()
        {
            connStr = ConfigurationManager.ConnectionStrings["QLHOCVUConnection"].ConnectionString;
        }

        public UserInfo Logindb(string userID, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT [Role], Ho_Ten FROM Users WHERE UserID = @user AND [Password] = @pass";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", userID);
                    cmd.Parameters.AddWithValue("@pass", password);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                return new UserInfo
                                {
                                    Role = dr["Role"].ToString(),
                                    FullName = dr["Ho_Ten"].ToString()
                                };
                            }
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi CSDL: " + ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}