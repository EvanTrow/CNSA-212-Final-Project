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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        NewPhysician newPhysician;
        NewPatient newPatient;
        NewPrescription newPrescription;
        Refill refill;
        UpdatePatient updatePatient;
        //Patient
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newPatient == null)
            {
                newPatient = new NewPatient();
                newPatient.MdiParent = this;
                newPatient.FormClosed += new FormClosedEventHandler(NewPatient_FormClosed);
                newPatient.Show();
            }
            else
            {
                newPatient.Activate();
            }
        }

        private void NewPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            newPatient = null;
        }


        //Physician
        private void physicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newPhysician == null)
            {
                newPhysician = new NewPhysician();
                newPhysician.MdiParent = this;
                newPhysician.FormClosed += new FormClosedEventHandler(NewPhysician_FormClosed);
                newPhysician.Show();
            }
            else
            {
                newPhysician.Activate();
            }
        }

        private void NewPhysician_FormClosed(object sender, FormClosedEventArgs e)
        {
            newPhysician = null;
        }


        //New Prescription
        private void prescriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (newPrescription == null)
            {
                newPrescription = new NewPrescription();
                newPrescription.MdiParent = this;
                newPrescription.FormClosed += new FormClosedEventHandler(NewPrescription_FormClosed);
                newPrescription.Show();
            }
            else
            {
                newPrescription.Activate();
            }
        }
       private void NewPrescription_FormClosed(object sender, FormClosedEventArgs e)
       {
                newPrescription = null;
       }

        private void refillToolStripMenuItem_click(object sender, EventArgs e)
        {
            if (refill == null)
            {
                refill = new Refill();
                refill.MdiParent = this;
                refill.FormClosed += new FormClosedEventHandler(Refill_FormClosed);
                refill.Show();
            }
            else
            {
                refill.Activate();
            }
        }
        private void Refill_FormClosed(object sender, FormClosedEventArgs e)
        {
            newPrescription = null;
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (updatePatient == null)
            {
                updatePatient = new UpdatePatient();
                updatePatient.MdiParent = this;
                updatePatient.FormClosed += new FormClosedEventHandler(UpdatePatient_FormClosed);
                updatePatient.Show();
            }
            else
            {
                updatePatient.Activate();
            }
        }
        private void UpdatePatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            updatePatient = null;
        }
    }
}
