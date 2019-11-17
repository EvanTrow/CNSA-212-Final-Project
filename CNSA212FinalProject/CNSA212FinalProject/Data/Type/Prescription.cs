using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNSA212FinalProject.Data.Type
{
    class Prescription
    {
        AppMessage appMessage = new AppMessage();

        public Prescription(string medName, string medType, 
            int dispense, string intake, string medDosage, int freqNumber, 
            string freqInterval, string refills, int prescriptionId = -1)
        {
            this.PrescriptionId = prescriptionId;
            this.MedName = medName;
            this.MedType = medType;
            this.Dispense = dispense;
            this.Intake = intake;
            this.MedDosage = medDosage;
            this.FreqNumber = freqNumber;
            this.FreqInterval = freqInterval;
            this.Refills = refills;
        }

        // init vars
        [System.ComponentModel.DisplayName("Prescription ID")]
        public int PrescriptionId { get; set; }
        [System.ComponentModel.DisplayName("Physician")]
        public string Physician { get; set; }
        [System.ComponentModel.DisplayName("Medicine")]
        public string MedName { get; set; }
        [System.ComponentModel.DisplayName("Type")]
        public string MedType { get; set; }
        public int Dispense { get; set; }
        public string Intake { get; set; }
        [System.ComponentModel.DisplayName("Dosage")]
        public string MedDosage { get; set; }
        [System.ComponentModel.DisplayName("Frequency")]
        public int FreqNumber { get; set; }
        [System.ComponentModel.DisplayName("Interval")]
        public string FreqInterval { get; set; }
        public string Refills { get; set; }
    }
}
