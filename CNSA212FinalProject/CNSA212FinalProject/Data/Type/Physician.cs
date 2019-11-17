using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNSA212FinalProject.Data.Type
{
    class Physician
    {
        AppMessage appMessage = new AppMessage();

        // init object
        public Physician(string fName, string mInit, string lName, string gender,
            string street, string city, string stateAbbr, int zip, string phone1, string phone2, string email,
            string specialty1, string specialty2, int physicianId = -1)
        {
            // Set vars
            this.PhysicianId = physicianId;
            this.Fname = fName;
            this.Minit = mInit;
            this.Lname = lName;
            this.Gender = gender;
            this.Street = street;
            this.City = city;
            this.StateAbbr = stateAbbr;
            this.Zip = zip;
            this.Phone1 = phone1;
            this.Phone2 = phone2;
            this.Email = email;
            this.Specialty1 = specialty1;
            this.Specialty2 = specialty2;
        }

        // init vars
        [System.ComponentModel.DisplayName("Physician ID")]
        public int PhysicianId { get; set; }
        [System.ComponentModel.DisplayName("First Name")]
        public string Fname { get; set; }
        [System.ComponentModel.DisplayName("Middle Inital")]
        public string Minit { get; set; }
        [System.ComponentModel.DisplayName("Last Name")]
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [System.ComponentModel.DisplayName("State")]
        public string StateAbbr { get; set; }
        public int Zip { get; set; }
        [System.ComponentModel.DisplayName("Phone 1")]
        public string Phone1 { get; set; }
        [System.ComponentModel.DisplayName("Phone 2")]
        public string Phone2 { get; set; }
        public string Email { get; set; }
        [System.ComponentModel.DisplayName("Specialty 1")]
        public string Specialty1 { get; set; }
        [System.ComponentModel.DisplayName("Specialty 2")]
        public string Specialty2 { get; set; }

        public bool ExecInsert()
        {
            if (this.PhysicianId == -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Add_Physician @fName, @lName, @mInit, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @specialty1, @specialty2";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fName", this.Fname);
                        command.Parameters.AddWithValue("@lName", this.Lname);
                        command.Parameters.AddWithValue("@mInit", this.Minit);
                        command.Parameters.AddWithValue("@gender", this.Gender);
                        command.Parameters.AddWithValue("@street", this.Street);
                        command.Parameters.AddWithValue("@city", this.City);
                        command.Parameters.AddWithValue("@stateAbbr", this.StateAbbr);
                        command.Parameters.AddWithValue("@zip", this.Zip);
                        command.Parameters.AddWithValue("@phone1", this.Phone1);
                        command.Parameters.AddWithValue("@phone2", this.Phone2);
                        command.Parameters.AddWithValue("@email", this.Email);
                        command.Parameters.AddWithValue("@specialty1", this.Specialty1);
                        command.Parameters.AddWithValue("@specialty2", this.Specialty2);

                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                appMessage.Info("Physician Added Sussessfully!", "Physician Added!");
                                return true;
                            }
                            else
                            {
                                appMessage.Error("Error inserting data into Database!", "Error!");
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {

                            appMessage.Error("Error: " + ex.Message, "Error!");
                            return false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return false;
        }

        public bool ExecUpdate()
        {
            if (this.PhysicianId != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Update_Physician @physicianId, @fName, @lName, @mInit, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @specialty1, @specialty2";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@physicianId", this.PhysicianId);
                        command.Parameters.AddWithValue("@fName", this.Fname);
                        command.Parameters.AddWithValue("@lName", this.Lname);
                        command.Parameters.AddWithValue("@mInit", this.Minit);
                        command.Parameters.AddWithValue("@gender", this.Gender);
                        command.Parameters.AddWithValue("@street", this.Street);
                        command.Parameters.AddWithValue("@city", this.City);
                        command.Parameters.AddWithValue("@stateAbbr", this.StateAbbr);
                        command.Parameters.AddWithValue("@zip", this.Zip);
                        command.Parameters.AddWithValue("@phone1", this.Phone1);
                        command.Parameters.AddWithValue("@phone2", this.Phone2);
                        command.Parameters.AddWithValue("@email", this.Email);
                        command.Parameters.AddWithValue("@specialty1", this.Specialty1);
                        command.Parameters.AddWithValue("@specialty2", this.Specialty2);
                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                appMessage.Info("Patient Updated Sussessfully!", "Patient Updated!");
                                return true;
                            }
                            else
                            {
                                appMessage.Error("Error updating data in Database!", "Error!");
                                return false;
                            }
                        }
                        catch (Exception ex)
                        {

                            appMessage.Error("Error: " + ex.Message, "Error!");
                            return false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return false;
        }
    }
}