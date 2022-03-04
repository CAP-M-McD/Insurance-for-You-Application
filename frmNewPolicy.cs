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
    public partial class frmNewPolicy : Form
    {
        private List<Drivers> LDrivers = new List<Drivers>();
        private List<Jobs> LJobs = new List<Jobs>();
        private List<Cars> LCars = new List<Cars>();
        Policy pCurrent = new Policy();

        public frmNewPolicy()
        {
            InitializeComponent();

            string line;

            //Reading in JobList.csv and putting data into job objects which are stored in a list & Loading Jobs into Occupation comboBox    
            StreamReader joblist = File.OpenText("JobList.csv");                   
            while(!joblist.EndOfStream)
            {
                line = joblist.ReadLine();
                string[] values = line.Split(',');
                string strJob = values[0];
                cbOccu.Items.Add(values[0]); //Loading Jobs into Occupation comboBox 
                string strPercent = values[1];
                Jobs job = new Jobs(strJob, strPercent);
                LJobs.Add(job);
            }
            joblist.Close();
            //Reading in CarInsuranceCategories.csv and putting data into Car objects which are stored in a list & Loading Cars into Vehicle comboBox  
            StreamReader carCategor = File.OpenText("CarInsuranceCategories.csv");
            while (!carCategor.EndOfStream)
            {
                line = carCategor.ReadLine();
                string[] values = line.Split(',');
                string strCar = values[0];
                cbVehicle.Items.Add(values[0]); //Loading Cars into Vehicle comboBox  
                string strPercent = values[1];
                Cars carCat = new Cars(strCar, strPercent);
                LCars.Add(carCat);
            }
            carCategor.Close();

        }

        private void frmNewPolicy_Load(object sender, EventArgs e)
        {

        }

        private void btnQuote_Click(object sender, EventArgs e)
        {

            Boolean bolValidInps = policyInputValid();
            double dblCost;
            frmWelcome mainMenu = new frmWelcome();


            if(bolValidInps == true)
            {
                policyInput();
                dblCost = pCurrent.Cost;//Allowing user to also accept or decline policy thus updating status
                var vCorrectInfo = MessageBox.Show("Does the Below information Look Correct?\n\n"+pCurrent.policyInfo, "Is this Information Correct?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(vCorrectInfo == DialogResult.Yes)
                {
                    var vAcceptPolicy = MessageBox.Show("Do you Accept this Policy Quoted at the below cost\n" + dblCost.ToString("C2"), "Do you Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if(vAcceptPolicy == DialogResult.Yes)
                    {
                        MessageBox.Show("User Accepted Policy at Quoted Price: " + dblCost.ToString("C2") + ", Adding to database!", "User Accepted Policy!", MessageBoxButtons.OK);
                        savingPolicy();
                        mainMenu.Show();
                        this.Close();                        
                    }
                    else if(vAcceptPolicy == DialogResult.No)
                    {
                        MessageBox.Show("User Declined Policy at Quoted Price: " + dblCost.ToString("C2") + ", Adding to database!", "User Declined Policy!", MessageBoxButtons.OK);
                        pCurrent.PolicyStatus = "Held";
                        savingPolicy();
                        mainMenu.Show();
                        this.Close();
                    }
                
                }

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Declaring Variables and getting driver information
            string strFname, strSname, strDOB;            
            strFname = txtDFirstName.Text;
            strSname = txtDSurname.Text;
            strDOB = dpDOB.Value.ToString("dd-MM-yyyy");
            
            //Calculating Age
            int intAge = 0;
            DateTime dtDOB = dpDOB.Value;
            DateTime dtStartPol = dpSDate.Value;
            intAge = dtStartPol.Year - dtDOB.Year;
            if (dtStartPol.Month <= dtDOB.Month && dtStartPol.Day < dtDOB.Day)
            {
                intAge--;
            }

           
            if (intAge<18)
            {
                MessageBox.Show("Driver Must be over 18 for a Policy", "Must be 18 or Over",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                dpDOB.Focus();                
            }
            //Adding Costume Validation as its not indvidual validating in main validating method as it only looks at if there are drivers added
            else if(strFname== string.Empty)
            {
                txtDFirstName.Focus();
                MessageBox.Show("Enter A Forename for Driver!", "Enter Forename",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (strSname == string.Empty)
            {
                txtDFirstName.Focus();
                MessageBox.Show("Enter A Surname for Driver!","Enter Surname",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Drivers dInput = new Drivers(strFname, strDOB, strSname); //Creating a driver and then inputting to the list if all data is correctly collected
                LDrivers.Add(dInput);
                txtDFirstName.Clear();
                txtDSurname.Clear();
                dpDOB.ResetText();
                txtDFirstName.Focus();                
            }                            
            
        } 
        

        private void btnCancel_Click(object sender, EventArgs e)
        {                   
            var varAnswer = MessageBox.Show("Are you sure you want to Cancel this Policy Quote?", "Cancel Policy Quote", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (varAnswer == DialogResult.Yes)
            {
                frmWelcome mainMenu = new frmWelcome();
                mainMenu.Show();
                this.Close();
            }

        }      

      
        public Boolean policyInputValid()
        {
            Boolean bolAnswer = false;
            string strJob = "0000";

            foreach (Jobs j in LJobs) //comparing all jobs to see if job entered is one stored
            {
                if (j.JobTitle.ToUpper() == cbOccu.Text.ToUpper())
                {
                    strJob = cbOccu.Text;
                }
            }

            if (dpSDate.Value < DateTime.Today || (dpSDate.Value.Day == DateTime.Today.Day && dpSDate.Value.Month == DateTime.Today.Month && dpSDate.Value.Year == DateTime.Today.Year)) //Checking the startdate compared today so that its after today           
            {
                MessageBox.Show("Start Date must be after Today's Date!", "Start Date Must be in Future!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dpSDate.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Enter a First Name for Policy Holder!", "Enter First Name!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFirstName.Focus();
            }
            else if (txtSurname.Text == "" || txtSurname.Text.Length<3)
            {
                MessageBox.Show("Enter a Surname for Policy Holder!", "Enter Surname!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSurname.Focus();
            }
            else if (cbNoClaims.Text == "" || !(cbNoClaims.SelectedIndex>=0 && cbNoClaims.SelectedIndex<=6))
            {
                MessageBox.Show("Select a No Claims Year amount within it's limits!", "Select NoClaims!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbNoClaims.Focus();
            }
            else if(cbOccu.Text ==""||!(cbOccu.Text==strJob))
            {
                MessageBox.Show("Select an Occupation!", "Select an Occupation!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbOccu.Focus();
            }
            else if(cbVehicle.Text =="")
            {
                MessageBox.Show("Select a Car from List!", "Select Car from List!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbVehicle.Focus();
            }
            else if (cbUsage.Text == "" || !(cbUsage.SelectedIndex >= 0 && cbUsage.SelectedIndex <= 2))
            {
                MessageBox.Show("Select a Car Usage from List!", "Select Usage from List!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbUsage.Focus();
            }
            else if (cbStorage.Text == "" || !(cbStorage.SelectedIndex >= 0 && cbStorage.SelectedIndex <= 2))
            {
                MessageBox.Show("Select Car storage location from list!", "Select Car storage from list!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbStorage.Focus();
            }
            else if (LDrivers.Count<=0)           
            {
                MessageBox.Show("Enter Driver details and Press Add!", "Enter Drivers!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDFirstName.Focus();
            }
            else
            {
                bolAnswer = true; // if all are valid and have something entered then this should run and allow policy to move forward 
            }

            return (bolAnswer);
        }

        //Inputting all information from the form fields
        public void policyInput()
        {
            //All local variables declared for using to create a policy object for setting the global policy object which will be used throughout class 
            string strPolicyNum,strPolicyStatus, strFname, strSname, strOccu, strVech, strUsage, strStorage;
            int intNoClaims;
            double dblCost;
            DateTime dtStartDate;

            //Getting all inputs from form fields, which will have been validated to have correct information entered before moving forward to this stage
            strFname = txtFirstName.Text;
            strPolicyStatus = "";
            dtStartDate = dpSDate.Value;
            strSname = txtSurname.Text;
            int.TryParse(cbNoClaims.Text, out intNoClaims);
            strOccu = cbOccu.Text;
            strVech = cbVehicle.Text;
            strUsage = cbUsage.Text;
            strStorage = cbStorage.Text;
            dblCost = PolicyProcess();

            //Checking which Policy Status was chosen when policy was processed (PolicyProccess Method) and then adding it into a local variable to ensure its not over written
            if (pCurrent.PolicyStatus == "Held")
            {
                strPolicyStatus = "Held";
                
            }
            else if (pCurrent.PolicyStatus == "Investigate")
            {
                strPolicyStatus = "Investigate";
            }
            else if (pCurrent.PolicyStatus == "Processed")
            {
                strPolicyStatus = "Processed";
            }

            //Generating a Policy Number using the time and surname
            string timeStamp = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            strPolicyNum = strSname.Substring(0, 3).ToUpper() + timeStamp;

            //Creating a tempory object to set pCurrent to our focused policy 
            Policy newPolicy = new Policy(strPolicyNum,dtStartDate,strPolicyStatus, strFname, strSname, intNoClaims, strOccu, strVech, strUsage, strStorage, LDrivers, dblCost);
            pCurrent = newPolicy;
        }

        //Saving the Policy pCurrent to a CSV after all the correct methods have been used to populate it with the inputted data       
        public void savingPolicy()
        {
            //Declaing variables and needing data for saving to CSV
            string strDate = DateTime.Today.ToString("dd-MM-yyyy");
            string strFilePath = "policies_" + strDate + ".csv";
            string strDrivers = "";
            string strDelimiter = ",";
            StringBuilder sb = new StringBuilder();

            //Getting all drivers into a format I can use to split them when loading them back into a class/form
            foreach (Drivers d in pCurrent.Drivers)
            {
                strDrivers += (d.Fname + "%" + d.Sname + "%" + d.DOB + "%");
            }

            //Taking all information from global policy object which would have been populated from the PolicyInput Method
            sb.AppendLine(pCurrent.PolicyNum + strDelimiter + pCurrent.StartDate.ToString() + strDelimiter + pCurrent.PolicyStatus + strDelimiter + pCurrent.Fname + strDelimiter + pCurrent.Sname + strDelimiter + pCurrent.NoClaims + strDelimiter + pCurrent.Occupation + strDelimiter + pCurrent.Vech + strDelimiter + pCurrent.Usage + strDelimiter + pCurrent.Storage + strDelimiter + strDrivers + strDelimiter + pCurrent.Cost + strDelimiter);
           
            //Saving to the CSV file with the Created file path 
            File.AppendAllText(strFilePath, sb.ToString());
        }

        //Used for calculating the Policy Quote Cost, and also deciding the policy status depending on inputting information. 
        public double PolicyProcess()
        {
            //Declaring Variables 
            double dblFinalCost = 300.00; //starting premium at 300
            int intCarPer, intOccuPer, intAgeMin, intAgeMax, intNoClaims;
            intCarPer = 0;
            intOccuPer = 0;
            intAgeMin = 1000;
            intAgeMax = 0;
            intNoClaims = 0;
            string strVehType = "TEST";//if this doesn't change then the option entered isnt a vehicle in list
            int.TryParse(cbNoClaims.Text, out intNoClaims); 

            //Going through all Car objects to find match to one selected
            foreach (Cars c in LCars) //Getting the Percentage increase for the car
            {
                if (c.CarType == cbVehicle.Text)
                {
                    intCarPer = int.Parse(c.CarPercent);
                    strVehType = cbVehicle.Text;
                    
                }               
             
            }
            //If no car has been selected of not in list then status updated to investgated
            if (!(cbVehicle.Text == strVehType)|| cbVehicle.Text =="")
            {
                dblFinalCost = 0;
                pCurrent.PolicyStatus = "Investigate"; //Including this to turn any cost calculated to 0 as to not calculate a premium and to set the status to investigate why the car isnt on the list.
                MessageBox.Show("Policy Under Investigation due to no matching Vehicle\nPolicy will be reviewed Later", "Policy Under Investigation",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

            //Going through all job objects 
            foreach (Jobs j in LJobs) //Getting the percentage increase for the job
            {
                if (j.JobTitle == cbOccu.Text)
                {
                    intOccuPer = int.Parse(j.JobPercent);
                }
            }
                        
            dblFinalCost += dblFinalCost * (intCarPer / 100.00);//Appling car increase

            //Checking for increase due to storage
            if (cbStorage.Text == "Public road")
            {
                dblFinalCost += dblFinalCost * 0.1;
            }
            else if (cbStorage.Text == "Private drive")
            {
                dblFinalCost += dblFinalCost * 0.05;
            }

            //Applying Occupation increase
            dblFinalCost += dblFinalCost * (intOccuPer / 100.00);

            //checking for usage increase 
            if (cbUsage.Text == "Business")
            {
                dblFinalCost += dblFinalCost * 0.1;
            }
            else if (cbUsage.Text == "Social and Commuting")
            {
                dblFinalCost += dblFinalCost * 0.05;
            }
            
            int intAge = 0;

            //getting the min and max ages at the start date of the policy for each driver and storing them as a running total to find the overall min and max ages
            foreach (Drivers d in LDrivers)
            {
                
                DateTime dtDOB = DateTime.Parse(d.DOB);
                DateTime dtStartPol = dpSDate.Value;
                intAge = dtStartPol.Year - dtDOB.Year;
                if (dtStartPol.Month <= dtDOB.Month && dtStartPol.Day < dtDOB.Day)
                {
                    intAge--;
                }

                if (intAge < 21)
                {
                    pCurrent.PolicyStatus = "Held";
                    MessageBox.Show("Policy Declined due to a Driver being to Young\nPolicy will be reviewed Later", "Policy Declined", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (intAge > 75)
                {
                    pCurrent.PolicyStatus = "Held";
                    MessageBox.Show("Policy Declined due to a Driver being to Old\nPolicy will be reviewed Later", "Policy Declined", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }

            //Comparing ages to check they're within the specified limits 
            if (intAgeMin >= 21 && intAgeMin <= 25)
            {
                dblFinalCost += dblFinalCost * 0.2;
            }
            else if (intAgeMin >= 26 && intAgeMax <= 75)
            {
                dblFinalCost -= dblFinalCost * 0.1;
            }

            //Checking if the policy needs to be declined
         

            //If the status hasn't been affected throughout the method it is fine to be labelled processed 
            if (pCurrent.PolicyStatus == " ")
            {
                pCurrent.PolicyStatus = "Processed";
                MessageBox.Show("Policy Approved\nPolicy will be further reviewed Later", "Policy Approved", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //Appling no claims discount decrease 
            dblFinalCost -= dblFinalCost *(intNoClaims/100.00);
            
            //returning result 
            return (dblFinalCost);
        }
    }     
 }

