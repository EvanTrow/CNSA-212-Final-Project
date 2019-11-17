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
    public partial class NewPrescription : Form
    {
        AppMessage appMessage = new AppMessage();

        int PatientID;
        int PrescriptionID;
        public NewPrescription(int patientID, int prescriptionID)
        {
            InitializeComponent();
            getPhysicansCombo();

            PatientID = patientID;
            PrescriptionID = prescriptionID;


            //  get all textboxes in array and send to checker for first launch check
            TextBox[] textBoxes = new TextBox[50];
            int countCheck = 0;
            ComboBox[] comboBoxes = new ComboBox[50];
            int countComboCheck = 0;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == medNameTxt.GetType() && ((TextBox)c).AccessibleDescription != null)
                {
                    textBoxes[countCheck] = ((TextBox)c);
                    countCheck++;
                }
                if (c.GetType() == physicianComboBox.GetType())
                {
                    comboBoxes[countComboCheck] = ((ComboBox)c);
                    countComboCheck++;
                }
            }
            checkErrors(textBoxes);
            checkErrorsCombo(comboBoxes);


            if (PrescriptionID != -1)
            {
                autoFillData(PrescriptionID);
            }

            addPrescriptionBtn.Enabled = false;
        }

        public bool[] containsErrors = new bool[15];
        public void checkErrors(TextBox[] textBoxes)
        {
            allValidCheck();
            foreach (TextBox c in textBoxes)
            {
                // if sender is textbox and NOT empty sender
                if (c != null && c.GetType() == medNameTxt.GetType())
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
                    addPrescriptionBtn.Enabled = false;
                }
                else
                {
                    addPrescriptionBtn.Enabled = true;
                }
            }
        }

        public void allValidCheck()
        {
            // verify all textboxes are valid
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == medNameTxt.GetType() && ((TextBox)c).AccessibleDescription != null)
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
                if (c.GetType() == physicianComboBox.GetType())
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


            if (PrescriptionID != -1)
            {
                this.Text = Truncate("Prescription: "+ PrescriptionID, 30);
            }
            else
            {
                this.Text = Truncate("New Prescription", 30);
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
                if (c != null && c.GetType() == physicianComboBox.GetType())
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
                    addPrescriptionBtn.Enabled = false;
                }
                else
                {
                    addPrescriptionBtn.Enabled = true;
                }
            }
        }

        private void getPhysicansCombo()
        {
            new Physicians().SetPhysianCombo(physicianComboBox);
        }

        private void addPrescriptionBtn_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription(medNameTxt.Text, medTypeTxt.Text, int.Parse(dispenseTxt.Text), intakeTxt.Text,
                medDosageTxt.Text, int.Parse(freqNumberTxt.Text), freqIntervalTxt.Text, "");

            if (prescription.ExecInsert(PatientID, int.Parse((physicianComboBox.SelectedItem as ComboboxItem).Value.ToString()), int.Parse(maxRefillsTxt.Text), fillOnCreateCheckBox.Checked))
            {
                medNameTxt.Text = medTypeTxt.Text = dispenseTxt.Text = intakeTxt.Text = medDosageTxt.Text = freqNumberTxt.Text = freqIntervalTxt.Text = maxRefillsTxt.Text = "";
                physicianComboBox.SelectedIndex = -1;
            }
        }

        Prescription autoFillPrescription;
        private void autoFillData(int prescriptionID)
        {
            // search prescriptions by ID
            autoFillPrescription = new Prescriptions().Get(prescriptionID);
            if (autoFillPrescription != null)
            {
                // set input elements
                physicianComboBox.Text = autoFillPrescription.Physician;
                medNameTxt.Text = autoFillPrescription.MedName;
                medTypeTxt.Text = autoFillPrescription.MedType;
                dispenseTxt.Text = autoFillPrescription.Dispense.ToString();
                intakeTxt.Text = autoFillPrescription.Intake;
                medDosageTxt.Text = autoFillPrescription.MedDosage;
                freqNumberTxt.Text = autoFillPrescription.FreqNumber.ToString();
                freqIntervalTxt.Text = autoFillPrescription.FreqInterval;
                maxRefillsTxt.Text = autoFillPrescription.Refills.Substring(autoFillPrescription.Refills.LastIndexOf('/') + 1);
                refillsLbl.Text = "Refills: " + autoFillPrescription.Refills;
                // set UI elements
                if (int.Parse(autoFillPrescription.Refills.Substring(0, autoFillPrescription.Refills.LastIndexOf('/'))) >= 
                    int.Parse(autoFillPrescription.Refills.Substring(autoFillPrescription.Refills.LastIndexOf('/') + 1)))
                {
                    refillBtn.Enabled = false;
                }
                addPrescriptionBtn.Visible = false;
                fillOnCreateCheckBox.Visible = false;
                refillBtn.Visible = true;
                refillsLbl.Visible = true;
                saveBtn.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        private void refillBtn_Click(object sender, EventArgs e)
        {
            DatePicker datePicker = new DatePicker();
            DialogResult dialogResult = datePicker.ShowDialog();
            datePicker.Hide();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    if (autoFillPrescription.ExecRefill(datePicker))
                    {
                        autoFillData(PrescriptionID);
                    }
                }
                finally
                {
                    datePicker.Dispose();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // set prescription details
            autoFillPrescription.Physician = physicianComboBox.Text;
            autoFillPrescription.MedName = medNameTxt.Text;
            autoFillPrescription.MedType = medTypeTxt.Text;
            autoFillPrescription.Dispense = int.Parse(dispenseTxt.Text);
            autoFillPrescription.Intake = intakeTxt.Text;
            autoFillPrescription.MedDosage = medDosageTxt.Text;
            autoFillPrescription.FreqNumber = int.Parse(freqNumberTxt.Text);
            autoFillPrescription.FreqInterval = freqIntervalTxt.Text;
            // set update
            if (autoFillPrescription.ExecUpdate(physicianComboBox, maxRefillsTxt.Text))
            {
                autoFillData(PrescriptionID);
            }
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}