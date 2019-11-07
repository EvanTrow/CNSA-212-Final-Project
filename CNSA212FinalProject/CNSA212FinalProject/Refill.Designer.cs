namespace CNSA212FinalProject
{
    partial class Refill
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRxNumber = new System.Windows.Forms.TextBox();
            this.lblRxNumber = new System.Windows.Forms.Label();
            this.txtRefillsLeft = new System.Windows.Forms.TextBox();
            this.lblRefillsLeft = new System.Windows.Forms.Label();
            this.txtValidBefore = new System.Windows.Forms.TextBox();
            this.lblValidBefore = new System.Windows.Forms.Label();
            this.lblRefillDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // txtRxNumber
            // 
            this.txtRxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRxNumber.Location = new System.Drawing.Point(144, 53);
            this.txtRxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRxNumber.Name = "txtRxNumber";
            this.txtRxNumber.Size = new System.Drawing.Size(680, 26);
            this.txtRxNumber.TabIndex = 42;
            // 
            // lblRxNumber
            // 
            this.lblRxNumber.AutoSize = true;
            this.lblRxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRxNumber.Location = new System.Drawing.Point(78, 56);
            this.lblRxNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRxNumber.Name = "lblRxNumber";
            this.lblRxNumber.Size = new System.Drawing.Size(45, 20);
            this.lblRxNumber.TabIndex = 41;
            this.lblRxNumber.Text = "RX#:";
            // 
            // txtRefillsLeft
            // 
            this.txtRefillsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefillsLeft.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRefillsLeft.Enabled = false;
            this.txtRefillsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefillsLeft.Location = new System.Drawing.Point(144, 108);
            this.txtRefillsLeft.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefillsLeft.Name = "txtRefillsLeft";
            this.txtRefillsLeft.Size = new System.Drawing.Size(680, 26);
            this.txtRefillsLeft.TabIndex = 45;
            // 
            // lblRefillsLeft
            // 
            this.lblRefillsLeft.AutoSize = true;
            this.lblRefillsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefillsLeft.Location = new System.Drawing.Point(50, 111);
            this.lblRefillsLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefillsLeft.Name = "lblRefillsLeft";
            this.lblRefillsLeft.Size = new System.Drawing.Size(88, 20);
            this.lblRefillsLeft.TabIndex = 44;
            this.lblRefillsLeft.Text = "Refills Left:";
            // 
            // txtValidBefore
            // 
            this.txtValidBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValidBefore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtValidBefore.Enabled = false;
            this.txtValidBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidBefore.Location = new System.Drawing.Point(144, 155);
            this.txtValidBefore.Margin = new System.Windows.Forms.Padding(4);
            this.txtValidBefore.Name = "txtValidBefore";
            this.txtValidBefore.Size = new System.Drawing.Size(680, 26);
            this.txtValidBefore.TabIndex = 47;
            // 
            // lblValidBefore
            // 
            this.lblValidBefore.AutoSize = true;
            this.lblValidBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidBefore.Location = new System.Drawing.Point(38, 158);
            this.lblValidBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidBefore.Name = "lblValidBefore";
            this.lblValidBefore.Size = new System.Drawing.Size(100, 20);
            this.lblValidBefore.TabIndex = 46;
            this.lblValidBefore.Text = "Valid Before:";
            // 
            // lblRefillDate
            // 
            this.lblRefillDate.AutoSize = true;
            this.lblRefillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefillDate.Location = new System.Drawing.Point(50, 212);
            this.lblRefillDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefillDate.Name = "lblRefillDate";
            this.lblRefillDate.Size = new System.Drawing.Size(87, 20);
            this.lblRefillDate.TabIndex = 48;
            this.lblRefillDate.Text = "Refill Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(144, 212);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(271, 26);
            this.dateTimePicker.TabIndex = 52;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(431, 204);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(84, 35);
            this.submitBtn.TabIndex = 51;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // Refill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 519);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.lblRefillDate);
            this.Controls.Add(this.txtValidBefore);
            this.Controls.Add(this.lblValidBefore);
            this.Controls.Add(this.txtRefillsLeft);
            this.Controls.Add(this.lblRefillsLeft);
            this.Controls.Add(this.txtRxNumber);
            this.Controls.Add(this.lblRxNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Refill";
            this.Text = "Refill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRxNumber;
        private System.Windows.Forms.Label lblRxNumber;
        private System.Windows.Forms.TextBox txtRefillsLeft;
        private System.Windows.Forms.Label lblRefillsLeft;
        private System.Windows.Forms.TextBox txtValidBefore;
        private System.Windows.Forms.Label lblValidBefore;
        private System.Windows.Forms.Label lblRefillDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button submitBtn;
    }
}