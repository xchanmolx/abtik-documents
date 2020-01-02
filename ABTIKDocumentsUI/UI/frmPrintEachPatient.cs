using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI.UI
{
    public partial class frmPrintEachPatient : Form
    {
        string _date, _patientNo, _placeOfIncident, _name, _age, _sex, _address, _typeOfIncident, _chiefComplaints, _pastMedicalHistory, _oxygen, _bpRate, _respiratory, _temperature, _pulseRate, _pupil, _SAMPLE, _physicalFindings, _otherPersonsInvolved, _callerInformation, _treatment, _materialsUsed, _transported, _endorsed, _emergencyResponseTeam, _ambulancePlateNo;

        public frmPrintEachPatient(string date, string patientNo, string placeOfIncident, string name, string age, string sex, string address, string typeOfIncident, string chiefComplaints, string pastMedicalHistory, string oxygen, string bpRate, string respiratory, string temperature, string pulseRate, string pupil, string SAMPLE, string physicalFindings, string otherPersonsInvolved, string callerInformation, string treatment, string materialsUsed, string transported, string endorsed, string emergencyResponseTeam, string ambulancePlateNo)
        {
            InitializeComponent();

            _date = date;
            _patientNo = patientNo;
            _placeOfIncident = placeOfIncident;
            _name = name;
            _age = age;
            _sex = sex;
            _address = address;
            _typeOfIncident = typeOfIncident;
            _chiefComplaints = chiefComplaints;
            _pastMedicalHistory = pastMedicalHistory;
            _oxygen = oxygen;
            _bpRate = bpRate;
            _respiratory = respiratory;
            _temperature = temperature;
            _pulseRate = pulseRate;
            _pupil = pupil;
            _SAMPLE = SAMPLE;
            _physicalFindings = physicalFindings;
            _otherPersonsInvolved = otherPersonsInvolved;
            _callerInformation = callerInformation;
            _treatment = treatment;
            _materialsUsed = materialsUsed;
            _transported = transported;
            _endorsed = endorsed;
            _emergencyResponseTeam = emergencyResponseTeam;
            _ambulancePlateNo = ambulancePlateNo;
        }

        private void frmPrintEachPatient_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pPatientNo", _patientNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pPlaceOfIncident", _placeOfIncident),
                new Microsoft.Reporting.WinForms.ReportParameter("pName", _name),
                new Microsoft.Reporting.WinForms.ReportParameter("pAge", _age),
                new Microsoft.Reporting.WinForms.ReportParameter("pSex", _sex),
                new Microsoft.Reporting.WinForms.ReportParameter("pAddress", _address),
                new Microsoft.Reporting.WinForms.ReportParameter("pTypeOfIncident", _typeOfIncident),
                new Microsoft.Reporting.WinForms.ReportParameter("pChiefComplaints", _chiefComplaints),
                new Microsoft.Reporting.WinForms.ReportParameter("pPastMedicalHistory", _pastMedicalHistory),
                new Microsoft.Reporting.WinForms.ReportParameter("pOxygen", _oxygen),
                new Microsoft.Reporting.WinForms.ReportParameter("pBPRate", _bpRate),
                new Microsoft.Reporting.WinForms.ReportParameter("pRespiratory", _respiratory),
                new Microsoft.Reporting.WinForms.ReportParameter("pTemperature", _temperature),
                new Microsoft.Reporting.WinForms.ReportParameter("pPulseRate", _pulseRate),
                new Microsoft.Reporting.WinForms.ReportParameter("pPupil", _pupil),
                new Microsoft.Reporting.WinForms.ReportParameter("pSAMPLE", _SAMPLE),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhysicalFindings", _physicalFindings),
                new Microsoft.Reporting.WinForms.ReportParameter("pOtherPersonsInvolved", _otherPersonsInvolved),
                new Microsoft.Reporting.WinForms.ReportParameter("pCallerInformation", _callerInformation),
                new Microsoft.Reporting.WinForms.ReportParameter("pTreatment", _treatment),
                new Microsoft.Reporting.WinForms.ReportParameter("pMaterialsUsed", _materialsUsed),
                new Microsoft.Reporting.WinForms.ReportParameter("pTransported", _transported),
                new Microsoft.Reporting.WinForms.ReportParameter("pEndorsed", _endorsed),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmergencyResponseTeam", _emergencyResponseTeam),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmbulancePlateNo", _ambulancePlateNo)
            };
            this.reportViewerPrintEachPatient.LocalReport.SetParameters(para);
            this.reportViewerPrintEachPatient.RefreshReport();
        }
    }
}
