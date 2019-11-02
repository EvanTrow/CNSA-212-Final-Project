namespace CNSA212FinalProject
{
    partial class NewPhysician
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPhysician));
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.txtSpecialty1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecialty2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtmiddleInitial = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone1 = new System.Windows.Forms.TextBox();
            this.txtphone2 = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.lblstate = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lblphone2 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone1 = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbllastName = new System.Windows.Forms.Label();
            this.lblmiddleInitial = new System.Windows.Forms.Label();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPhysician = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.genderComboBox.Location = new System.Drawing.Point(150, 119);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(634, 31);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
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
            this.stateComboBox.Location = new System.Drawing.Point(150, 346);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(634, 31);
            this.stateComboBox.TabIndex = 10;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // txtSpecialty1
            // 
            this.txtSpecialty1.AccessibleDescription = "^(^$|([\\s\\S]{2,60}))$";
            this.txtSpecialty1.AccessibleName = "Invalid";
            this.txtSpecialty1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialty1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty1.Location = new System.Drawing.Point(149, 423);
            this.txtSpecialty1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecialty1.Name = "txtSpecialty1";
            this.txtSpecialty1.Size = new System.Drawing.Size(634, 30);
            this.txtSpecialty1.TabIndex = 12;
            this.txtSpecialty1.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Specialty 1:";
            // 
            // txtSpecialty2
            // 
            this.txtSpecialty2.AccessibleDescription = "^(^$|([\\s\\S]{2,60}))$";
            this.txtSpecialty2.AccessibleName = "Invalid";
            this.txtSpecialty2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialty2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty2.Location = new System.Drawing.Point(149, 461);
            this.txtSpecialty2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecialty2.Name = "txtSpecialty2";
            this.txtSpecialty2.Size = new System.Drawing.Size(634, 30);
            this.txtSpecialty2.TabIndex = 13;
            this.txtSpecialty2.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Specialty 2:";
            // 
            // txtstreet
            // 
            this.txtstreet.AccessibleDescription = resources.GetString("txtstreet.AccessibleDescription");
            this.txtstreet.AccessibleName = "Invalid street address";
            this.txtstreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtstreet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstreet.Location = new System.Drawing.Point(150, 271);
            this.txtstreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(634, 30);
            this.txtstreet.TabIndex = 8;
            this.txtstreet.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtcity
            // 
            this.txtcity.AccessibleDescription = "^(?=.{2,30}$).*([a-zA-Z]+|[a-zA-Z]+(\\s|-)[a-zA-Z])$";
            this.txtcity.AccessibleName = "Invalid city";
            this.txtcity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(150, 309);
            this.txtcity.Margin = new System.Windows.Forms.Padding(4);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(634, 30);
            this.txtcity.TabIndex = 9;
            this.txtcity.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtzip
            // 
            this.txtzip.AccessibleDescription = "^[0-9]{5}$";
            this.txtzip.AccessibleName = "Invalid zip code";
            this.txtzip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtzip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzip.Location = new System.Drawing.Point(150, 385);
            this.txtzip.Margin = new System.Windows.Forms.Padding(4);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(634, 30);
            this.txtzip.TabIndex = 11;
            this.txtzip.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtlastName
            // 
            this.txtlastName.AccessibleDescription = "^[a-zA-Z]{2,25}$";
            this.txtlastName.AccessibleName = "Last name must be 2-25 alpha characters.";
            this.txtlastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(150, 82);
            this.txtlastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(634, 30);
            this.txtlastName.TabIndex = 3;
            this.txtlastName.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtmiddleInitial
            // 
            this.txtmiddleInitial.AccessibleDescription = "^(^$|([a-zA-z]{1}))$";
            this.txtmiddleInitial.AccessibleName = "Invalid";
            this.txtmiddleInitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmiddleInitial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmiddleInitial.Location = new System.Drawing.Point(150, 44);
            this.txtmiddleInitial.Margin = new System.Windows.Forms.Padding(4);
            this.txtmiddleInitial.Name = "txtmiddleInitial";
            this.txtmiddleInitial.Size = new System.Drawing.Size(634, 30);
            this.txtmiddleInitial.TabIndex = 2;
            this.txtmiddleInitial.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.AccessibleDescription = "^[a-zA-Z0-9._%+-]{1,63}@[a-zA-Z0-9.-]{1,25}\\.[a-zA-Z]{2,10}$";
            this.txtemail.AccessibleName = "Invalid email";
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(150, 233);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(634, 30);
            this.txtemail.TabIndex = 7;
            this.txtemail.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtphone1
            // 
            this.txtphone1.AccessibleDescription = "^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$";
            this.txtphone1.AccessibleName = "Invalid Phone #";
            this.txtphone1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone1.Location = new System.Drawing.Point(150, 157);
            this.txtphone1.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone1.Name = "txtphone1";
            this.txtphone1.Size = new System.Drawing.Size(634, 30);
            this.txtphone1.TabIndex = 5;
            this.txtphone1.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtphone2
            // 
            this.txtphone2.AccessibleDescription = "^(^$|((\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}))$";
            this.txtphone2.AccessibleName = "Invalid Phone #";
            this.txtphone2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone2.Location = new System.Drawing.Point(150, 195);
            this.txtphone2.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone2.Name = "txtphone2";
            this.txtphone2.Size = new System.Drawing.Size(634, 30);
            this.txtphone2.TabIndex = 6;
            this.txtphone2.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // txtfirstName
            // 
            this.txtfirstName.AccessibleDescription = "^[a-zA-Z]{2,25}$";
            this.txtfirstName.AccessibleName = "First name must be 2-25 alpha characters.";
            this.txtfirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(150, 6);
            this.txtfirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(634, 30);
            this.txtfirstName.TabIndex = 1;
            this.txtfirstName.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstate.Location = new System.Drawing.Point(11, 350);
            this.lblstate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(56, 23);
            this.lblstate.TabIndex = 52;
            this.lblstate.Text = "State:";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreet.Location = new System.Drawing.Point(11, 274);
            this.lblstreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(64, 23);
            this.lblstreet.TabIndex = 51;
            this.lblstreet.Text = "Street:";
            // 
            // lblphone2
            // 
            this.lblphone2.AutoSize = true;
            this.lblphone2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone2.Location = new System.Drawing.Point(10, 198);
            this.lblphone2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphone2.Name = "lblphone2";
            this.lblphone2.Size = new System.Drawing.Size(65, 23);
            this.lblphone2.TabIndex = 47;
            this.lblphone2.Text = "Phone2:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(10, 236);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 23);
            this.lblemail.TabIndex = 45;
            this.lblemail.Text = "Email:";
            // 
            // lblphone1
            // 
            this.lblphone1.AutoSize = true;
            this.lblphone1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone1.Location = new System.Drawing.Point(10, 160);
            this.lblphone1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphone1.Name = "lblphone1";
            this.lblphone1.Size = new System.Drawing.Size(62, 23);
            this.lblphone1.TabIndex = 42;
            this.lblphone1.Text = "Phone1:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(11, 122);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(67, 23);
            this.lblgender.TabIndex = 40;
            this.lblgender.Text = "Gender:";
            // 
            // lbllastName
            // 
            this.lbllastName.AutoSize = true;
            this.lbllastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastName.Location = new System.Drawing.Point(10, 85);
            this.lbllastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllastName.Name = "lbllastName";
            this.lbllastName.Size = new System.Drawing.Size(91, 23);
            this.lbllastName.TabIndex = 36;
            this.lbllastName.Text = "Last Name:";
            // 
            // lblmiddleInitial
            // 
            this.lblmiddleInitial.AutoSize = true;
            this.lblmiddleInitial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiddleInitial.Location = new System.Drawing.Point(11, 47);
            this.lblmiddleInitial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmiddleInitial.Name = "lblmiddleInitial";
            this.lblmiddleInitial.Size = new System.Drawing.Size(118, 23);
            this.lblmiddleInitial.TabIndex = 35;
            this.lblmiddleInitial.Text = "Middle Initial:";
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstName.Location = new System.Drawing.Point(11, 9);
            this.lblfirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(97, 23);
            this.lblfirstName.TabIndex = 33;
            this.lblfirstName.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Zip:";
            // 
            // btnAddPhysician
            // 
            this.btnAddPhysician.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPhysician.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhysician.Location = new System.Drawing.Point(664, 497);
            this.btnAddPhysician.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPhysician.Name = "btnAddPhysician";
            this.btnAddPhysician.Size = new System.Drawing.Size(121, 39);
            this.btnAddPhysician.TabIndex = 14;
            this.btnAddPhysician.Text = "Add Physician";
            this.btnAddPhysician.UseVisualStyleBackColor = true;
            this.btnAddPhysician.Click += new System.EventHandler(this.btnAddPhysician_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(664, 497);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 39);
            this.saveBtn.TabIndex = 61;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NewPhysician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(796, 693);
            this.Controls.Add(this.btnAddPhysician);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.txtSpecialty1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpecialty2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.txtlastName);
            this.Controls.Add(this.txtmiddleInitial);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone1);
            this.Controls.Add(this.txtphone2);
            this.Controls.Add(this.txtfirstName);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.lblstreet);
            this.Controls.Add(this.lblphone2);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblphone1);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbllastName);
            this.Controls.Add(this.lblmiddleInitial);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPhysician";
            this.Text = "New Physician";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox txtSpecialty1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecialty2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtmiddleInitial;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone1;
        private System.Windows.Forms.TextBox txtphone2;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lblphone2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone1;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbllastName;
        private System.Windows.Forms.Label lblmiddleInitial;
        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPhysician;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button saveBtn;
    }
}