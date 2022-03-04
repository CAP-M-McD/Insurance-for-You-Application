using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_for_You_Application
{
    class Policy
    {
        private string strPolicyNum;
        private DateTime dtStartDate;
        private string strPolicyStatus;
        private string strFname;
        private string strSname;
        private int intNoClaims;
        private string strOccu;
        private string strVech;
        private string strUsage;
        private string strStorage;
        private List<Drivers> Ldrivers;
        private double dblCost;

        public Policy()
        {
            this.strPolicyNum = " ";
            this.dtStartDate = DateTime.Today;
            this.strPolicyStatus = " ";
            this.strFname = " ";
            this.strSname = " ";
            this.intNoClaims = 0;
            this.strOccu = " ";
            this.strVech = " ";
            this.strUsage = " ";
            this.strStorage = " ";
            this.Ldrivers = new List<Drivers>();
            this.dblCost = 0.00;
        }

        public Policy(string strPolicyNum,DateTime dtStartDate,string strPolicyStatus, string strFname, string strSname, int intNoClaims, string strOccu, string strVech, string strUsage, string strStorage, List<Drivers> Ldrivers, double dblCost)
        {
            this.strPolicyNum = strPolicyNum;
            this.dtStartDate = dtStartDate;
            this.strPolicyStatus = strPolicyStatus;
            this.strFname = strFname;
            this.strSname = strSname;
            this.intNoClaims = intNoClaims;
            this.strOccu = strOccu;
            this.strVech = strVech;
            this.strUsage = strUsage;
            this.strStorage = strStorage;
            this.Ldrivers = Ldrivers;
            this.dblCost = dblCost;
        }

        public string PolicyNum
        {
            get { return strPolicyNum; }
            set { strPolicyNum = value; }
        }

        public DateTime StartDate
        {
            get { return dtStartDate; }
            set { dtStartDate = value; }
        }

        public string PolicyStatus
        {
            get { return strPolicyStatus; }
            set { strPolicyStatus = value; }
        }

        public string Fname
        {
            get { return strFname; }
            set { strFname = value; }
        }

        public string Sname
        {
            get { return strSname; }
            set { strSname = value; }
        }

        public int NoClaims
        {
            get { return intNoClaims; }
            set { intNoClaims = value; }
        }

        public string Occupation
        {
            get { return strOccu; }
            set { strOccu = value; }
        }

        public string Vech
        {
            get { return strVech; }
            set { strVech = value; }
        }

        public string Usage
        {
            get { return strUsage; }
            set { strUsage = value; }
        }

        public string Storage
        {
            get { return strStorage; }
            set { strStorage = value; }
        }

        public List<Drivers> Drivers
        {
            get { return Ldrivers; }
            set { Ldrivers = value; }
        }

        public double Cost
        {
            get { return dblCost; }
            set { dblCost = value; }
        }

        public string policyInfo
        {
            get { return info(); }
        }

        public string info()
        {
            string strPolicyInfo = "";
            string strDrivers = "\r\r\n\nDRIVERS:";
            string strDFName, strDSname, strDOB;

            foreach (Drivers d in Ldrivers)
            {
                strDFName = d.Fname;
                strDSname = d.Sname;
                strDOB = d.DOB;
                strDrivers += ("\r\nDriver Name: " + strDFName + " " + strDSname + "\r\nDriver DOB: " + strDOB + "\r\n");
            }

            strPolicyInfo = "Policy Number: " + strPolicyNum +
                "\r\nPolicy Status: "+ strPolicyStatus +
                "\r\nPolicy Holder First Name: " + strFname +
                "\r\nPolicy Holder Surname: " + strSname +
                "\r\nNumber of Years No Claims: " + intNoClaims + 
                "\r\nOccupation: " + strOccu +
                "\r\nVehicle Type: " + strVech +
                "\r\nVehicle Usage: " + strUsage +
                "\r\nVehicle Stored Overnight: " + strStorage +
                strDrivers +
                "\r\nPolicy Cost: " + dblCost.ToString("C2");           
            


            return strPolicyInfo;
            
        }

    }
}
