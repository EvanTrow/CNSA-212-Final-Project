using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject
{
    public partial class NewPrescription : Form
    {
        public NewPrescription()
        {
            InitializeComponent();
        }
                string _connectionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=LOUIS_PHARMA;User ID=cnsa;Password=CNSAcnsa1";
        private void btnAddPrescription_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "EXEC Add_Prescription @PATIENT_ID, @PHYSICIAN_ID, @MEDNAME, @MEDINTAKE, @MEDDOSAGE, @FREQNUMBER, @FREQINTERVAL, @NUMOFREFILLS";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PATIENT_ID", txtpatientId.Text);
                    command.Parameters.AddWithValue("@PHYSICIAN_ID", txtphysicianId.Text);
                    command.Parameters.AddWithValue("@MEDNAME", txtmedName.Text);
                    command.Parameters.AddWithValue("@MEDINTAKE", txtintake.Text);
                    command.Parameters.AddWithValue("@MEDDOSAGE", txtdosage.Text);
                    command.Parameters.AddWithValue("@FREQNUMBER", txtfrequency.Text);
                    command.Parameters.AddWithValue("@FREQINTERVAL", txtInterval.Text);
                    command.Parameters.AddWithValue("@NUMOFREFILLS", txtperscriptionRefills.Text);

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
