using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI.UI
{
    public partial class frmPrintEachResponder : Form
    {
        string  _imageURL, _name, _idNumber, _address, _contact, _email, _age, _gender, _birthdate, _position, _qualifications, _remarks;

        public frmPrintEachResponder(string imageURL, string name, string idNumber, string address, string contact, string email, string age, string gender, string birthdate, string position, string qualifications, string remarks)
        {
            InitializeComponent();

            _imageURL = imageURL;
            _name = name;
            _idNumber = idNumber;
            _address = address;
            _contact = contact;
            _email = email;
            _age = age;
            _gender = gender;
            _birthdate = birthdate;
            _position = position;
            _qualifications = qualifications;
            _remarks = remarks;
        }

        private void frmPrintEachResponder_Load(object sender, EventArgs e)
        {
            ReportParameter pImageURL = new ReportParameter("pImageURL", new Uri(_imageURL).AbsoluteUri);
            ReportParameter pDatePrint = new ReportParameter("pDatePrint", DateTime.Now.ToString("dddd, MMMM dd, yyyy"));
            ReportParameter pName = new ReportParameter("pName", _name);
            ReportParameter pIDNumber = new ReportParameter("pIDNumber", _idNumber);
            ReportParameter pAddress = new ReportParameter("pAddress", _address);
            ReportParameter pContact = new ReportParameter("pContact", _contact);
            ReportParameter pEmail = new ReportParameter("pEmail", _email);
            ReportParameter pAge = new ReportParameter("pAge", _age);
            ReportParameter pGender = new ReportParameter("pGender", _gender);
            ReportParameter pBirthdate = new ReportParameter("pBirthdate", _birthdate);
            ReportParameter pPosition = new ReportParameter("pPosition", _position);
            ReportParameter pQualifications = new ReportParameter("pQualifications", _qualifications);
            ReportParameter pRemarks = new ReportParameter("pRemarks", _remarks);

            this.reportViewerPrintEachResponder.LocalReport.EnableExternalImages = true;
            this.reportViewerPrintEachResponder.LocalReport.SetParameters(new ReportParameter[] { pImageURL, pDatePrint, pName, pIDNumber, pAddress, pContact, pEmail, pAge, pGender, pBirthdate, pPosition, pQualifications, pRemarks });

            this.reportViewerPrintEachResponder.RefreshReport();
        }
    }
}
