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

        string output;
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
            foreach(bool valid in containsErrors)
            {
                output += valid.ToString() +", ";
            }
            Console.WriteLine(output);
            output = "";
            Console.WriteLine(containsErrors.Contains(true));
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


        string _connectionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=LOUIS_PHARMA;User ID=cnsa;Password=CNSAcnsa1";
        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "EXEC Add_Patient @fName, @lName, @mInit, @DOB, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @InsuranceCo, @InsuranceNum";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fName", txtfirstName.Text);
                    command.Parameters.AddWithValue("@lName", txtlastName.Text);
                    command.Parameters.AddWithValue("@mInit", txtmiddleInitial.Text);
                    command.Parameters.AddWithValue("@DOB", dateDOB.Text);
                    command.Parameters.AddWithValue("@gender", txtgender.Text);
                    command.Parameters.AddWithValue("@street", txtstreet.Text);
                    command.Parameters.AddWithValue("@city", txtcity.Text);
                    command.Parameters.AddWithValue("@stateAbbr", txtstate.Text);
                    command.Parameters.AddWithValue("@zip", txtzip.Text);
                    command.Parameters.AddWithValue("@phone1", txtphone1.Text);
                    command.Parameters.AddWithValue("@phone2", txtphone2.Text);
                    command.Parameters.AddWithValue("@InsuranceCo", txtInsuranceCo);
                    command.Parameters.AddWithValue("@InsuranceNum", txtInsuranceNum.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }

        }

        private void form_TextChanged(object sender, EventArgs e)
        {
            checkErrors();
        }
    }
}
