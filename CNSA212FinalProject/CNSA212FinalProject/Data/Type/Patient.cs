using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNSA212FinalProject.Data.Type
{
    class Patient
    {
        // init object
        public Patient(int patientId, string fName, string mInit, string lName, string dob, string gender, 
            string street, string city, string stateAbbr, int zip, string phone1, string phone2, string email, 
            string insuranceCo, string insuranceNum)
        {
            // Set vars
            this.PatientId = patientId;
            this.Fname = fName;
            this.Minit = mInit;
            this.Lname = lName;
            this.DOB = dob;
            this.Gender = gender;
            this.Street = street;
            this.City = city;
            this.StateAbbr = stateAbbr;
            this.Zip = zip;
            this.Phone1 = phone1;
            this.Phone2 = phone2;
            this.Email = email;
            this.InsuranceCo = insuranceCo;
            this.InsuranceNum = insuranceNum;
            // create Prescription list
            Prescriptions = new List<Prescription>();
        }

        // init vars
        [System.ComponentModel.DisplayName("Patient ID")]
        public int PatientId { get; set; }
        [System.ComponentModel.DisplayName("First Name")]
        public string Fname { get; set; }
        [System.ComponentModel.DisplayName("Middle Inital")]
        public string Minit { get; set; }
        [System.ComponentModel.DisplayName("Last Name")]
        public string Lname { get; set; }
        [System.ComponentModel.DisplayName("Date of Birth")]
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [System.ComponentModel.DisplayName("State")]
        public string StateAbbr { get; set; }
        public int Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        [System.ComponentModel.DisplayName("Insurance Co")]
        public string InsuranceCo { get; set; }
        [System.ComponentModel.DisplayName("Insurance #")]
        public string InsuranceNum { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }
}
