using CNSA212FinalProject.Data.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNSA212FinalProject.Data.Get
{
    class Patients
    {
        AppMessage appMessage = new AppMessage();

        public Patients(string search)
        {
            PatientList = new List<Patient>();

            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString);

            try
            {
                cnn.Open();
                string sql = "EXEC sp_FindStringInTable '%" + search + "%', 'dbo', 'Patient'";
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    PatientList.Add(new Patient(int.Parse(dataReader["patientID"].ToString()), dataReader["fName"].ToString(), dataReader["mInit"].ToString(),
                        dataReader["lName"].ToString(), Convert.ToDateTime(dataReader["DOB"]).ToString("MM/dd/yyyy"), dataReader["gender"].ToString(),
                        dataReader["street"].ToString(), dataReader["city"].ToString(), dataReader["stateAbbr"].ToString(), int.Parse(dataReader["zip"].ToString()),
                        dataReader["email"].ToString(), dataReader["phone1"].ToString(), dataReader["phone2"].ToString(),
                        dataReader["InsuranceCo"].ToString(), dataReader["InsuranceNum"].ToString()));
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                appMessage.Error(ex.Message, "Error!");
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Patient> PatientList { get; set; }

        public void AddToDataGrid(DataGridView dataGrid)
        {
            dataGrid.DataSource = this.PatientList;
        }
    }
}
