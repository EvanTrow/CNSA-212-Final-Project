namespace CNSA212FinalProject
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPrescriptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.prescriptionToolStripMenuItem,
            this.physicianToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.newToolStripMenuItem.Text = "New";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPrescriptionToolStripMenuItem1,
            this.refillToolStripMenuItem});
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // newPrescriptionToolStripMenuItem1
            // 
            this.newPrescriptionToolStripMenuItem1.Name = "newPrescriptionToolStripMenuItem1";
            this.newPrescriptionToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.newPrescriptionToolStripMenuItem1.Text = "New Prescription";
            this.newPrescriptionToolStripMenuItem1.Click += new System.EventHandler(this.prescriptionToolStripMenuItem1_Click);
            // 
            // refillToolStripMenuItem
            // 
            this.refillToolStripMenuItem.Name = "refillToolStripMenuItem";
            this.refillToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.refillToolStripMenuItem.Text = "Refill Prescription";
            this.refillToolStripMenuItem.Click += new System.EventHandler(this.refillToolStripMenuItem_click);
            // 
            // physicianToolStripMenuItem
            // 
            this.physicianToolStripMenuItem.Name = "physicianToolStripMenuItem";
            this.physicianToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.physicianToolStripMenuItem.Text = "Physician";
            this.physicianToolStripMenuItem.Click += new System.EventHandler(this.physicianToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Louis’ Pharmacy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPrescriptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicianToolStripMenuItem;
    }
}

