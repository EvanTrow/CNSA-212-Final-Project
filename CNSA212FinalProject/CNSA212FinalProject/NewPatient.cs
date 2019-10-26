using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        string _connectionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=LOUIS_PHARMA;User ID=cnsa;Password=CNSAcnsa1";
 
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "EXEC Add_Patient @FNAME, @LNAME, @MINIT, @DOB, @GENDER, @STREET1, @CITY, @STATEABBR, @ZIP, @HOMEPHONE, @CELLPHONE, @HOMEEMAIL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FNAME", txtfirstName.Text);
                    command.Parameters.AddWithValue("@LNAME", txtlastName.Text);
                    command.Parameters.AddWithValue("@MINIT", txtmiddleInitial.Text);
                    command.Parameters.AddWithValue("@DOB", txtdateOfBirth.Text);
                    command.Parameters.AddWithValue("@GENDER", txtgender.Text);
                    command.Parameters.AddWithValue("@STREET1", txtstreet.Text);
                    command.Parameters.AddWithValue("@CITY", txtcity.Text);
                    command.Parameters.AddWithValue("@STATEABBR", txtstreet.Text);
                    command.Parameters.AddWithValue("@ZIP", txtzip.Text);
                    command.Parameters.AddWithValue("@HOMEPHONE", txtphone1.Text);
                    command.Parameters.AddWithValue("@CELLPHONE", txtphone2.Text);
                    command.Parameters.AddWithValue("@HOMEEMAIL", txtemail1.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }

        }
    }
}
