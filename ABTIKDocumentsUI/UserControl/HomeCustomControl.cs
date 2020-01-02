using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ABTIKDocumentsUI
{
    public partial class HomeCustomControl : UserControl
    {
        public HomeCustomControl()
        {
            InitializeComponent();
        }

        private void pctrBoxHotline_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\EmergencyContacts.psd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Emergency Hotline Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
