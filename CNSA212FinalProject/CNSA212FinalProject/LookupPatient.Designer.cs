namespace CNSA212FinalProject
{
    partial class LookupPatient
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateAbbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientId,
            this.fName,
            this.mInit,
            this.lName,
            this.DOB,
            this.gender,
            this.street,
            this.city,
            this.stateAbbr,
            this.zip,
            this.phone1,
            this.phone2,
            this.InsuranceCo,
            this.InsuranceNum});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(752, 396);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // patientId
            // 
            this.patientId.HeaderText = "Patient ID";
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            // 
            // fName
            // 
            this.fName.HeaderText = "First Name";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // mInit
            // 
            this.mInit.HeaderText = "Init";
            this.mInit.Name = "mInit";
            this.mInit.ReadOnly = true;
            // 
            // lName
            // 
            this.lName.HeaderText = "Last Name";
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // street
            // 
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // stateAbbr
            // 
            this.stateAbbr.HeaderText = "State";
            this.stateAbbr.Name = "stateAbbr";
            this.stateAbbr.ReadOnly = true;
            // 
            // zip
            // 
            this.zip.HeaderText = "Zip";
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            // 
            // phone1
            // 
            this.phone1.HeaderText = "Phone 1";
            this.phone1.Name = "phone1";
            this.phone1.ReadOnly = true;
            // 
            // phone2
            // 
            this.phone2.HeaderText = "Phone 2";
            this.phone2.Name = "phone2";
            this.phone2.ReadOnly = true;
            // 
            // InsuranceCo
            // 
            this.InsuranceCo.HeaderText = "Insurance Co";
            this.InsuranceCo.Name = "InsuranceCo";
            this.InsuranceCo.ReadOnly = true;
            // 
            // InsuranceNum
            // 
            this.InsuranceNum.HeaderText = "Insurance #";
            this.InsuranceNum.Name = "InsuranceNum";
            this.InsuranceNum.ReadOnly = true;
            // 
            // LookupPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 396);
            this.Controls.Add(this.dataGridView);
            this.Name = "LookupPatient";
            this.ShowIcon = false;
            this.Text = "Patient Lookup";
            this.Activated += new System.EventHandler(this.LookupPatient_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateAbbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceNum;
    }
}