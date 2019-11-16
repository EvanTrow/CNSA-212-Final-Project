using CNSA212FinalProject.Data.Get;
using CNSA212FinalProject.Data.Type;
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
    public partial class LookupPatient : Form
    {
        AppMessage appMessage = new AppMessage();

        bool alreadyActive = false;

        TabControl tabForms;
        string search;

        public LookupPatient(TabControl TabForms, string Search)
        {
            InitializeComponent();
            tabForms = TabForms;
            search = Search;

            lookupPatient(search);
        }

        Patients patients;
        public void lookupPatient(string search)
        {
            patients = new Patients(search);

            patients.AddToDataGrid(dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {            foreach(DataGridViewRow row in ((DataGridView)sender).SelectedRows)
            {
                try
                {
                    Form newForm = new NewPatient(int.Parse(dataGridView.Rows[row.Index].Cells[0].Value.ToString()));
                    newForm.MdiParent = this.MdiParent;
                    newForm.Show();
                }
                catch (Exception ex)
                {
                    appMessage.Error(ex.Message);
                }
            }
        
        }

        private void LookupPatient_Activated(object sender, EventArgs e)
        {
            if (alreadyActive)
            {
                patients.PatientList.Clear();
                lookupPatient(search);
            }

            alreadyActive = true;
        }
    }
}