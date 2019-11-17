using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject.Data.Type
{
    class Patient
    {
        AppMessage appMessage = new AppMessage();

        // init object
        public Patient(string fName, string mInit, string lName, string dob, string gender, 
            string street, string city, string stateAbbr, int zip, string phone1, string phone2, string email, 
            string insuranceCo, string insuranceNum, int patientId = -1)
        {
            // Set vars
            this.PatientId = patientId;
            this.Fname = fName;
            this.Minit = mInit;
            this.Lname = lName;
            this.DOB = dob;
            this.Gender = gender;
            this.Street = street;
            this.City = city;
            this.StateAbbr = stateAbbr;
            this.Zip = zip;
            this.Phone1 = phone1;
            this.Phone2 = phone2;
            this.Email = email;
            this.InsuranceCo = insuranceCo;
            this.InsuranceNum = insuranceNum;
            // create Prescription list
            Prescriptions = new List<Prescription>();
        }

        // init vars
        [System.ComponentModel.DisplayName("Patient ID")]
        public int PatientId { get; set; }
        [System.ComponentModel.DisplayName("First Name")]
        public string Fname { get; set; }
        [System.ComponentModel.DisplayName("Middle Inital")]
        public string Minit { get; set; }
        [System.ComponentModel.DisplayName("Last Name")]
        public string Lname { get; set; }
        [System.ComponentModel.DisplayName("Date of Birth")]
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [System.ComponentModel.DisplayName("State")]
        public string StateAbbr { get; set; }
        [System.ComponentModel.DisplayName("Zip Code")]
        public int Zip { get; set; }
        [System.ComponentModel.DisplayName("Phone 1")]
        public string Phone1 { get; set; }
        [System.ComponentModel.DisplayName("Phone 2")]
        public string Phone2 { get; set; }
        public string Email { get; set; }
        [System.ComponentModel.DisplayName("Insurance Co")]
        public string InsuranceCo { get; set; }
        [System.ComponentModel.DisplayName("Insurance #")]
        public string InsuranceNum { get; set; }
        public List<Prescription> Prescriptions { get; set; }

        public bool ExecInsert()
        {
            if (this.PatientId == -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Add_Patient @fName, @lName, @mInit, @DOB, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @InsuranceCo, @InsuranceNum";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fName", this.Fname);
                        command.Parameters.AddWithValue("@lName", this.Lname);
                        command.Parameters.AddWithValue("@mInit", this.Minit);
                        command.Parameters.AddWithValue("@DOB", this.DOB);
                        command.Parameters.AddWithValue("@gender", this.Gender);
                        command.Parameters.AddWithValue("@street", this.Street);
                        command.Parameters.AddWithValue("@city", this.City);
                        command.Parameters.AddWithValue("@stateAbbr", this.StateAbbr);
                        command.Parameters.AddWithValue("@zip", this.Zip);
                        command.Parameters.AddWithValue("@phone1", this.Phone1);
                        command.Parameters.AddWithValue("@phone2", this.Phone2);
                        command.Parameters.AddWithValue("@email", this.Email);
                        command.Parameters.AddWithValue("@InsuranceCo", this.InsuranceCo);
                        command.Parameters.AddWithValue("@InsuranceNum", this.InsuranceNum);

                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                appMessage.Info("Patient Added Sussessfully!", "Patient Added!");
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

                            appMessage.Error("Error: "+ ex.Message, "Error!");
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
            if (this.PatientId != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Update_Patient @patientId, @fName, @lName, @mInit, @DOB, @gender, @street, @city, @stateAbbr, @zip, @phone1, @phone2, @email, @InsuranceCo, @InsuranceNum";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", this.PatientId);
                        command.Parameters.AddWithValue("@fName", this.Fname);
                        command.Parameters.AddWithValue("@lName", this.Lname);
                        command.Parameters.AddWithValue("@mInit", this.Minit);
                        command.Parameters.AddWithValue("@DOB", this.DOB);
                        command.Parameters.AddWithValue("@gender", this.Gender);
                        command.Parameters.AddWithValue("@street", this.Street);
                        command.Parameters.AddWithValue("@city", this.City);
                        command.Parameters.AddWithValue("@stateAbbr", this.StateAbbr);
                        command.Parameters.AddWithValue("@zip", this.Zip);
                        command.Parameters.AddWithValue("@phone1", this.Phone1);
                        command.Parameters.AddWithValue("@phone2", this.Phone2);
                        command.Parameters.AddWithValue("@email", this.Email);
                        command.Parameters.AddWithValue("@InsuranceCo", this.InsuranceCo);
                        command.Parameters.AddWithValue("@InsuranceNum", this.InsuranceNum);
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

        public bool GetPrescriptions()
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString);

            try
            {
                cnn.Open();

                string sql = "SELECT Prescription.prescriptionId, fName, lName, Prescription.medName, Prescription.medType, " +
                        "Prescription.dispense, Prescription.intake, Prescription.medDosage, Prescription.freqNumber, " +
                        "Prescription.freqInterval, Prescription.maxRefills, (SELECT COUNT(*) FROM Fill WHERE Fill.prescriptionId = Prescription.prescriptionId) as refillsUsed FROM Prescription " +
                        "INNER JOIN Physician ON Prescription.physicianId = Physician.physicianId " +
                        "WHERE patientId = " + this.PatientId.ToString();
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Prescription prescription = new Prescription((string)dataReader["medName"], (string)dataReader["medType"],
                                            (int)dataReader["dispense"], (string)dataReader["intake"], (string)dataReader["medDosage"],
                                            (int)dataReader["freqNumber"], (string)dataReader["freqInterval"], dataReader["refillsUsed"] + "/" + dataReader["maxRefills"], (int)dataReader["prescriptionId"]);
                    prescription.Physician = "Dr. " + dataReader["fName"].ToString() + " " + dataReader["lName"];

                    this.Prescriptions.Add(prescription);

                }
                cnn.Close();
                return true;
            }
            catch(Exception ex)
            {
                appMessage.Error(ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            return false;
        }

    }
}
