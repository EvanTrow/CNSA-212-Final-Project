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
    class Prescription
    {
        AppMessage appMessage = new AppMessage();

        public Prescription(string medName, string medType,
            int dispense, string intake, string medDosage, int freqNumber,
            string freqInterval, string refills, int prescriptionId = -1)
        {
            this.PrescriptionId = prescriptionId;
            this.MedName = medName;
            this.MedType = medType;
            this.Dispense = dispense;
            this.Intake = intake;
            this.MedDosage = medDosage;
            this.FreqNumber = freqNumber;
            this.FreqInterval = freqInterval;
            this.Refills = refills;
        }

        // init vars
        [System.ComponentModel.DisplayName("Prescription ID")]
        public int PrescriptionId { get; set; }
        [System.ComponentModel.DisplayName("Physician")]
        public string Physician { get; set; }
        [System.ComponentModel.DisplayName("Medicine")]
        public string MedName { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public string MedType { get; set; }
        public int Dispense { get; set; }
        public string Intake { get; set; }
        [System.ComponentModel.DisplayName("Dosage")]
        public string MedDosage { get; set; }
        [System.ComponentModel.DisplayName("Frequency")]
        public int FreqNumber { get; set; }
        [System.ComponentModel.DisplayName("Interval")]
        public string FreqInterval { get; set; }
        public string Refills { get; set; }

        public bool ExecInsert(int patientId, int physicianId, int maxRefills, bool fillOnCreate)
        {
            if (this.PrescriptionId == -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Add_Prescription @patientId, @physicianId, @medName, @medType, @dispense, @intake, @medDosage, @freqNumber, @freqInterval, @maxRefills, @fillOnCreate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@patientId", patientId);
                        command.Parameters.AddWithValue("@physicianId", physicianId);
                        command.Parameters.AddWithValue("@medName", this.MedName);
                        command.Parameters.AddWithValue("@medType", this.MedDosage);
                        command.Parameters.AddWithValue("@dispense", this.Dispense);
                        command.Parameters.AddWithValue("@intake", this.Intake);
                        command.Parameters.AddWithValue("@medDosage", this.MedDosage);
                        command.Parameters.AddWithValue("@freqNumber", this.FreqNumber);
                        command.Parameters.AddWithValue("@freqInterval", this.FreqInterval);
                        command.Parameters.AddWithValue("@maxRefills", maxRefills);
                        if (fillOnCreate)
                        {
                            command.Parameters.AddWithValue("@fillOnCreate", 1);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fillOnCreate", 0);
                        }

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

        public bool ExecUpdate(ComboBox comboBox, string maxRefills)
        {
            if (PrescriptionId != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Update_Prescription @prescriptionId, @physicianId, @medName, @medType, @dispense, @intake, @medDosage, @freqNumber, @freqInterval, @maxRefills";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@prescriptionId", this.PrescriptionId);
                        command.Parameters.AddWithValue("@physicianId", int.Parse((comboBox.SelectedItem as ComboboxItem).Value.ToString()));
                        command.Parameters.AddWithValue("@medName", this.MedName);
                        command.Parameters.AddWithValue("@medType", this.MedType);
                        command.Parameters.AddWithValue("@dispense", this.Dispense);
                        command.Parameters.AddWithValue("@intake", this.Intake);
                        command.Parameters.AddWithValue("@medDosage", this.MedDosage);
                        command.Parameters.AddWithValue("@freqNumber", this.FreqNumber);
                        command.Parameters.AddWithValue("@freqInterval", this.FreqInterval);
                        command.Parameters.AddWithValue("@maxRefills", maxRefills);
                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                appMessage.Info("Prescription Updated Sussessfully!", "Prescription Updated!");
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


        public bool ExecDelete()
        {
            if (PrescriptionId != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC DeletePrescription @prescriptionId, @refillId";

                    using (SqlCommand command1 = new SqlCommand(query, connection))
                    {
                        command1.Parameters.AddWithValue("@prescriptionId", this.PrescriptionId);
                        command1.Parameters.AddWithValue("@refillId", this.PrescriptionId);
                        connection.Open();
                        int result = command1.ExecuteNonQuery();
                        //             NewPatient_Activated(sender, e);
                        // Check Error
                        if (result < 0)
                        {
                            appMessage.Info("Prescription Deleted Sussessfully!", "Prescription Deleted!");
                            return true;
                        }
                        else
                        {
                            appMessage.Error("Error deleting data in Database!", "Error!");
                            return false;
                        }
                    }
                }

            }
            return false;
        }

        public bool ExecRefill(DatePicker datePicker)
        {
            if (PrescriptionId != -1)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString))
                {
                    String query = "EXEC Fill_Prescription @prescriptionId, @refillDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@prescriptionId", PrescriptionId);
                        command.Parameters.AddWithValue("@refillDate", datePicker.date);

                        connection.Open();

                        int result;
                        try
                        {
                            result = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            appMessage.Error(ex.Message, "Error!");
                            result = 1;
                        }


                        // Check Error
                        if (result < 0)
                        {
                            appMessage.Info("Prescription filled Sussessfully!", "Prescription Filled!");
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
