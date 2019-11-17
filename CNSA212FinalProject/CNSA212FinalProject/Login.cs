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
using CNSA212FinalProject.Data.Get;

namespace CNSA212FinalProject
{
    public partial class Login : Form
    {
        AppMessage appMessage = new AppMessage();

        SplashScreen SplashScreen;
        public Login(SplashScreen splashScreen)
        {
            InitializeComponent();
            SplashScreen = splashScreen;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;

            User user = new User(usernameTxt.Text, passwordTxt.Text);

            if (user.login() == "OK")
            {
                this.Hide();
                SplashScreen.Hide();
                Main main = new Main();
                main.Closed += (s, args) => this.Close();
                main.Closed += (s, args) => SplashScreen.Close();
                main.Show();
            } else
            {
                errorLbl.Visible = true;
                errorLbl.Text = "Invalid Login";
                loginBtn.Enabled = true;
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
            User user = new User();

            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                appMessage.Info("Encripted: " + user.EncryptPassword(passwordTxt.Text));
            }
        }
    }
}
