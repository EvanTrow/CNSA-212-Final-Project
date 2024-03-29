﻿using CNSA212FinalProject.Data.Get;
using Microsoft.VisualBasic;
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
        private void Main_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabForms.Visible = false; // If no any child form, hide tabControl
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;
            }
        }

        // If child form closed, remove tabPage
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            string menuTag = menuItem.Name;

            Form newForm = null;


            if (menuTag == "newPatientToolStripMenuItem")
            {
                newForm = new NewPatient(-1);
            }
            else if (menuTag == "newPhysicianToolStripMenuItem")
            {
                newForm = new NewPhysician(-1);
            }

            if (newForm != null)
            {
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        LookupPatient lookupPatient;
        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = Interaction.InputBox("Search for patient", "Lookup Patient", "");
            if (lookupPatient == null)
            {
                lookupPatient = new LookupPatient(tabForms, search.Trim());
                lookupPatient.MdiParent = this;
                lookupPatient.Show();
            }
            else
            {
                lookupPatient.Close();
                lookupPatient = null;

                lookupPatient = new LookupPatient(tabForms, search.Trim());
                lookupPatient.MdiParent = this;
                lookupPatient.Show();
            }
        }

        LookupPhysician lookupPhysician;
        private void physicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = Interaction.InputBox("Search for patient", "Lookup Patient", "");
            if (lookupPhysician == null)
            {
                lookupPhysician = new LookupPhysician(tabForms, search.Trim());
                lookupPhysician.MdiParent = this;
                lookupPhysician.Show();
            }
            else
            {
                lookupPhysician.Close();
                lookupPhysician = null;

                lookupPhysician = new LookupPhysician(tabForms, search.Trim());
                lookupPhysician.MdiParent = this;
                lookupPhysician.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.MdiParent = this;
            aboutBox.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
