using ABTIKDocumentsUI.BLL;
using ABTIKDocumentsUI.DAL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            u.Username = txtUsername.Text.Trim();
            u.Password = txtPassword.Text.Trim();

            DataTable dt = dal.Login(u);

            if (dt.Rows.Count == 1)
            {
                frmMainABTIKDocuments frm = new frmMainABTIKDocuments();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Check your Username and Password!", "Login Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                timerShutdown.Stop();
                Application.Exit();
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.Show();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            timerShutdown.Start();
        }
    }
}
