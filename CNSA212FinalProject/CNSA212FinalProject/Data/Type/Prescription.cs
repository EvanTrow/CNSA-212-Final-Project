using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
