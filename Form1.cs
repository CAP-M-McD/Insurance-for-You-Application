using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_for_You_Application
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPolicy_Click(object sender, EventArgs e)
        {
            frmNewPolicy policyFrm = new frmNewPolicy();
            policyFrm.Show();
            this.Hide();
        }

        private void btnAdminLog_Click(object sender, EventArgs e)
        {
            frmPassword adminFrm = new frmPassword();
            adminFrm.Show();
            this.Hide(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
