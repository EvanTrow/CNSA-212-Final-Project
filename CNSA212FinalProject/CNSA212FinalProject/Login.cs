using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CNSA212FinalProject
{
    public partial class Login : Form
    {
        SplashScreen SplashScreen;
        public Login(SplashScreen splashScreen)
        {
            InitializeComponent();
            SplashScreen = splashScreen;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
            try
            {
                string connetionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();

                string sql = "SELECT TOP 1 * FROM Users WHERE username='"+ usernameTxt.Text.Trim()+ "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        // dataReader["specialty2"]);
                        if (dataReader["userpass"].ToString() == EncryptPassword(passwordTxt.Text))
                        {
                            this.Hide();
                            SplashScreen.Hide();
                            Main main = new Main();
                            main.Closed += (s, args) => this.Close();
                            main.Closed += (s, args) => SplashScreen.Close();
                            main.Show();
                        }
                        else
                        {
                            errorLbl.Visible = true;
                            errorLbl.Text = "Invalid Login";
                            loginBtn.Enabled = true;
                        }
                    }
                } else
                {
                    errorLbl.Visible = true;
                    errorLbl.Text = "Invalid Login";
                    loginBtn.Enabled = true;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                errorLbl.Text = "Error";
            }
        }

        private void usernameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }
        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                MessageBox.Show("Encripted: " + EncryptPassword(passwordTxt.Text));
            }
        }

        public static string EncryptPassword(string plainText)
        {
            byte[] salt = new byte[128];
            var hashedPassword = HashPasswordWithSalt(Encoding.UTF8.GetBytes(plainText), salt);
            return Convert.ToBase64String(hashedPassword);
        }
        private static byte[] Combine(byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];

            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

            return ret;
        }
        public static byte[] HashPasswordWithSalt(byte[] toBeHashed, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedHash = Combine(toBeHashed, salt);

                return sha256.ComputeHash(combinedHash);
            }
        }
    }
}
