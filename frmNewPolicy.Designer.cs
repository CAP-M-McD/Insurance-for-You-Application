
namespace Insurance_for_You_Application
{
    partial class frmNewPolicy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOccu = new System.Windows.Forms.Label();
            this.lblVech = new System.Windows.Forms.Label();
            this.lblUse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpSDate = new System.Windows.Forms.DateTimePicker();
            this.lblNoClaims = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cbNoClaims = new System.Windows.Forms.ComboBox();
            this.cbOccu = new System.Windows.Forms.ComboBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.cbUsage = new System.Windows.Forms.ComboBox();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.lblPolicyInfo = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDriverInfo = new System.Windows.Forms.Label();
            this.txtDSurname = new System.Windows.Forms.TextBox();
            this.lblDSurname = new System.Windows.Forms.Label();
            this.txtDFirstName = new System.Windows.Forms.TextBox();
            this.lblDFName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(153, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "New Insurance Quote";
            // 
            // lblSDate
            // 
            this.lblSDate.AutoSize = true;
            this.lblSDate.Location = new System.Drawing.Point(19, 84);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(98, 13);
            this.lblSDate.TabIndex = 9;
            this.lblSDate.Text = "Enter a Start Date: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Enter First Name:";
            // 
            // lblOccu
            // 
            this.lblOccu.AutoSize = true;
            this.lblOccu.Location = new System.Drawing.Point(19, 211);
            this.lblOccu.Name = "lblOccu";
            this.lblOccu.Size = new System.Drawing.Size(101, 13);
            this.lblOccu.TabIndex = 11;
            this.lblOccu.Text = "Select Occupation: ";
            // 
            // lblVech
            // 
            this.lblVech.AutoSize = true;
            this.lblVech.Location = new System.Drawing.Point(19, 254);
            this.lblVech.Name = "lblVech";
            this.lblVech.Size = new System.Drawing.Size(81, 13);
            this.lblVech.TabIndex = 12;
            this.lblVech.Text = "Select Vehicle: ";
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Location = new System.Drawing.Point(19, 297);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(77, 13);
            this.lblUse.TabIndex = 13;
            this.lblUse.Text = "Select Usage: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Where is the Vechicle stored: ";
            // 
            // dpSDate
            // 
            this.dpSDate.Location = new System.Drawing.Point(190, 84);
            this.dpSDate.Name = "dpSDate";
            this.dpSDate.Size = new System.Drawing.Size(130, 20);
            this.dpSDate.TabIndex = 1;
            // 
            // lblNoClaims
            // 
            this.lblNoClaims.AutoSize = true;
            this.lblNoClaims.Location = new System.Drawing.Point(19, 168);
            this.lblNoClaims.Name = "lblNoClaims";
            this.lblNoClaims.Size = new System.Drawing.Size(142, 13);
            this.lblNoClaims.TabIndex = 16;
            this.lblNoClaims.Text = "Number of Years No Claims: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(190, 126);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // cbNoClaims
            // 
            this.cbNoClaims.FormattingEnabled = true;
            this.cbNoClaims.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbNoClaims.Location = new System.Drawing.Point(190, 168);
            this.cbNoClaims.Name = "cbNoClaims";
            this.cbNoClaims.Size = new System.Drawing.Size(48, 21);
            this.cbNoClaims.TabIndex = 4;
            // 
            // cbOccu
            // 
            this.cbOccu.FormattingEnabled = true;
            this.cbOccu.Location = new System.Drawing.Point(190, 211);
            this.cbOccu.Name = "cbOccu";
            this.cbOccu.Size = new System.Drawing.Size(200, 21);
            this.cbOccu.TabIndex = 5;
            // 
            // cbVehicle
            // 
            this.cbVehicle.AllowDrop = true;
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(190, 254);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(247, 21);
            this.cbVehicle.TabIndex = 6;
            // 
            // cbUsage
            // 
            this.cbUsage.FormattingEnabled = true;
            this.cbUsage.Items.AddRange(new object[] {
            "Social domestic pleasure",
            "Social and Commuting ",
            "Business"});
            this.cbUsage.Location = new System.Drawing.Point(190, 297);
            this.cbUsage.Name = "cbUsage";
            this.cbUsage.Size = new System.Drawing.Size(200, 21);
            this.cbUsage.TabIndex = 7;
            // 
            // cbStorage
            // 
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Items.AddRange(new object[] {
            "Public road",
            "Private drive",
            "Garage "});
            this.cbStorage.Location = new System.Drawing.Point(190, 340);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(200, 21);
            this.cbStorage.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(430, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel Quote";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(201, 558);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Driver";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.Location = new System.Drawing.Point(12, 558);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(119, 36);
            this.btnQuote.TabIndex = 13;
            this.btnQuote.Text = "Get Quote";
            this.btnQuote.UseVisualStyleBackColor = false;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // lblPolicyInfo
            // 
            this.lblPolicyInfo.AutoSize = true;
            this.lblPolicyInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPolicyInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPolicyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyInfo.Location = new System.Drawing.Point(206, 46);
            this.lblPolicyInfo.Name = "lblPolicyInfo";
            this.lblPolicyInfo.Size = new System.Drawing.Size(115, 18);
            this.lblPolicyInfo.TabIndex = 27;
            this.lblPolicyInfo.Text = "Policy Information";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(421, 126);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(114, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter Surname:";
            // 
            // lblDriverInfo
            // 
            this.lblDriverInfo.AutoSize = true;
            this.lblDriverInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDriverInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDriverInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverInfo.Location = new System.Drawing.Point(206, 388);
            this.lblDriverInfo.Name = "lblDriverInfo";
            this.lblDriverInfo.Size = new System.Drawing.Size(114, 18);
            this.lblDriverInfo.TabIndex = 30;
            this.lblDriverInfo.Text = "Driver Information";
            // 
            // txtDSurname
            // 
            this.txtDSurname.Location = new System.Drawing.Point(302, 469);
            this.txtDSurname.Name = "txtDSurname";
            this.txtDSurname.Size = new System.Drawing.Size(135, 20);
            this.txtDSurname.TabIndex = 10;
            // 
            // lblDSurname
            // 
            this.lblDSurname.AutoSize = true;
            this.lblDSurname.Location = new System.Drawing.Point(119, 472);
            this.lblDSurname.Name = "lblDSurname";
            this.lblDSurname.Size = new System.Drawing.Size(111, 13);
            this.lblDSurname.TabIndex = 33;
            this.lblDSurname.Text = "Enter Driver Surname:";
            // 
            // txtDFirstName
            // 
            this.txtDFirstName.Location = new System.Drawing.Point(302, 441);
            this.txtDFirstName.Name = "txtDFirstName";
            this.txtDFirstName.Size = new System.Drawing.Size(135, 20);
            this.txtDFirstName.TabIndex = 9;
            // 
            // lblDFName
            // 
            this.lblDFName.AutoSize = true;
            this.lblDFName.Location = new System.Drawing.Point(119, 441);
            this.lblDFName.Name = "lblDFName";
            this.lblDFName.Size = new System.Drawing.Size(119, 13);
            this.lblDFName.TabIndex = 31;
            this.lblDFName.Text = "Enter Driver First Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(119, 504);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(170, 13);
            this.lblDOB.TabIndex = 35;
            this.lblDOB.Text = "Enter Driver DOB(DD/MM/YYYY):";
            // 
            // dpDOB
            // 
            this.dpDOB.Location = new System.Drawing.Point(302, 498);
            this.dpDOB.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(130, 20);
            this.dpDOB.TabIndex = 11;
            this.dpDOB.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(87, 414);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(400, 13);
            this.lblDescrip.TabIndex = 36;
            this.lblDescrip.Text = "Press Add Driver to Add Drivers to Policy, and Get Quote once all drivers are add" +
    "ed";
            // 
            // frmNewPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 608);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.dpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtDSurname);
            this.Controls.Add(this.lblDSurname);
            this.Controls.Add(this.txtDFirstName);
            this.Controls.Add(this.lblDFName);
            this.Controls.Add(this.lblDriverInfo);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPolicyInfo);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbStorage);
            this.Controls.Add(this.cbUsage);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.cbOccu);
            this.Controls.Add(this.cbNoClaims);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblNoClaims);
            this.Controls.Add(this.dpSDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUse);
            this.Controls.Add(this.lblVech);
            this.Controls.Add(this.lblOccu);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNewPolicy";
            this.Text = "New Quote | Insurance for you!";
            this.Load += new System.EventHandler(this.frmNewPolicy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOccu;
        private System.Windows.Forms.Label lblVech;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpSDate;
        private System.Windows.Forms.Label lblNoClaims;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cbOccu;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.ComboBox cbUsage;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Label lblPolicyInfo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDriverInfo;
        private System.Windows.Forms.TextBox txtDSurname;
        private System.Windows.Forms.Label lblDSurname;
        private System.Windows.Forms.TextBox txtDFirstName;
        private System.Windows.Forms.Label lblDFName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dpDOB;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.ComboBox cbNoClaims;
    }
}