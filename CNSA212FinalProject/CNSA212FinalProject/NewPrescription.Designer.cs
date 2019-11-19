namespace CNSA212FinalProject
{
    partial class NewPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPrescription));
            this.lblfirstName = new System.Windows.Forms.Label();
            this.medNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medTypeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dispenseTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intakeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medDosageTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.freqNumberTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.freqIntervalTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maxRefillsTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.physicianComboBox = new System.Windows.Forms.ComboBox();
            this.addPrescriptionBtn = new CNSA212FinalProject.Design.FlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fillOnCreateCheckBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new CNSA212FinalProject.Design.FlatButton();
            this.refillBtn = new CNSA212FinalProject.Design.FlatButton();
            this.refillsLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstName.Location = new System.Drawing.Point(11, 9);
            this.lblfirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(81, 23);
            this.lblfirstName.TabIndex = 35;
            this.lblfirstName.Text = "Physician:";
            // 
            // medNameTxt
            // 
            this.medNameTxt.AccessibleDescription = "^([\\s\\S]{2,40})$";
            this.medNameTxt.AccessibleName = "2-40 characters";
            this.medNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medNameTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameTxt.Location = new System.Drawing.Point(123, 44);
            this.medNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.medNameTxt.Name = "medNameTxt";
            this.medNameTxt.Size = new System.Drawing.Size(647, 30);
            this.medNameTxt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.medNameTxt, "Enter Medicine");
            this.medNameTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Medicine:";
            // 
            // medTypeTxt
            // 
            this.medTypeTxt.AccessibleDescription = "^([\\s\\S]{2,15})$";
            this.medTypeTxt.AccessibleName = "2-15 characters";
            this.medTypeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medTypeTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medTypeTxt.Location = new System.Drawing.Point(123, 82);
            this.medTypeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.medTypeTxt.Name = "medTypeTxt";
            this.medTypeTxt.Size = new System.Drawing.Size(647, 30);
            this.medTypeTxt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.medTypeTxt, "Enter the type");
            this.medTypeTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Type:";
            // 
            // dispenseTxt
            // 
            this.dispenseTxt.AccessibleDescription = "^[0-9]{1,10}$";
            this.dispenseTxt.AccessibleName = "Numeric only";
            this.dispenseTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dispenseTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispenseTxt.Location = new System.Drawing.Point(123, 120);
            this.dispenseTxt.Margin = new System.Windows.Forms.Padding(4);
            this.dispenseTxt.Name = "dispenseTxt";
            this.dispenseTxt.Size = new System.Drawing.Size(647, 30);
            this.dispenseTxt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dispenseTxt, "Enter the Dispense");
            this.dispenseTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dispense:";
            // 
            // intakeTxt
            // 
            this.intakeTxt.AccessibleDescription = "^([\\s\\S]{2,125})$";
            this.intakeTxt.AccessibleName = "2-125 characters";
            this.intakeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intakeTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intakeTxt.Location = new System.Drawing.Point(123, 158);
            this.intakeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.intakeTxt.Name = "intakeTxt";
            this.intakeTxt.Size = new System.Drawing.Size(647, 30);
            this.intakeTxt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.intakeTxt, "Enter the Intake");
            this.intakeTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Intake:";
            // 
            // medDosageTxt
            // 
            this.medDosageTxt.AccessibleDescription = "^([\\s\\S]{2,15})$";
            this.medDosageTxt.AccessibleName = "2-15 characters";
            this.medDosageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medDosageTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDosageTxt.Location = new System.Drawing.Point(123, 196);
            this.medDosageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.medDosageTxt.Name = "medDosageTxt";
            this.medDosageTxt.Size = new System.Drawing.Size(647, 30);
            this.medDosageTxt.TabIndex = 6;
            this.toolTip1.SetToolTip(this.medDosageTxt, "Enter the Dosage");
            this.medDosageTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Dosage:";
            // 
            // freqNumberTxt
            // 
            this.freqNumberTxt.AccessibleDescription = "^[0-9]{1,10}$";
            this.freqNumberTxt.AccessibleName = "Numeric only";
            this.freqNumberTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freqNumberTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freqNumberTxt.Location = new System.Drawing.Point(123, 234);
            this.freqNumberTxt.Margin = new System.Windows.Forms.Padding(4);
            this.freqNumberTxt.Name = "freqNumberTxt";
            this.freqNumberTxt.Size = new System.Drawing.Size(647, 30);
            this.freqNumberTxt.TabIndex = 7;
            this.toolTip1.SetToolTip(this.freqNumberTxt, "Enter the Frequency");
            this.freqNumberTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Frequency:";
            // 
            // freqIntervalTxt
            // 
            this.freqIntervalTxt.AccessibleDescription = "^([\\s\\S]{2,20})$";
            this.freqIntervalTxt.AccessibleName = "2-20 characters";
            this.freqIntervalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freqIntervalTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freqIntervalTxt.Location = new System.Drawing.Point(123, 272);
            this.freqIntervalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.freqIntervalTxt.Name = "freqIntervalTxt";
            this.freqIntervalTxt.Size = new System.Drawing.Size(647, 30);
            this.freqIntervalTxt.TabIndex = 8;
            this.toolTip1.SetToolTip(this.freqIntervalTxt, "Enter the Interval");
            this.freqIntervalTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "Interval:";
            // 
            // maxRefillsTxt
            // 
            this.maxRefillsTxt.AccessibleDescription = "^[0-9]{1,10}$";
            this.maxRefillsTxt.AccessibleName = "Numeric only";
            this.maxRefillsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxRefillsTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxRefillsTxt.Location = new System.Drawing.Point(123, 310);
            this.maxRefillsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.maxRefillsTxt.Name = "maxRefillsTxt";
            this.maxRefillsTxt.Size = new System.Drawing.Size(647, 30);
            this.maxRefillsTxt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.maxRefillsTxt, "Enter Refill max");
            this.maxRefillsTxt.TextChanged += new System.EventHandler(this.form_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Max Refills:";
            // 
            // physicianComboBox
            // 
            this.physicianComboBox.AccessibleName = "Select a Physician";
            this.physicianComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.physicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.physicianComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicianComboBox.FormattingEnabled = true;
            this.physicianComboBox.Location = new System.Drawing.Point(123, 6);
            this.physicianComboBox.Name = "physicianComboBox";
            this.physicianComboBox.Size = new System.Drawing.Size(648, 31);
            this.physicianComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.physicianComboBox, "Physcician\'s  ID");
            this.physicianComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // addPrescriptionBtn
            // 
            this.addPrescriptionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPrescriptionBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrescriptionBtn.Location = new System.Drawing.Point(619, 346);
            this.addPrescriptionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addPrescriptionBtn.Name = "addPrescriptionBtn";
            this.addPrescriptionBtn.Size = new System.Drawing.Size(153, 39);
            this.addPrescriptionBtn.TabIndex = 53;
            this.addPrescriptionBtn.Text = "Add Prescription";
            this.toolTip1.SetToolTip(this.addPrescriptionBtn, "Click to Add Prescription");
            this.addPrescriptionBtn.UseVisualStyleBackColor = true;
            this.addPrescriptionBtn.Click += new System.EventHandler(this.addPrescriptionBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // fillOnCreateCheckBox
            // 
            this.fillOnCreateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillOnCreateCheckBox.AutoSize = true;
            this.fillOnCreateCheckBox.Checked = true;
            this.fillOnCreateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillOnCreateCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillOnCreateCheckBox.Location = new System.Drawing.Point(469, 353);
            this.fillOnCreateCheckBox.Name = "fillOnCreateCheckBox";
            this.fillOnCreateCheckBox.Size = new System.Drawing.Size(134, 27);
            this.fillOnCreateCheckBox.TabIndex = 54;
            this.fillOnCreateCheckBox.Text = "Fill On Create";
            this.toolTip1.SetToolTip(this.fillOnCreateCheckBox, "Check to Fill on Create");
            this.fillOnCreateCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(619, 346);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 39);
            this.saveBtn.TabIndex = 55;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // refillBtn
            // 
            this.refillBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillBtn.Location = new System.Drawing.Point(11, 346);
            this.refillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refillBtn.Name = "refillBtn";
            this.refillBtn.Size = new System.Drawing.Size(162, 39);
            this.refillBtn.TabIndex = 56;
            this.refillBtn.Text = "Refill Prescription";
            this.toolTip1.SetToolTip(this.refillBtn, "Click to Refill");
            this.refillBtn.UseVisualStyleBackColor = true;
            this.refillBtn.Visible = false;
            this.refillBtn.Click += new System.EventHandler(this.refillBtn_Click);
            // 
            // refillsLbl
            // 
            this.refillsLbl.AutoSize = true;
            this.refillsLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillsLbl.Location = new System.Drawing.Point(179, 354);
            this.refillsLbl.Name = "refillsLbl";
            this.refillsLbl.Size = new System.Drawing.Size(79, 23);
            this.refillsLbl.TabIndex = 57;
            this.refillsLbl.Text = "Refills: 0";
            this.refillsLbl.Visible = false;
            // 
            // NewPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 436);
            this.Controls.Add(this.refillsLbl);
            this.Controls.Add(this.refillBtn);
            this.Controls.Add(this.fillOnCreateCheckBox);
            this.Controls.Add(this.addPrescriptionBtn);
            this.Controls.Add(this.physicianComboBox);
            this.Controls.Add(this.maxRefillsTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.freqIntervalTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.freqNumberTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medDosageTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.intakeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dispenseTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medTypeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewPrescription";
            this.ShowIcon = false;
            this.Text = "New Prescription";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.TextBox medNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medTypeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dispenseTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intakeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medDosageTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox freqIntervalTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxRefillsTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox physicianComboBox;
        private System.Windows.Forms.TextBox freqNumberTxt;
        private Design.FlatButton addPrescriptionBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox fillOnCreateCheckBox;
        private Design.FlatButton saveBtn;
        private Design.FlatButton refillBtn;
        private System.Windows.Forms.Label refillsLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}