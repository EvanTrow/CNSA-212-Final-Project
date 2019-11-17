using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CNSA212FinalProject.Data.Get
{
    class User
    {
        // init object
        public User(string username = "" , string password = "")
        {
            // Set vars
            this.Username = username;
            this.Password = password;
        }

        // init vars
        public string Username { get; set; }
        public string Password { get; set; }

        public string login()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString);
                cnn.Open();

                string sql = "SELECT TOP 1 * FROM Users WHERE username='" + this.Username.Trim() + "'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        // if encripted passwords match
                        if (dataReader["userpass"].ToString() == EncryptPassword(this.Password))
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Invalid Login";
                        }
                    }
                }
                else
                {
                    return "Invalid Login";
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            return "Error!";
        }




        // password Encription *****************************************
        public string EncryptPassword(string plainText)
        {
            byte[] salt = new byte[128];
            var hashedPassword = HashPasswordWithSalt(Encoding.UTF8.GetBytes(plainText), salt);
            return Convert.ToBase64String(hashedPassword);
        }
        private byte[] Combine(byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];

            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

            return ret;
        }
        public byte[] HashPasswordWithSalt(byte[] toBeHashed, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedHash = Combine(toBeHashed, salt);

                return sha256.ComputeHash(combinedHash);
            }
        }
    }
}
