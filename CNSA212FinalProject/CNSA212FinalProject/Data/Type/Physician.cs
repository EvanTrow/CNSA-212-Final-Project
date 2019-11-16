using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNSA212FinalProject.Data.Type
{
    class Physician
    {
        // init object
        public Physician(int physicianId, string fName, string mInit, string lName, string gender,
            string street, string city, string stateAbbr, int zip, string phone1, string phone2, string email,
            string specialty1, string specialty2)
        {
            // Set vars
            this.PhysicianId = physicianId;
            this.Fname = fName;
            this.Minit = mInit;
            this.Lname = lName;
            this.Gender = gender;
            this.Street = street;
            this.City = city;
            this.StateAbbr = stateAbbr;
            this.Zip = zip;
            this.Phone1 = phone1;
            this.Phone2 = phone2;
            this.Email = email;
            this.Specialty1 = specialty1;
            this.Specialty2 = specialty2;
        }

        // init vars
        [System.ComponentModel.DisplayName("Physician ID")]
        public int PhysicianId { get; set; }
        [System.ComponentModel.DisplayName("First Name")]
        public string Fname { get; set; }
        [System.ComponentModel.DisplayName("Middle Inital")]
        public string Minit { get; set; }
        [System.ComponentModel.DisplayName("Last Name")]
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [System.ComponentModel.DisplayName("State")]
        public string StateAbbr { get; set; }
        public int Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Specialty1 { get; set; }
        public string Specialty2 { get; set; }
    }
}
