using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Insurance_for_You_Application
{
    public partial class frmViewPolicy : Form
    {        
        List<Policy> Lpolicies = new List<Policy>();
        public frmViewPolicy()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Today.ToString("D");

            string strPolicyNum, strPolicyStatus, strFname, strSname, strOccu, strVech, strUsage, strStorage, line, strDrivers;
            int intNoClaims;
            double dblCost;
            DateTime dtStartDate;
            
            string strDate = DateTime.Today.ToString("dd-MM-yyyy");
            string strFilePath = "policies_" + strDate + ".csv";
            char charDriverDelimitar = '%';
            char charDelimiter = ',';
                       
            try
            {
                StreamReader policyFile = File.OpenText(strFilePath);
                while (!policyFile.EndOfStream)
                {
                    List<Drivers> LDrivers = new List<Drivers>();
                    line = policyFile.ReadLine();
                    string[] values = line.Split(charDelimiter);
                    strPolicyNum = values[0];
                    DateTime.TryParse(values[1], out dtStartDate);
                    strPolicyStatus = values[2];
                    strFname = values[3];
                    strSname = values[4];
                    int.TryParse(values[5], out intNoClaims);
                    strOccu = values[6];
                    strVech = values[7];
                    strUsage = values[8];
                    strStorage = values[9];
                    strDrivers = values[10];
                    string[] drivers = strDrivers.Split(charDriverDelimitar);

                    int intCounter = 0;
                    for (int count = 0; count < (drivers.Length / 3); count++)
                    {
                        string strDFname = " ", strDSname = " ", strDOB = " ";
                        for (int track = 0; track < 3; track++)
                        {
                            if (track == 0)
                            {
                                strDFname = drivers[intCounter];
                            }
                            else if (track == 1)
                            {
                                strDSname = drivers[intCounter];
                            }
                            if (track == 2)
                            {
                                strDOB = drivers[intCounter];
                            }
                            intCounter++;
                        }
                        Drivers newDriver = new Drivers(strDFname, strDOB, strDSname);
                        LDrivers.Add(newDriver);
                    }

                    double.TryParse(values[11], out dblCost);

                    Policy newPolicy = new Policy(strPolicyNum, dtStartDate, strPolicyStatus, strFname, strSname, intNoClaims, strOccu, strVech, strUsage, strStorage, LDrivers, dblCost);
                    Lpolicies.Add(newPolicy);
                }
                policyFile.Close();
                string infoOutput = "1.";
                int policyNum = 2;
                foreach (Policy p in Lpolicies)
                {
                    infoOutput += ("\r\n" + p.policyInfo + "\r\n");
                    infoOutput += "----------------------------------------------------------------------------\r\n" + policyNum.ToString() + ".";
                    policyNum++;
                }
                txbINFO.Text = infoOutput;
            }
            catch
            {
                txbINFO.Text = "NO POLICIES FOR TODAY FOUND!";
            }

            
            
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Close();
        }
    }
}
