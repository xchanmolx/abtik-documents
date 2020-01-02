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
    public partial class frmPrintEachPCR : Form
    {
        string _datePrint, _datePCR, _patientNumber, _placeOfIncident, _name, _age, _sex, _address, _typeOfIncident, _chiefComplaints, _pastMedicalHistory, _SAMPLE, _oxygen, _bpRate, _respiratory, _temperature, _pulseRate, _pupil, _physicalFindings, _otherPersonsInvolved, _callerInformation, _treatment, _materialsUsed, _transportedTo, _endorsedTo, _emergencyResponseTeam, _ambulancePlateNo;

        public frmPrintEachPCR(string datePrint, string datePCR, string patientNumber, string placeOfIncident, string name, string age, string sex, string address, string typeOfIncident, string chiefComplaints, string pastMedicalHistory, string SAMPLE, string oxygen, string bpRate, string respiratory, string temperature, string pulseRate, string pupil, string physicalFindings, string otherPersonsInvolved, string callerInformation, string treatment, string materialsUsed, string transportedTo, string endorsedTo, string emergencyResponseTeam, string ambulancePlateNo)
        {
            InitializeComponent();

            _datePrint = datePrint;
            _datePCR = datePCR;
            _patientNumber = patientNumber;
            _placeOfIncident = placeOfIncident;
            _name = name;
            _age = age;
            _sex = sex;
            _address = address;
            _typeOfIncident = typeOfIncident;
            _chiefComplaints = chiefComplaints;
            _pastMedicalHistory = pastMedicalHistory;
            _SAMPLE = SAMPLE;
            _oxygen = oxygen;
            _bpRate = bpRate;
            _respiratory = respiratory;
            _temperature = temperature;
            _pulseRate = pulseRate;
            _pupil = pupil;
            _physicalFindings = physicalFindings;
            _otherPersonsInvolved = otherPersonsInvolved;
            _callerInformation = callerInformation;
            _treatment = treatment;
            _materialsUsed = materialsUsed;
            _transportedTo = transportedTo;
            _endorsedTo = endorsedTo;
            _emergencyResponseTeam = emergencyResponseTeam;
            _ambulancePlateNo = ambulancePlateNo;
        }

        private void frmPrintEachPCR_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDatePrint", _datePrint),
                new Microsoft.Reporting.WinForms.ReportParameter("pDatePCR", _datePCR),
                new Microsoft.Reporting.WinForms.ReportParameter("pPatientNumber", _patientNumber),
                new Microsoft.Reporting.WinForms.ReportParameter("pPlaceOfIncident", _placeOfIncident),
                new Microsoft.Reporting.WinForms.ReportParameter("pName", _name),
                new Microsoft.Reporting.WinForms.ReportParameter("pAge", _age),
                new Microsoft.Reporting.WinForms.ReportParameter("pSex", _sex),
                new Microsoft.Reporting.WinForms.ReportParameter("pAddress", _address),
                new Microsoft.Reporting.WinForms.ReportParameter("pTypeOfIncident", _typeOfIncident),
                new Microsoft.Reporting.WinForms.ReportParameter("pChiefComplaints", _chiefComplaints),
                new Microsoft.Reporting.WinForms.ReportParameter("pPastMedicalHistory", _pastMedicalHistory),
                new Microsoft.Reporting.WinForms.ReportParameter("pSAMPLE", _SAMPLE),
                new Microsoft.Reporting.WinForms.ReportParameter("pOxygen", _oxygen),
                new Microsoft.Reporting.WinForms.ReportParameter("pBPRate", _bpRate),
                new Microsoft.Reporting.WinForms.ReportParameter("pRespiratory", _respiratory),
                new Microsoft.Reporting.WinForms.ReportParameter("pTemperature", _temperature),
                new Microsoft.Reporting.WinForms.ReportParameter("pPulseRate", _pulseRate),
                new Microsoft.Reporting.WinForms.ReportParameter("pPupil", _pupil),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhysicalFindings", _physicalFindings),
                new Microsoft.Reporting.WinForms.ReportParameter("pOtherPersonsInvolved", _otherPersonsInvolved),
                new Microsoft.Reporting.WinForms.ReportParameter("pCallerInformation", _callerInformation),
                new Microsoft.Reporting.WinForms.ReportParameter("pTreatment", _treatment),
                new Microsoft.Reporting.WinForms.ReportParameter("pMaterialsUsed", _materialsUsed),
                new Microsoft.Reporting.WinForms.ReportParameter("pTransportedTo", _transportedTo),
                new Microsoft.Reporting.WinForms.ReportParameter("pEndorsedTo", _endorsedTo),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmergencyResponseTeam", _emergencyResponseTeam),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmbulancePlateNo", _ambulancePlateNo)
            };
            this.reportViewerPrintEachPCR.LocalReport.SetParameters(para);
            this.reportViewerPrintEachPCR.RefreshReport();
        }
    }
}
