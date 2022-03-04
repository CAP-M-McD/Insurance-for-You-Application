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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome frmHome = new frmWelcome();
            frmHome.Show();
            this.Close();

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strEntered, strPassword;
            strEntered = txtPassword.Text.ToUpper();            
            strPassword = "INSURANCEPASS";

            if(strPassword == strEntered)
            {                 
                frmAdmin frmAdminH = new frmAdmin();            
                frmAdminH.Show();           
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password! Try Again!", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPassword.Clear();
                txtPassword.Focus();
            }
            
         
        }
    }
}
