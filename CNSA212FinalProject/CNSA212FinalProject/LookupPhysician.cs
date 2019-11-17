using CNSA212FinalProject.Data.Get;
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
        AppMessage appMessage = new AppMessage();

        bool alreadyActive = false;

        TabControl tabForms;
        string search;

        public LookupPhysician(TabControl TabForms, string Search)
        {
            InitializeComponent();
            tabForms = TabForms;
            search = Search;

            lookupPhysician(search);
        }

        Physicians physicians;
        public void lookupPhysician(string search)
        {
            physicians = new Physicians.Search(search);

            physicians.AddToDataGrid(dataGridView);
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
                    appMessage.Error(ex.Message);
                }
            }
        }

        private void LookupPhysician_Activated(object sender, EventArgs e)
        {
            if (alreadyActive)
            {
                physicians.PhysicianList.Clear();
                lookupPhysician(search);
            }

            alreadyActive = true;
        }
    }
}
