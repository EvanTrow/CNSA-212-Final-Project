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
            string connetionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "SELECT physicianId, fName, lName FROM Physician";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = "Dr. " + dataReader["fName"].ToString() + " " + dataReader["lName"].ToString();
                item.Value = dataReader["physicianId"];

                physicianComboBox.Items.Add(item);
            }
            cnn.Close();

        }

        string _connectionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
        private void addPrescriptionBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "EXEC Add_Prescription @patientId, @physicianId, @medName, @medType,  @dispense, @intake, @medDosage, @freqNumber, @freqInterval, @maxRefills, @fillOnCreate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientId", PatientID);
                    command.Parameters.AddWithValue("@physicianId", (physicianComboBox.SelectedItem as ComboboxItem).Value.ToString());
                    command.Parameters.AddWithValue("@medName", medNameTxt.Text);
                    command.Parameters.AddWithValue("@medType", medTypeTxt.Text);
                    command.Parameters.AddWithValue("@dispense", dispenseTxt.Text);
                    command.Parameters.AddWithValue("@intake", intakeTxt.Text);
                    command.Parameters.AddWithValue("@medDosage", medDosageTxt.Text);
                    command.Parameters.AddWithValue("@freqNumber", freqNumberTxt.Text);
                    command.Parameters.AddWithValue("@freqInterval", freqIntervalTxt.Text);
                    command.Parameters.AddWithValue("@maxRefills", maxRefillsTxt.Text);
                    if (fillOnCreateCheckBox.Checked)
                    {
                        command.Parameters.AddWithValue("@fillOnCreate", 1);
                    } else
                    {
                        command.Parameters.AddWithValue("@fillOnCreate", 0);
                    }

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        MessageBox.Show("Prescription Added Sussessfully!",
                                "Prescription Added!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);

                        medNameTxt.Text = medTypeTxt.Text = dispenseTxt.Text = intakeTxt.Text = medDosageTxt.Text = freqNumberTxt.Text = freqIntervalTxt.Text = maxRefillsTxt.Text = "";
                        physicianComboBox.SelectedIndex = -1;
                    }
                    else
                    {

                        MessageBox.Show("Error inserting data into Database!",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
        private void autoFillData(int prescriptionID)
        {
            string connetionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "SELECT fName, lName, Prescription.medName, Prescription.medType, " +
                            "Prescription.dispense, Prescription.intake, Prescription.medDosage, Prescription.freqNumber, " +
                            "Prescription.freqInterval, Prescription.maxRefills, (SELECT COUNT(*) FROM Fill WHERE Fill.prescriptionId = Prescription.prescriptionId) as refillsUsed " +
                            "FROM Prescription " +
                            "INNER JOIN Physician ON Prescription.physicianId = Physician.physicianId " +
                            "WHERE prescriptionId =" + prescriptionID;
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                physicianComboBox.Text = "Dr. " + dataReader["fName"].ToString() + " " + dataReader["lName"].ToString();
                medNameTxt.Text = dataReader["medName"].ToString();
                medTypeTxt.Text = dataReader["medType"].ToString();
                dispenseTxt.Text = dataReader["dispense"].ToString();
                intakeTxt.Text = dataReader["intake"].ToString();
                medDosageTxt.Text = dataReader["medDosage"].ToString();
                freqNumberTxt.Text = dataReader["freqNumber"].ToString();
                freqIntervalTxt.Text = dataReader["freqInterval"].ToString();
                maxRefillsTxt.Text = dataReader["maxRefills"].ToString();
                refillsLbl.Text = "Refills: "+dataReader["refillsUsed"].ToString() + "/" + dataReader["maxRefills"].ToString();

                //  int.Parse(dataReader["refillsUsed"].ToString()) / int.Parse(dataReader["maxRefills"].ToString());
                if (int.Parse(dataReader["refillsUsed"].ToString()) >= int.Parse(dataReader["maxRefills"].ToString()))
                {
                    refillBtn.Enabled = false;
                }

            }
            cnn.Close();

            addPrescriptionBtn.Visible = false;
            fillOnCreateCheckBox.Visible = false;
            refillBtn.Visible = true;
            refillsLbl.Visible = true;
            saveBtn.Visible = true;
        }

        private void refillBtn_Click(object sender, EventArgs e)
        {
            DatePicker datePicker = new DatePicker();
            DialogResult dialogResult = datePicker.ShowDialog();
            datePicker.Hide();
            if (dialogResult == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    String query = "EXEC Fill_Prescription @prescriptionId, @refillDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@prescriptionId", PrescriptionID);
                        command.Parameters.AddWithValue("@refillDate", datePicker.date);

                        connection.Open();

                        int result;
                        try
                        {
                            result = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,
                                       "Error!",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error,
                                       MessageBoxDefaultButton.Button1);
                            result = 1;
                        }


                        // Check Error
                        if (result < 0)
                        {
                            MessageBox.Show("Prescription filled Sussessfully!",
                                    "Prescription Filled!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
                            autoFillData(PrescriptionID);
                        }/*
                        else
                        {

                            MessageBox.Show("Error inserting data into Database!",
                                    "Error!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);
                        }*/
                    }
                }
            }

            datePicker.Dispose();
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