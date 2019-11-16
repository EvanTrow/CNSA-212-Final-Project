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
        AppMessage appMessage = new AppMessage();

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

        string _connectionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
        private void btnAddPhysician_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "EXEC Add_Physician @fName, @lName, @mInit, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @specialty1, @specialty2";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fName", txtfirstName.Text);
                    command.Parameters.AddWithValue("@lName", txtlastName.Text);
                    command.Parameters.AddWithValue("@mInit", txtmiddleInitial.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@street", txtstreet.Text);
                    command.Parameters.AddWithValue("@city", txtcity.Text);
                    command.Parameters.AddWithValue("@stateAbbr", stateComboBox.Text.Substring(0, 2).Trim());
                    command.Parameters.AddWithValue("@zip", int.Parse(txtzip.Text));
                    command.Parameters.AddWithValue("@phone1", txtphone1.Text);
                    command.Parameters.AddWithValue("@phone2", txtphone2.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@specialty1", txtSpecialty1.Text);
                    command.Parameters.AddWithValue("@specialty2", txtSpecialty2.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();


                    // Check Error
                    if (result < 0)
                    {
                        appMessage.Info("Physician Added Sussessfully!",
                                "Physician Added!");

                        txtfirstName.Text = txtlastName.Text = txtmiddleInitial.Text = txtstreet.Text = txtcity.Text = txtzip.Text = txtphone1.Text = txtphone2.Text = txtemail.Text = txtSpecialty1.Text = txtSpecialty2.Text = "";
                        stateComboBox.SelectedIndex = genderComboBox.SelectedIndex = -1;
                    }
                    else
                    {

                        appMessage.Error("Error inserting data into Database!",
                                "Error!");
                    }
                }
            }
        }

        private void autoFillData(int physicianId)
        {
            string connetionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "SELECT * from Physician WHERE physicianID=" + physicianId + "";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                txtfirstName.Text = dataReader["fName"].ToString();
                txtlastName.Text = dataReader["lName"].ToString();
                txtmiddleInitial.Text = dataReader["mInit"].ToString().Trim();

                if (dataReader["gender"].ToString() == "M")
                {
                    genderComboBox.SelectedIndex = 0;
                }
                else if (dataReader["gender"].ToString() == "F")
                {
                    genderComboBox.SelectedIndex = 1;
                }
                else
                {
                    genderComboBox.SelectedIndex = 2;
                }

                txtstreet.Text = dataReader["street"].ToString();
                txtcity.Text = dataReader["city"].ToString();
                stateComboBox.SelectedIndex = int.Parse(stateComboBox.FindString(dataReader["stateAbbr"].ToString()).ToString());
                txtzip.Text = dataReader["zip"].ToString();
                txtphone1.Text = dataReader["phone1"].ToString();
                txtphone2.Text = dataReader["phone2"].ToString();
                txtemail.Text = dataReader["email"].ToString();
                txtSpecialty1.Text = dataReader["specialty1"].ToString();
                txtSpecialty2.Text = dataReader["specialty2"].ToString();
            }
            cnn.Close();

            btnAddPhysician.Visible = false;
            saveBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "EXEC Update_Physician @physicianId, @fName, @lName, @mInit, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @specialty1, @specialty2";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@physicianId", fillFromId);
                    command.Parameters.AddWithValue("@fName", txtfirstName.Text);
                    command.Parameters.AddWithValue("@lName", txtlastName.Text);
                    command.Parameters.AddWithValue("@mInit", txtmiddleInitial.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@street", txtstreet.Text);
                    command.Parameters.AddWithValue("@city", txtcity.Text);
                    command.Parameters.AddWithValue("@stateAbbr", stateComboBox.Text.Substring(0, 2).Trim());
                    command.Parameters.AddWithValue("@zip", int.Parse(txtzip.Text));
                    command.Parameters.AddWithValue("@phone1", txtphone1.Text);
                    command.Parameters.AddWithValue("@phone2", txtphone2.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@specialty1", txtSpecialty1.Text);
                    command.Parameters.AddWithValue("@specialty2", txtSpecialty2.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        appMessage.Info("Physician Updated Sussessfully!",
                                "Physician Updated!");

                        autoFillData(fillFromId);
                    }
                    else
                    {

                        appMessage.Error("Error updating data in Database!",
                                "Error!");
                    }
                }
            }
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