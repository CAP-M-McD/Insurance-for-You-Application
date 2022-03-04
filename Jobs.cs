using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_for_You_Application
{
    class Jobs
    {
        private string strJobTitle;
        private string strJobPercent;

        public Jobs()
        {
            this.strJobTitle = " ";
            this.strJobPercent = " ";
        }

        public Jobs(string strJobTitle, string strJobPercent)
        {
            this.strJobTitle = strJobTitle;
            this.strJobPercent = strJobPercent;
        }

        public string JobTitle
        {
            get { return strJobTitle; }
            set { strJobTitle = value; }
        }

        public string JobPercent
        {
            get { return strJobPercent; }
            set { strJobPercent = value; }
        }

    }
}
