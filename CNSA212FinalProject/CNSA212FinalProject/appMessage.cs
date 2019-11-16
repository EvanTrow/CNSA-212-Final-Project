using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject
{

    public class AppMessage
    {

        internal void Error(string msg, string title = "Error")
        {
            MessageBox.Show(msg, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
        internal void Info(string msg, string title = "Info")
        {
            MessageBox.Show(msg, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
    }
}
