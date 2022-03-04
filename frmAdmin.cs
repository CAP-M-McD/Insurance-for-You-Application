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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }


        private void btnPolicies_Click(object sender, EventArgs e)
        {
            frmViewPolicy frmView = new frmViewPolicy();
            frmView.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchPolicy frmSearch = new frmSearchPolicy();
            frmSearch.Show();
            this.Hide();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmWelcome mainMenu = new frmWelcome();
            mainMenu.Show();
            this.Close();
        }
    }
}
