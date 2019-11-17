using CNSA212FinalProject.Data.Type;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CNSA212FinalProject.Data.Get
{
    class Prescriptions
    {
        AppMessage appMessage = new AppMessage();

        public Prescriptions()
        {

        }


        public Prescription Get(int prescriptionID)
        {
            Prescription prescription = null;

            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString);
            try
            {

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
                    prescription = new Prescription(dataReader["medName"].ToString(), dataReader["medType"].ToString(), int.Parse(dataReader["dispense"].ToString()),
                        dataReader["intake"].ToString(), dataReader["medDosage"].ToString(), int.Parse(dataReader["freqNumber"].ToString()),
                        dataReader["freqInterval"].ToString(), dataReader["refillsUsed"].ToString() + "/" + dataReader["maxRefills"].ToString(), prescriptionID);
                    prescription.Physician = "Dr. " + dataReader["fName"].ToString() + " " + dataReader["lName"].ToString();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                appMessage.Error(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return prescription;
        }
    }
}
