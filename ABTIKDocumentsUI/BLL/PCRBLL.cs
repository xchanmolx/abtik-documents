using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABTIKDocumentsUI.BLL
{
    public class PCRBLL
    {        
        public int ID { get; set; } // No. 1
        public string PatientNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string PlaceOfIncident { get; set; }
        public string TypeOfIncident { get; set; }
        public string Date { get; set; }
        public string ChiefComplaints { get; set; }
        public string Oxygen { get; set; }
        public string BloodPressure { get; set; }
        public string RespiratoryRate { get; set; }
        public string Temperature { get; set; }
        public string PulseRate { get; set; }
        public string Pupil { get; set; }
        public string PastMedicalHistory { get; set; }
        public string SAMPLE { get; set; }
        public string PhysicalFindings { get; set; }
        public string Treatment { get; set; }
        public string OtherPersonsInvolved { get; set; }
        public string CallerInformation { get; set; }
        public string MaterialsUsed { get; set; }
        public string TransportedToNameOfHospitalOrResidence { get; set; }
        public string EndorsedTo { get; set; }
        public string EmergencyResponseTeam { get; set; }
        public string AmbulanceBodyNoAndPlateNo { get; set; }
        public string WAIVER { get; set; } // No. 28
    }
}
