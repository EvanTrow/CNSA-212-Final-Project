namespace CNSA212FinalProject
{
    partial class NewPatient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatient));
            this.lblfirstName = new System.Windows.Forms.Label();
            this.lblmiddleInitial = new System.Windows.Forms.Label();
            this.lbllastName = new System.Windows.Forms.Label();
            this.lbldateofBirth = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblphone1 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone2 = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lblstate = new System.Windows.Forms.Label();
            this.lblzip = new System.Windows.Forms.Label();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.txtphone2 = new System.Windows.Forms.TextBox();
            this.txtphone1 = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmiddleInitial = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.txtInsuranceNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsuranceCo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtzip = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.prescriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freqNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freqInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxRefills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescriptionsLbl = new System.Windows.Forms.Label();
            this.addPrescriptionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstName.Location = new System.Drawing.Point(11, 16);
            this.lblfirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(97, 23);
            this.lblfirstName.TabIndex = 0;
            this.lblfirstName.Text = "First Name:";
            // 
            // lblmiddleInitial
            // 
            this.lblmiddleInitial.AutoSize = true;
            this.lblmiddleInitial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiddleInitial.Location = new System.Drawing.Point(11, 54);
            this.lblmiddleInitial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmiddleInitial.Name = "lblmiddleInitial";
            this.lblmiddleInitial.Size = new System.Drawing.Size(118, 23);
            this.lblmiddleInitial.TabIndex = 1;
            this.lblmiddleInitial.Text = "Middle Initial:";
            // 
            // lbllastName
            // 
            this.lbllastName.AutoSize = true;
            this.lbllastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastName.Location = new System.Drawing.Point(10, 92);
            this.lbllastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllastName.Name = "lbllastName";
            this.lbllastName.Size = new System.Drawing.Size(91, 23);
            this.lbllastName.TabIndex = 2;
            this.lbllastName.Text = "Last Name:";
            // 
            // lbldateofBirth
            // 
            this.lbldateofBirth.AutoSize = true;
            this.lbldateofBirth.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofBirth.Location = new System.Drawing.Point(10, 129);
            this.lbldateofBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldateofBirth.Name = "lbldateofBirth";
            this.lbldateofBirth.Size = new System.Drawing.Size(114, 23);
            this.lbldateofBirth.TabIndex = 3;
            this.lbldateofBirth.Text = "Date of Birth:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(11, 166);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(67, 23);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender:";
            // 
            // lblphone1
            // 
            this.lblphone1.AutoSize = true;
            this.lblphone1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone1.Location = new System.Drawing.Point(10, 204);
            this.lblphone1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphone1.Name = "lblphone1";
            this.lblphone1.Size = new System.Drawing.Size(62, 23);
            this.lblphone1.TabIndex = 5;
            this.lblphone1.Text = "Phone1:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(10, 280);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 23);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email:";
            // 
            // lblphone2
            // 
            this.lblphone2.AutoSize = true;
            this.lblphone2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone2.Location = new System.Drawing.Point(10, 242);
            this.lblphone2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphone2.Name = "lblphone2";
            this.lblphone2.Size = new System.Drawing.Size(65, 23);
            this.lblphone2.TabIndex = 7;
            this.lblphone2.Text = "Phone2:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(11, 356);
            this.lblcity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(46, 23);
            this.lblcity.TabIndex = 9;
            this.lblcity.Text = "City:";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreet.Location = new System.Drawing.Point(11, 318);
            this.lblstreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(64, 23);
            this.lblstreet.TabIndex = 10;
            this.lblstreet.Text = "Street:";
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstate.Location = new System.Drawing.Point(11, 394);
            this.lblstate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(56, 23);
            this.lblstate.TabIndex = 11;
            this.lblstate.Text = "State:";
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzip.Location = new System.Drawing.Point(11, 432);
            this.lblzip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(41, 23);
            this.lblzip.TabIndex = 12;
            this.lblzip.Text = "Zip:";
            // 
            // txtfirstName
            // 
            this.txtfirstName.AccessibleDescription = "^[a-zA-Z]{2,25}$";
            this.txtfirstName.AccessibleName = "First name must be 2-25 alpha characters.";
            this.txtfirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(150, 13);
            this.txtfirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(574, 30);
            this.txtfirstName.TabIndex = 1;
            this.txtfirstName.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtphone2
            // 
            this.txtphone2.AccessibleDescription = "^(^$|((\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}))$";
            this.txtphone2.AccessibleName = "Invalid Phone #";
            this.txtphone2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone2.Location = new System.Drawing.Point(150, 239);
            this.txtphone2.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone2.Name = "txtphone2";
            this.txtphone2.Size = new System.Drawing.Size(574, 30);
            this.txtphone2.TabIndex = 7;
            this.txtphone2.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtphone1
            // 
            this.txtphone1.AccessibleDescription = "^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$";
            this.txtphone1.AccessibleName = "Invalid Phone #";
            this.txtphone1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone1.Location = new System.Drawing.Point(150, 201);
            this.txtphone1.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone1.Name = "txtphone1";
            this.txtphone1.Size = new System.Drawing.Size(574, 30);
            this.txtphone1.TabIndex = 6;
            this.txtphone1.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.AccessibleDescription = "^[a-zA-Z0-9._%+-]{1,63}@[a-zA-Z0-9.-]{1,25}\\.[a-zA-Z]{2,10}$";
            this.txtemail.AccessibleName = "Invalid email";
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(150, 277);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(574, 30);
            this.txtemail.TabIndex = 8;
            this.txtemail.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtmiddleInitial
            // 
            this.txtmiddleInitial.AccessibleDescription = "^(^$|([a-zA-z]{1}))$";
            this.txtmiddleInitial.AccessibleName = "Invalid";
            this.txtmiddleInitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmiddleInitial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddleInitial.Location = new System.Drawing.Point(150, 51);
            this.txtmiddleInitial.Margin = new System.Windows.Forms.Padding(4);
            this.txtmiddleInitial.Name = "txtmiddleInitial";
            this.txtmiddleInitial.Size = new System.Drawing.Size(574, 30);
            this.txtmiddleInitial.TabIndex = 2;
            this.txtmiddleInitial.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtlastName
            // 
            this.txtlastName.AccessibleDescription = "^[a-zA-Z]{2,25}$";
            this.txtlastName.AccessibleName = "Last name must be 2-25 alpha characters.";
            this.txtlastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(150, 89);
            this.txtlastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(574, 30);
            this.txtlastName.TabIndex = 3;
            this.txtlastName.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtcity
            // 
            this.txtcity.AccessibleDescription = "^(?=.{2,30}$).*([a-zA-Z]+|[a-zA-Z]+(\\s|-)[a-zA-Z])$";
            this.txtcity.AccessibleName = "Invalid city";
            this.txtcity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(150, 353);
            this.txtcity.Margin = new System.Windows.Forms.Padding(4);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(574, 30);
            this.txtcity.TabIndex = 10;
            this.txtcity.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtstreet
            // 
            this.txtstreet.AccessibleDescription = resources.GetString("txtstreet.AccessibleDescription");
            this.txtstreet.AccessibleName = "Invalid street address";
            this.txtstreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstreet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstreet.Location = new System.Drawing.Point(150, 315);
            this.txtstreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(574, 30);
            this.txtstreet.TabIndex = 9;
            this.txtstreet.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(604, 541);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(121, 39);
            this.btnAddPatient.TabIndex = 15;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // dateDOB
            // 
            this.dateDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDOB.CustomFormat = "MM/dd/yyyy";
            this.dateDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDOB.Location = new System.Drawing.Point(150, 128);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(574, 26);
            this.dateDOB.TabIndex = 4;
            this.dateDOB.ValueChanged += new System.EventHandler(this.dateDOB_ValueChanged);
            // 
            // txtInsuranceNum
            // 
            this.txtInsuranceNum.AccessibleDescription = "^(^$|([\\s\\S]{2,30}))$";
            this.txtInsuranceNum.AccessibleName = "Invalid";
            this.txtInsuranceNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsuranceNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsuranceNum.Location = new System.Drawing.Point(149, 505);
            this.txtInsuranceNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsuranceNum.Name = "txtInsuranceNum";
            this.txtInsuranceNum.Size = new System.Drawing.Size(576, 30);
            this.txtInsuranceNum.TabIndex = 14;
            this.txtInsuranceNum.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 508);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Insurance #:";
            // 
            // txtInsuranceCo
            // 
            this.txtInsuranceCo.AccessibleDescription = "^(^$|([\\s\\S]{2,40}))$";
            this.txtInsuranceCo.AccessibleName = "Invalid";
            this.txtInsuranceCo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsuranceCo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsuranceCo.Location = new System.Drawing.Point(149, 467);
            this.txtInsuranceCo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsuranceCo.Name = "txtInsuranceCo";
            this.txtInsuranceCo.Size = new System.Drawing.Size(576, 30);
            this.txtInsuranceCo.TabIndex = 13;
            this.txtInsuranceCo.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Insurance Co:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // txtzip
            // 
            this.txtzip.AccessibleDescription = "^[0-9]{5}$";
            this.txtzip.AccessibleName = "Invalid zip code";
            this.txtzip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtzip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzip.Location = new System.Drawing.Point(150, 429);
            this.txtzip.Margin = new System.Windows.Forms.Padding(4);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(574, 30);
            this.txtzip.TabIndex = 12;
            this.txtzip.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.AccessibleName = "state";
            this.stateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateComboBox.DropDownHeight = 250;
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.IntegralHeight = false;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL - Alabama",
            "AK - Alaska",
            "AZ - Arizona",
            "AR - Arkansas",
            "CA - California",
            "CO - Colorado",
            "CT - Connecticut",
            "DE - Delaware",
            "FL - Florida",
            "GA - Georgia",
            "HI - Hawaii",
            "ID - Idaho",
            "IL - Illinois",
            "IN - Indiana",
            "IA - Iowa",
            "KS - Kansas",
            "KY - Kentucky",
            "LA - Louisiana",
            "ME - Maine",
            "MD - Maryland",
            "MA - Massachusetts",
            "MI - Michigan",
            "MN - Minnesota",
            "MS - Mississippi",
            "MO - Missouri",
            "MT - Montana",
            "NE - Nebraska",
            "NV - Nevada",
            "NH - New Hampshire",
            "NJ - New Jersey",
            "NM - New Mexico",
            "NY - New York",
            "NC - North Carolina",
            "ND - North Dakota",
            "OH - Ohio",
            "OK - Oklahoma",
            "OR - Oregon",
            "PA - Pennsylvania",
            "RI - Rhode Island",
            "SC - South Carolina",
            "SD - South Dakota",
            "TN - Tennessee",
            "TX - Texas",
            "UT - Utah",
            "VT - Vermont",
            "VA - Virginia",
            "WA - Washington",
            "WV - West Virginia",
            "WI - Wisconsin",
            "WY - Wyoming"});
            this.stateComboBox.Location = new System.Drawing.Point(150, 390);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(574, 31);
            this.stateComboBox.TabIndex = 11;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.AccessibleName = "gender";
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "NA"});
            this.genderComboBox.Location = new System.Drawing.Point(150, 163);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(574, 31);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(604, 541);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 39);
            this.saveBtn.TabIndex = 33;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionId,
            this.physician,
            this.medName,
            this.medType,
            this.dispense,
            this.intake,
            this.medDosage,
            this.freqNumber,
            this.freqInterval,
            this.maxRefills});
            this.dataGridView.Location = new System.Drawing.Point(12, 585);
            this.dataGridView.MinimumSize = new System.Drawing.Size(0, 140);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(711, 189);
            this.dataGridView.TabIndex = 34;
            this.dataGridView.Visible = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // prescriptionId
            // 
            this.prescriptionId.HeaderText = "Prescription ID";
            this.prescriptionId.Name = "prescriptionId";
            this.prescriptionId.ReadOnly = true;
            // 
            // physician
            // 
            this.physician.HeaderText = "Physician";
            this.physician.Name = "physician";
            this.physician.ReadOnly = true;
            // 
            // medName
            // 
            this.medName.HeaderText = "Medicine";
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            this.medName.Width = 107;
            // 
            // medType
            // 
            this.medType.HeaderText = "Type";
            this.medType.Name = "medType";
            this.medType.ReadOnly = true;
            this.medType.Width = 108;
            // 
            // dispense
            // 
            this.dispense.HeaderText = "Dispense";
            this.dispense.Name = "dispense";
            this.dispense.ReadOnly = true;
            // 
            // intake
            // 
            this.intake.HeaderText = "Intake";
            this.intake.Name = "intake";
            this.intake.ReadOnly = true;
            this.intake.Width = 107;
            // 
            // medDosage
            // 
            this.medDosage.HeaderText = "Dosage";
            this.medDosage.Name = "medDosage";
            this.medDosage.ReadOnly = true;
            this.medDosage.Width = 107;
            // 
            // freqNumber
            // 
            this.freqNumber.HeaderText = "Frequency";
            this.freqNumber.Name = "freqNumber";
            this.freqNumber.ReadOnly = true;
            this.freqNumber.Width = 107;
            // 
            // freqInterval
            // 
            this.freqInterval.HeaderText = "Interval";
            this.freqInterval.Name = "freqInterval";
            this.freqInterval.ReadOnly = true;
            this.freqInterval.Width = 108;
            // 
            // maxRefills
            // 
            this.maxRefills.HeaderText = "Refills";
            this.maxRefills.Name = "maxRefills";
            this.maxRefills.ReadOnly = true;
            this.maxRefills.Width = 107;
            // 
            // PrescriptionsLbl
            // 
            this.PrescriptionsLbl.AutoSize = true;
            this.PrescriptionsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionsLbl.Location = new System.Drawing.Point(11, 558);
            this.PrescriptionsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrescriptionsLbl.Name = "PrescriptionsLbl";
            this.PrescriptionsLbl.Size = new System.Drawing.Size(111, 23);
            this.PrescriptionsLbl.TabIndex = 35;
            this.PrescriptionsLbl.Text = "Prescriptions:";
            this.PrescriptionsLbl.Visible = false;
            // 
            // addPrescriptionBtn
            // 
            this.addPrescriptionBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrescriptionBtn.Location = new System.Drawing.Point(126, 541);
            this.addPrescriptionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addPrescriptionBtn.Name = "addPrescriptionBtn";
            this.addPrescriptionBtn.Size = new System.Drawing.Size(153, 39);
            this.addPrescriptionBtn.TabIndex = 36;
            this.addPrescriptionBtn.Text = "Add Prescription";
            this.addPrescriptionBtn.UseVisualStyleBackColor = true;
            this.addPrescriptionBtn.Visible = false;
            this.addPrescriptionBtn.Click += new System.EventHandler(this.addPrescriptionBtn_Click);
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(736, 786);
            this.Controls.Add(this.addPrescriptionBtn);
            this.Controls.Add(this.PrescriptionsLbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.txtInsuranceCo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsuranceNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.txtmiddleInitial);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone1);
            this.Controls.Add(this.txtphone2);
            this.Controls.Add(this.txtfirstName);
            this.Controls.Add(this.lblzip);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.lblstreet);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblphone2);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblphone1);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldateofBirth);
            this.Controls.Add(this.lbllastName);
            this.Controls.Add(this.lblmiddleInitial);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPatient";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Patient";
            this.Activated += new System.EventHandler(this.NewPatient_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.Label lblmiddleInitial;
        private System.Windows.Forms.Label lbllastName;
        private System.Windows.Forms.Label lbldateofBirth;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblphone1;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone2;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.TextBox txtphone2;
        private System.Windows.Forms.TextBox txtphone1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmiddleInitial;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.TextBox txtInsuranceNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsuranceCo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addPrescriptionBtn;
        private System.Windows.Forms.Label PrescriptionsLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn physician;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispense;
        private System.Windows.Forms.DataGridViewTextBoxColumn intake;
        private System.Windows.Forms.DataGridViewTextBoxColumn medDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn freqNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn freqInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxRefills;
    }
}