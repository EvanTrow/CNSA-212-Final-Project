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


            //  get all textboxes in array and send to checker for first launch check
            TextBox[] textBoxes = new TextBox[50];
            int countCheck = 0;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtcity.GetType() && ((TextBox)c).AccessibleDescription != null)
                {
                    textBoxes[countCheck] = ((TextBox)c);
                    countCheck++;
                }
            }
            checkErrors(textBoxes);


            btnAddPatient.Enabled = false;
        }

        public bool[] containsErrors = new bool[15];
        public void checkErrors(TextBox[] textBoxes)
        {
            allValidCheck();
            foreach (TextBox c in textBoxes)
            {

                // if sender is textbox and NOT empty sender
                if (c != null && c.GetType() == txtcity.GetType())
                {
                    try
                    {
                        // if not mataching regex process error
                        Regex pattern = new Regex(((TextBox)c).AccessibleDescription);
                        if (!pattern.IsMatch(((TextBox)c).Text))
                        {
                            errorProvider1.SetError(((TextBox)c), ((TextBox)c).AccessibleName);
                            errorProvider1.SetIconAlignment(((TextBox)c), ErrorIconAlignment.MiddleLeft);
                            errorProvider1.SetIconPadding(((TextBox)c), 2);
                        }
                        else
                        {
                            //clear error without removing all errorProviders
                            errorProvider1.SetError(((TextBox)c), "");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }

                // Enable/Disable button if error exist
                if (containsErrors.Contains(true))
                {
                    btnAddPatient.Enabled = false;
                }
                else
                {
                    btnAddPatient.Enabled = true;
                }
            }
        }

        public void allValidCheck()
        {
            // verify all textboxes are valid
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
            // send array of textbox sender's then send to error checker
            TextBox[] textBoxes = new TextBox[1];
            textBoxes[0] = ((TextBox)sender);
            checkErrors(textBoxes);
        }
    }
}
