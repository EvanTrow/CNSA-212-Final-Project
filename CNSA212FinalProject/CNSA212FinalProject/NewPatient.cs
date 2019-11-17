using CNSA212FinalProject.Data.Get;
using CNSA212FinalProject.Data.Type;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CNSA212FinalProject
{
    public partial class NewPatient : Form
    {
        AppMessage appMessage = new AppMessage();

        public bool alreadyActive = false;
        public int fillFromId;

        public NewPatient(int FillFromId)
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

            btnAddPatient.Enabled = false;
            dateDOB.MaxDate = DateTime.Today;
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
                this.Text = Truncate("Patient: " + txtfirstName.Text + " " + txtlastName.Text, 30);
            } else
            {
                this.Text = Truncate("New Patient", 30);
            }
        }

        private string Truncate(string value, int maxLength)
        {
            string returnStirng = value;
            if (string.IsNullOrEmpty(value))
            {
                returnStirng = value;
            } else
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
                        } else
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
                    btnAddPatient.Enabled = false;
                }
                else
                {
                    btnAddPatient.Enabled = true;
                }
            }

        }

        private void dateDOB_ValueChanged(object sender, EventArgs e)
        {
            var selectedDate = DateTime.Parse(dateDOB.Value.ToString());
            var todaysDate = DateTime.Today;

            if (selectedDate > todaysDate)
            {
                appMessage.Error("error");
            }

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(txtfirstName.Text, txtmiddleInitial.Text, txtlastName.Text, dateDOB.Text, genderComboBox.Text,
                txtstreet.Text, txtcity.Text, stateComboBox.Text.Substring(0, 2).Trim(), int.Parse(txtzip.Text), txtphone1.Text, txtphone2.Text, txtemail.Text,
                txtInsuranceCo.Text, txtInsuranceNum.Text);

            if (patient.ExecInsert())
            {
                txtfirstName.Text = txtlastName.Text = txtmiddleInitial.Text = txtstreet.Text = txtcity.Text = txtzip.Text = txtphone1.Text = txtphone2.Text = txtemail.Text = txtInsuranceCo.Text = txtInsuranceNum.Text = "";
                stateComboBox.SelectedIndex = genderComboBox.SelectedIndex = -1;
            }
        }

        Patient autoFillPatient;
        private void autoFillData(int patientId)
        {
            // search patients by ID
            autoFillPatient = new Patients().Get(patientId);
            if (autoFillPatient != null)
            {
                // set input elements
                txtfirstName.Text = autoFillPatient.Fname;
                txtlastName.Text = autoFillPatient.Lname;
                txtmiddleInitial.Text = autoFillPatient.Minit;
                dateDOB.Value = DateTime.Parse(autoFillPatient.DOB);
                genderComboBox.SelectedIndex = int.Parse(genderComboBox.FindString(autoFillPatient.Gender).ToString());
                txtstreet.Text = autoFillPatient.Street;
                txtcity.Text = autoFillPatient.City;
                stateComboBox.SelectedIndex = int.Parse(stateComboBox.FindString(autoFillPatient.StateAbbr).ToString());
                txtzip.Text = autoFillPatient.Zip.ToString();
                txtphone1.Text = autoFillPatient.Phone1;
                txtphone2.Text = autoFillPatient.Phone2;
                txtemail.Text = autoFillPatient.Email;
                txtInsuranceCo.Text = autoFillPatient.InsuranceCo;
                txtInsuranceNum.Text = autoFillPatient.InsuranceNum;
                // set UI elements
                btnAddPatient.Visible = false;
                saveBtn.Visible = dataGridView.Visible = addPrescriptionBtn.Visible = PrescriptionsLbl.Visible = true;
                autoFillPatient.Prescriptions.Clear();

                // get prescriptions
                if (autoFillPatient.GetPrescriptions())
                {
                    dataGridView.DataSource = autoFillPatient.Prescriptions;
                }

            } else
            {
                this.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // set Patient details
            autoFillPatient.Fname = txtfirstName.Text;
            autoFillPatient.Lname =  txtlastName.Text;
            autoFillPatient.Minit = txtmiddleInitial.Text;
            autoFillPatient.DOB = dateDOB.Text;
            autoFillPatient.Gender = genderComboBox.Text;
            autoFillPatient.Street = txtstreet.Text;
            autoFillPatient.City = txtcity.Text;
            autoFillPatient.StateAbbr = stateComboBox.Text.Substring(0, 2).Trim();
            autoFillPatient.Zip = int.Parse(txtzip.Text);
            autoFillPatient.Phone1 = txtphone1.Text;
            autoFillPatient.Phone2 = txtphone2.Text;
            autoFillPatient.Email = txtemail.Text;
            autoFillPatient.InsuranceCo = txtInsuranceCo.Text;
            autoFillPatient.InsuranceNum = txtInsuranceNum.Text;
            // set update
            autoFillPatient.ExecUpdate();
        }

        private void addPrescriptionBtn_Click(object sender, EventArgs e)
        {
            NewPrescription newPrescription = new NewPrescription(fillFromId, -1);
            newPrescription.MdiParent = this.MdiParent;
            newPrescription.Show();
        }

        private void NewPatient_Activated(object sender, EventArgs e)
        {
            if (alreadyActive && fillFromId != -1)
            {
                autoFillPatient.Prescriptions.Clear();
                autoFillData(fillFromId);
            }

            alreadyActive = true;
        }
        private void dataGridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ((DataGridView)sender).SelectedRows)
            {
                try
                {
                    NewPrescription newPrescription = new NewPrescription(fillFromId, int.Parse(dataGridView.Rows[row.Index].Cells[0].Value.ToString()));
                    newPrescription.MdiParent = this.MdiParent;
                    newPrescription.Show();
                }
                catch (Exception ex)
                {
                    appMessage.Error("" + ex);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
            {
                String query = "EXEC DeletePrescription @prescriptionId, @refillId";

                using (SqlCommand command1 = new SqlCommand(query, connection))
                {

                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    var deleteprescriptionId = row.Cells[0].Value.ToString();

                    command1.Parameters.AddWithValue("@prescriptionId", deleteprescriptionId);
                    command1.Parameters.AddWithValue("@refillId", deleteprescriptionId);
                    connection.Open();
                    int result = command1.ExecuteNonQuery();
                  NewPatient_Activated(sender, e);
                    // Check Error
                    if (result < 0)
                    {


                        appMessage.Info("Patient Updated Sussessfully!",
                                "Patient Updated!");


                    }
                    else
                    {

                        appMessage.Error("Error updating data in Database!",
                                "Error!");
                    }
                }
            }
        }
    }
}
