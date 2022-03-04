using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_for_You_Application
{
    class Drivers
    {
        private string strFname;
        private string strSname;
        private string strDOB;

        public Drivers()
        {
            this.strFname = " ";
            this.strDOB = " ";
            this.strSname = " ";
        }
        
        public Drivers(string strFname, string strDOB, string strSname)
        {
            this.strFname = strFname;
            this.strSname = strSname;
            this.strDOB = strDOB;
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

        public string DOB
        {
            get { return strDOB; }
            set { strDOB = value; }
        }

        public int age
        {
            get { return ageCalc(); }            
        }

        private int ageCalc()
        {
            int intAge;
            intAge = 0;
            DateTime dtDOB = DateTime.Parse(strDOB);
            DateTime dtToday = DateTime.Today;
            intAge = dtToday.Year - dtDOB.Year;
            if (dtToday.Month <= dtDOB.Month && dtToday.Day < dtDOB.Day) 
            {
                intAge--;
            }

            return (intAge);
            
        }

    }
}
