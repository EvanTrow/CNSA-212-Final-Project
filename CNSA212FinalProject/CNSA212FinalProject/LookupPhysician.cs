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
    public partial class LookupPhysician : Form
    {
        TabControl tabForms;
        public LookupPhysician(TabControl TabForms, string search)
        {
            InitializeComponent();
            tabForms = TabForms;

            string connetionString = @"Data Source=cnsa.trowbridge.tech;Initial Catalog=Pharmacy;User ID=cnsa;Password=CNSAcnsa1";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            string sql = "EXEC sp_FindStringInTable '%" + search + "%', 'dbo', 'Physician'";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                dataGridView.Rows.Add(dataReader["physicianID"], dataReader["fName"], dataReader["mInit"], dataReader["lName"],
                    dataReader["gender"], dataReader["street"], dataReader["city"], dataReader["stateAbbr"], dataReader["zip"],
                    dataReader["phone1"], dataReader["phone2"], dataReader["email"], dataReader["specialty1"], dataReader["specialty2"]);
            }
            cnn.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ((DataGridView)sender).SelectedRows)
            {
                try
                {
                    Form newForm = new NewPhysician(int.Parse(dataGridView.Rows[row.Index].Cells[0].Value.ToString()));
                    newForm.MdiParent = this.MdiParent;
                    newForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
