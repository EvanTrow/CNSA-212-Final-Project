using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace CNSA212FinalProject
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();

            checkErrors();
            btnAddPatient.Enabled = false;
        }

        public bool[] containsErrors = new bool[15];
        public void checkErrors()
        {
            allValidCheck();
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtcity.GetType())
                {
                    try
                    {
                        Regex pattern = new Regex(((TextBox)c).AccessibleDescription);
                        if (!pattern.IsMatch(((TextBox)c).Text))
                        {
                            errorProvider1.SetError(((TextBox)c), ((TextBox)c).AccessibleName);
                            errorProvider1.SetIconAlignment(((TextBox)c), ErrorIconAlignment.MiddleLeft);
                            errorProvider1.SetIconPadding(((TextBox)c), 2);
                        }
                        else
                        {
                            errorProvider1.SetError(((TextBox)c), "");
                        }
                    }
                    catch { }
                }
            }
            if (containsErrors.Contains(true))
            {
                btnAddPatient.Enabled = false;
            }
            else
            {
                btnAddPatient.Enabled = true;
            }
        }

        public void allValidCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtcity.GetType() && ((TextBox)c).AccessibleDescription != null)
                {
                    Regex pattern = new Regex(((TextBox)c).AccessibleDescription);
                    if (!pattern.IsMatch(((TextBox)c).Text))
                    {
                        containsErrors[((TextBox)c).TabIndex-1] = true;
                    }
                    else
                    {
                        containsErrors[((TextBox)c).TabIndex-1] = false;
                    }
                }
            }
        }

        private void form_TextChanged(object sender, EventArgs e)
        {
            checkErrors();
        }
    }
}
