using CNSA212FinalProject.Data.Get;
using CNSA212FinalProject.Data.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject
{
    public partial class NewPhysician : Form
    {
        public bool alreadyActive = false;
        public int fillFromId;
        public NewPhysician(int FillFromId)
        {
            InitializeComponent();

            fillFromId = FillFromId;

            //  get all textboxes in array and send to checker for first launch check
            TextBox[] textBoxes = new TextBox[50];
            int countCheck = 0;
            ComboBox[] comboBoxes = new ComboBox[50];
            int countComboCheck = 0;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == txtcity.GetType() && ((TextBox)c).AccessibleDescription != null)
                {
                    textBoxes[countCheck] = ((TextBox)c);
                    countCheck++;
                }
                if (c.GetType() == genderComboBox.GetType())
                {
                    comboBoxes[countComboCheck] = ((ComboBox)c);
                    countComboCheck++;
                }
            }
            checkErrors(textBoxes);
            checkErrorsCombo(comboBoxes);


            if (fillFromId != -1)
            {
                autoFillData(fillFromId);
            }

            btnAddPhysician.Enabled = false;
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
                    btnAddPhysician.Enabled = false;
                }
                else
                {
                    btnAddPhysician.Enabled = true;
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
                        containsErrors[((TextBox)c).TabIndex - 1] = true;
                    }
                    else
                    {
                        containsErrors[((TextBox)c).TabIndex - 1] = false;
                    }
                }
                if (c.GetType() == genderComboBox.GetType())
                {
                    if (((ComboBox)c).SelectedIndex < 0)
                    {
                        containsErrors[((ComboBox)c).TabIndex - 1] = true;
                    }
                    else
                    {
                        containsErrors[((ComboBox)c).TabIndex - 1] = false;
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


            if (fillFromId != -1)
            {
                this.Text = Truncate("Physician: " + txtfirstName.Text + " " + txtlastName.Text, 30);
            }
            else
            {
                this.Text = Truncate("New Physician: " + txtfirstName.Text + " " + txtlastName.Text, 30);
            }
        }

        private string Truncate(string value, int maxLength)
        {
            string returnStirng = value;
            if (string.IsNullOrEmpty(value))
            {
                returnStirng = value;
            }
            else
            {
                returnStirng = value.Length <= maxLength ? value : value.Substring(0, maxLength);
            }
            if (value.Length >= maxLength)
            {
                returnStirng += "...";
            }
            return returnStirng;
        }


        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // send array of combobox sender's then send to error checker
            ComboBox[] comboBox = new ComboBox[1];
            comboBox[0] = ((ComboBox)sender);
            checkErrorsCombo(comboBox);
        }
        public void checkErrorsCombo(ComboBox[] comboBox)
        {
            allValidCheck();
            foreach (ComboBox c in comboBox)
            {
                // if sender is combo
                if (c != null && c.GetType() == genderComboBox.GetType())
                {
                    try
                    {
                        // if not mataching regex process error
                        if (((ComboBox)c).SelectedIndex == -1)
                        {
                            errorProvider1.SetError(((ComboBox)c), ((ComboBox)c).AccessibleName);
                            errorProvider1.SetIconAlignment(((ComboBox)c), ErrorIconAlignment.MiddleLeft);
                            errorProvider1.SetIconPadding(((ComboBox)c), 2);
                        }
                        else
                        {
                            errorProvider1.SetError(((ComboBox)c), "");
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
                    btnAddPhysician.Enabled = false;
                }
                else
                {
                    btnAddPhysician.Enabled = true;
                }
            }
        }

        private void btnAddPhysician_Click(object sender, EventArgs e)
        {
            Physician physician = new Physician(txtfirstName.Text, txtmiddleInitial.Text, txtlastName.Text, genderComboBox.Text,
                txtstreet.Text, txtcity.Text, stateComboBox.Text.Substring(0, 2).Trim(), int.Parse(txtzip.Text), txtphone1.Text, txtphone2.Text, txtemail.Text,
                txtSpecialty1.Text, txtSpecialty2.Text);

            if (physician.ExecInsert())
            {
                txtfirstName.Text = txtlastName.Text = txtmiddleInitial.Text = txtstreet.Text = txtcity.Text = txtzip.Text = txtphone1.Text = txtphone2.Text = txtemail.Text = txtSpecialty1.Text = txtSpecialty2.Text = "";
                stateComboBox.SelectedIndex = genderComboBox.SelectedIndex = -1;
            }
        }

        Physician autoFillPhysician;
        private void autoFillData(int physicianId)
        {
            // search physicians by ID
            autoFillPhysician = new Physicians().Get(physicianId);
            if (autoFillPhysician != null)
            {
                // set input elements
                txtfirstName.Text = autoFillPhysician.Fname;
                txtlastName.Text = autoFillPhysician.Lname;
                txtmiddleInitial.Text = autoFillPhysician.Minit;
                genderComboBox.SelectedIndex = int.Parse(genderComboBox.FindString(autoFillPhysician.Gender).ToString());
                txtstreet.Text = autoFillPhysician.Street;
                txtcity.Text = autoFillPhysician.City;
                stateComboBox.SelectedIndex = int.Parse(stateComboBox.FindString(autoFillPhysician.StateAbbr).ToString());
                txtzip.Text = autoFillPhysician.Zip.ToString();
                txtphone1.Text = autoFillPhysician.Phone1;
                txtphone2.Text = autoFillPhysician.Phone2;
                txtemail.Text = autoFillPhysician.Email;
                txtSpecialty1.Text = autoFillPhysician.Specialty1;
                txtSpecialty2.Text = autoFillPhysician.Specialty2;
                // set UI elements
                btnAddPhysician.Visible = false;
                saveBtn.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // set Patient details
            autoFillPhysician.Fname = txtfirstName.Text;
            autoFillPhysician.Lname = txtlastName.Text;
            autoFillPhysician.Minit = txtmiddleInitial.Text;
            autoFillPhysician.Gender = genderComboBox.Text;
            autoFillPhysician.Street = txtstreet.Text;
            autoFillPhysician.City = txtcity.Text;
            autoFillPhysician.StateAbbr = stateComboBox.Text.Substring(0, 2).Trim();
            autoFillPhysician.Zip = int.Parse(txtzip.Text);
            autoFillPhysician.Phone1 = txtphone1.Text;
            autoFillPhysician.Phone2 = txtphone2.Text;
            autoFillPhysician.Email = txtemail.Text;
            autoFillPhysician.Specialty1 = txtSpecialty1.Text;
            autoFillPhysician.Specialty2 = txtSpecialty2.Text;
            // set update
            autoFillPhysician.ExecUpdate();
        }

        private void NewPhysician_Activated(object sender, EventArgs e)
        {
            if (alreadyActive && fillFromId != -1)
            {
                autoFillData(fillFromId);
            }

            alreadyActive = true;
        }
    }
}