using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_for_You_Application
{
    class Cars
    {
        private string strCarType;
        private string strCarPercent;

        public Cars()
        {
            this.strCarType = " ";
            this.strCarPercent = " ";
        }

        public Cars(string strCarType, string strCarPercent)
        {
            this.strCarType= strCarType;
            this.strCarPercent = strCarPercent;
        }

        public string CarType
        {
            get { return strCarType; }
            set { strCarType = value; }
        }

        public string CarPercent
        {
            get { return strCarPercent; }
            set { strCarPercent = value; }
        }
    }
}
