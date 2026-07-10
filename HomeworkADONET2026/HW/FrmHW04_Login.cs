using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HomeworkADONET2026.HW
{
    public partial class FrmHW04_Login : Form
    {
        public FrmHW04_Login()
        {
            InitializeComponent();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            // 請參考 dbScript/[0-2]_*.sql 腳本建立指定資料庫
            //
            // 實際應用要考量:
            // TODO 1 密碼加鹽雜湊, 選擇足夠安全演算法
            // TODO 2 帳號字串不能重複

            DialogResult dialogResult = MessageBox.Show("確定使用以上輸入的帳密資訊建立帳號?", "確認註冊?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            if (!checkTextboxUserInfo()) return;

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.MyMemberConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string userName = this.textboxUsername.Text;
                    string userPassword = this.textboxPassword.Text;

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"Insert into [MyMemberSchema].[MyMember] (userName, userPassword) values (@userName, @userPassword)";
                    cmd.Parameters.Add("@userName", SqlDbType.NVarChar, 12).Value = userName;
                    cmd.Parameters.Add("@userPassword", SqlDbType.NVarChar, 50).Value = userPassword;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("已新增會員!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + ": " + ex.Message);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!checkTextboxUserInfo()) return;
            string loginUserName = this.textboxUsername.Text;
            string loginUserPassword = this.textboxPassword.Text;
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.MyMemberConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userName, userPassword FROM [MyMemberSchema].[MyMember]  WHERE userName = @loginUserName AND userPassword = @loginUserPassword";
                    cmd.Parameters.Add("@loginUserName", SqlDbType.NVarChar, 12).Value = loginUserName;
                    cmd.Parameters.Add("@loginUserPassword", SqlDbType.NVarChar, 50).Value = loginUserPassword;

                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            MessageBox.Show("登入成功！");
                        }
                        else
                        {
                            MessageBox.Show("登入失敗或沒有這個帳號！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.GetType()}: {ex.Message}");
            }

        }

        private bool checkTextboxUserInfo()
        {
            if (string.IsNullOrWhiteSpace(this.textboxUsername.Text) || string.IsNullOrWhiteSpace(this.textboxPassword.Text))
            {
                MessageBox.Show("請輸入帳號密碼!");
                return false;
            }
            return true;
        }
    }
}
