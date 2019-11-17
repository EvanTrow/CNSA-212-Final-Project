using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            LoadingLbl.Text = "";

            timer1.Start();
        }

        // fake loading events
        string[] loading = new string[] { "Connecting.", "Connecting..", "Connecting...", 
                                            "Connecting.", "Connecting..", "Connecting...", 
                                            "Loading Resourses...", "Loading Physicans...", 
                                            "Loading Prescription...", "Loading Refills...", 
                                            "Loading Patients...", "Loading Database Structure...", 
                                            "Initializing Forms...", "Launching", "Launching", "" };



        // run through timer and change loading events
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                LoadingLbl.Text = loading[index];
                if (!CheckForInternetConnection() && index > 4)
                {
                    LoadingLbl.Text = "No Connection";
                    timer1.Stop();
                    DialogResult result = MessageBox.Show("Check your network connection and try again.", "No Connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Retry)
                    {
                        index = 0;
                        timer1.Start();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            finally
            {
                timer1.Stop();
                Login login = new Login(this);
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
            index++;
        }


        // Ping Google for internet check
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
