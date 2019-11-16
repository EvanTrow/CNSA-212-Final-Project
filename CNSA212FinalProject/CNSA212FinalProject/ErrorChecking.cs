using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject
{
    class ErrorChecking
    {

        public ErrorChecking(bool[] containsErrors)
        {
            ContainsErrors = containsErrors;
        }

        private bool[] ContainsErrors { get; set; }

        public void checkErrors(TextBox[] textBoxes, ErrorProvider errorProvider, Button button, IEnumerable<Control> Controls)
        {
            allValidCheck(Controls);
            foreach (TextBox c in textBoxes)
            {
                // if sender is textbox and NOT empty sender
                if (c != null && c is TextBox)
                {
                    try
                    {
                        // if not mataching regex process error
                        Regex pattern = new Regex(((TextBox)c).AccessibleDescription);
                        if (!pattern.IsMatch(((TextBox)c).Text))
                        {
                            errorProvider.SetError(((TextBox)c), ((TextBox)c).AccessibleName);
                            errorProvider.SetIconAlignment(((TextBox)c), ErrorIconAlignment.MiddleLeft);
                            errorProvider.SetIconPadding(((TextBox)c), 2);
                        }
                        else
                        {
                            //clear error without removing all errorProviders
                            errorProvider.SetError(((TextBox)c), "");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                // Enable/Disable button if error exist
                if (ContainsErrors.Contains(true))
                {
                    button.Enabled = false;
                }
                else
                {
                    button.Enabled = true;
                }
            }
        }
        public void allValidCheck(IEnumerable<Control> Controls)
        {
            // verify all textboxes are valid
            foreach (Control c in Controls)
            {
                if (c is TextBox && ((TextBox)c).AccessibleDescription != null)
                {
                    Regex pattern = new Regex(((TextBox)c).AccessibleDescription);
                    if (!pattern.IsMatch(((TextBox)c).Text))
                    {
                        ContainsErrors[((TextBox)c).TabIndex - 1] = true;
                    }
                    else
                    {
                        ContainsErrors[((TextBox)c).TabIndex - 1] = false;
                    }
                }
                if (c is TextBox)
                {
                    if (((ComboBox)c).SelectedIndex < 0)
                    {
                        ContainsErrors[((ComboBox)c).TabIndex - 1] = true;
                    }
                    else
                    {
                        ContainsErrors[((ComboBox)c).TabIndex - 1] = false;
                    }
                }
            }
        }
    }
}
