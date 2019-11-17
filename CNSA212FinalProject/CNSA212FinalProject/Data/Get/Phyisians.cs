using CNSA212FinalProject.Data.Type;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject.Data.Get
{
    class Physicians
    {
        AppMessage appMessage = new AppMessage();

        public Physicians()
        {
            PhysicianList = new List<Physician>();
        }

        public List<Physician> PhysicianList { get; set; }

        // search all Physicians
        internal class Search : Physicians
        {
            public Search(string search)
            {
                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsa"].ConnectionString);

                try
                {
                    cnn.Open();
                    string sql = "EXEC sp_FindStringInTable '%" + search + "%', 'dbo', 'Physician'";
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        PhysicianList.Add(new Physician(int.Parse(dataReader["physicianId"].ToString()), dataReader["fName"].ToString(), dataReader["mInit"].ToString(),
                            dataReader["lName"].ToString(), dataReader["gender"].ToString(),
                            dataReader["street"].ToString(), dataReader["city"].ToString(), dataReader["stateAbbr"].ToString(), int.Parse(dataReader["zip"].ToString()),
                            dataReader["phone1"].ToString(), dataReader["phone2"].ToString(), dataReader["email"].ToString(),
                            dataReader["specialty1"].ToString(), dataReader["specialty2"].ToString()));
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
        }

        // add to lookup DataGrid
        public void AddToDataGrid(DataGridView dataGrid)
        {
            dataGrid.DataSource = this.PhysicianList;
        }
    }
}
