
namespace Insurance_for_You_Application
{
    partial class frmWelcome
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
            this.btnNewPolicy = new System.Windows.Forms.Button();
            this.btnAdminLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(63, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Insurance for You!";
            // 
            // btnNewPolicy
            // 
            this.btnNewPolicy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPolicy.Location = new System.Drawing.Point(120, 67);
            this.btnNewPolicy.Name = "btnNewPolicy";
            this.btnNewPolicy.Size = new System.Drawing.Size(233, 36);
            this.btnNewPolicy.TabIndex = 1;
            this.btnNewPolicy.Text = "New Policy";
            this.btnNewPolicy.UseVisualStyleBackColor = false;
            this.btnNewPolicy.Click += new System.EventHandler(this.btnNewPolicy_Click);
            // 
            // btnAdminLog
            // 
            this.btnAdminLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLog.Location = new System.Drawing.Point(120, 128);
            this.btnAdminLog.Name = "btnAdminLog";
            this.btnAdminLog.Size = new System.Drawing.Size(233, 36);
            this.btnAdminLog.TabIndex = 2;
            this.btnAdminLog.Text = "Admin Login";
            this.btnAdminLog.UseVisualStyleBackColor = false;
            this.btnAdminLog.Click += new System.EventHandler(this.btnAdminLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(120, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 284);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdminLog);
            this.Controls.Add(this.btnNewPolicy);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmWelcome";
            this.Text = "Welcome | Insurance for you!";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewPolicy;
        private System.Windows.Forms.Button btnAdminLog;
        private System.Windows.Forms.Button btnExit;
    }
}

