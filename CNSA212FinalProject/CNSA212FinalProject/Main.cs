﻿using System;
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
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(newPatient == null)
            {
                newPatient = new NewPatient();
                newPatient.MdiParent = this;
                newPatient.FormClosed += new FormClosedEventHandler(NewPatient_FormClosed);
                newPatient.Show();
            } else
            {
                newPatient.Activate();
            }
        }

        private void NewPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            newPatient = null;
        }

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
    }
}
