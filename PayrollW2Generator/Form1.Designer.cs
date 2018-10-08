namespace PayrollExportConverter
{
    partial class Form1
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
            this.btnReadTestFiles = new System.Windows.Forms.Button();
            this.btnCreateW2 = new System.Windows.Forms.Button();
            this.txtEmployeeFile = new System.Windows.Forms.TextBox();
            this.lblEmployeeFile = new System.Windows.Forms.Label();
            this.lblPayrollFile = new System.Windows.Forms.Label();
            this.txtPayrollFile = new System.Windows.Forms.TextBox();
            this.lblTaxYear = new System.Windows.Forms.Label();
            this.cboTaxYear = new System.Windows.Forms.ComboBox();
            this.chkResubmissions = new System.Windows.Forms.CheckBox();
            this.lblResubID = new System.Windows.Forms.Label();
            this.txtResubID = new System.Windows.Forms.TextBox();
            this.lblEmployeeSupplemental = new System.Windows.Forms.Label();
            this.txtEmployeeSupplemental = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadTestFiles
            // 
            this.btnReadTestFiles.Location = new System.Drawing.Point(12, 12);
            this.btnReadTestFiles.Name = "btnReadTestFiles";
            this.btnReadTestFiles.Size = new System.Drawing.Size(208, 23);
            this.btnReadTestFiles.TabIndex = 0;
            this.btnReadTestFiles.Text = "Read Test Files";
            this.btnReadTestFiles.UseVisualStyleBackColor = true;
            this.btnReadTestFiles.Click += new System.EventHandler(this.btnReadTestFiles_Click);
            // 
            // btnCreateW2
            // 
            this.btnCreateW2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateW2.Location = new System.Drawing.Point(12, 83);
            this.btnCreateW2.Name = "btnCreateW2";
            this.btnCreateW2.Size = new System.Drawing.Size(208, 23);
            this.btnCreateW2.TabIndex = 1;
            this.btnCreateW2.Text = "Create W-2 File";
            this.btnCreateW2.UseVisualStyleBackColor = true;
            this.btnCreateW2.Click += new System.EventHandler(this.btnCreateW2_Click);
            // 
            // txtEmployeeFile
            // 
            this.txtEmployeeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeFile.Location = new System.Drawing.Point(12, 129);
            this.txtEmployeeFile.Name = "txtEmployeeFile";
            this.txtEmployeeFile.Size = new System.Drawing.Size(525, 20);
            this.txtEmployeeFile.TabIndex = 2;
            this.txtEmployeeFile.Text = "EmployeeExport.csv";
            // 
            // lblEmployeeFile
            // 
            this.lblEmployeeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployeeFile.AutoSize = true;
            this.lblEmployeeFile.Location = new System.Drawing.Point(13, 113);
            this.lblEmployeeFile.Name = "lblEmployeeFile";
            this.lblEmployeeFile.Size = new System.Drawing.Size(222, 13);
            this.lblEmployeeFile.TabIndex = 3;
            this.lblEmployeeFile.Text = "Employee File (CSV export from ezPaycheck):";
            // 
            // lblPayrollFile
            // 
            this.lblPayrollFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPayrollFile.AutoSize = true;
            this.lblPayrollFile.Location = new System.Drawing.Point(13, 211);
            this.lblPayrollFile.Name = "lblPayrollFile";
            this.lblPayrollFile.Size = new System.Drawing.Size(354, 13);
            this.lblPayrollFile.TabIndex = 5;
            this.lblPayrollFile.Text = "Payroll File (CSV export from ezPaycheck):  MUST BE SORTED BY SSN!";
            // 
            // txtPayrollFile
            // 
            this.txtPayrollFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayrollFile.Location = new System.Drawing.Point(12, 227);
            this.txtPayrollFile.Name = "txtPayrollFile";
            this.txtPayrollFile.Size = new System.Drawing.Size(525, 20);
            this.txtPayrollFile.TabIndex = 4;
            this.txtPayrollFile.Text = "PayrollExport.csv";
            // 
            // lblTaxYear
            // 
            this.lblTaxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTaxYear.AutoSize = true;
            this.lblTaxYear.Location = new System.Drawing.Point(13, 255);
            this.lblTaxYear.Name = "lblTaxYear";
            this.lblTaxYear.Size = new System.Drawing.Size(53, 13);
            this.lblTaxYear.TabIndex = 6;
            this.lblTaxYear.Text = "Tax Year:";
            // 
            // cboTaxYear
            // 
            this.cboTaxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTaxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaxYear.FormattingEnabled = true;
            this.cboTaxYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboTaxYear.Location = new System.Drawing.Point(72, 252);
            this.cboTaxYear.Name = "cboTaxYear";
            this.cboTaxYear.Size = new System.Drawing.Size(121, 21);
            this.cboTaxYear.TabIndex = 7;
            // 
            // chkResubmissions
            // 
            this.chkResubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkResubmissions.AutoSize = true;
            this.chkResubmissions.Location = new System.Drawing.Point(234, 254);
            this.chkResubmissions.Name = "chkResubmissions";
            this.chkResubmissions.Size = new System.Drawing.Size(91, 17);
            this.chkResubmissions.TabIndex = 8;
            this.chkResubmissions.Text = "Resubmission";
            this.chkResubmissions.UseVisualStyleBackColor = true;
            // 
            // lblResubID
            // 
            this.lblResubID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResubID.AutoSize = true;
            this.lblResubID.Location = new System.Drawing.Point(342, 255);
            this.lblResubID.Name = "lblResubID";
            this.lblResubID.Size = new System.Drawing.Size(55, 13);
            this.lblResubID.TabIndex = 9;
            this.lblResubID.Text = "Resub ID:";
            // 
            // txtResubID
            // 
            this.txtResubID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResubID.Location = new System.Drawing.Point(403, 252);
            this.txtResubID.Name = "txtResubID";
            this.txtResubID.Size = new System.Drawing.Size(55, 20);
            this.txtResubID.TabIndex = 10;
            // 
            // lblEmployeeSupplemental
            // 
            this.lblEmployeeSupplemental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployeeSupplemental.AutoSize = true;
            this.lblEmployeeSupplemental.Location = new System.Drawing.Point(13, 161);
            this.lblEmployeeSupplemental.Name = "lblEmployeeSupplemental";
            this.lblEmployeeSupplemental.Size = new System.Drawing.Size(270, 13);
            this.lblEmployeeSupplemental.TabIndex = 12;
            this.lblEmployeeSupplemental.Text = "Employee Supplemental File (CSV manually maintained):";
            // 
            // txtEmployeeSupplemental
            // 
            this.txtEmployeeSupplemental.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeSupplemental.Location = new System.Drawing.Point(12, 177);
            this.txtEmployeeSupplemental.Name = "txtEmployeeSupplemental";
            this.txtEmployeeSupplemental.Size = new System.Drawing.Size(525, 20);
            this.txtEmployeeSupplemental.TabIndex = 11;
            this.txtEmployeeSupplemental.Text = "EmployeeSupplemental.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 289);
            this.Controls.Add(this.lblEmployeeSupplemental);
            this.Controls.Add(this.txtEmployeeSupplemental);
            this.Controls.Add(this.txtResubID);
            this.Controls.Add(this.lblResubID);
            this.Controls.Add(this.chkResubmissions);
            this.Controls.Add(this.cboTaxYear);
            this.Controls.Add(this.lblTaxYear);
            this.Controls.Add(this.lblPayrollFile);
            this.Controls.Add(this.txtPayrollFile);
            this.Controls.Add(this.lblEmployeeFile);
            this.Controls.Add(this.txtEmployeeFile);
            this.Controls.Add(this.btnCreateW2);
            this.Controls.Add(this.btnReadTestFiles);
            this.Name = "Form1";
            this.Text = "Read Exports And Create W-2 File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadTestFiles;
        private System.Windows.Forms.Button btnCreateW2;
        private System.Windows.Forms.TextBox txtEmployeeFile;
        private System.Windows.Forms.Label lblEmployeeFile;
        private System.Windows.Forms.Label lblPayrollFile;
        private System.Windows.Forms.TextBox txtPayrollFile;
        private System.Windows.Forms.Label lblTaxYear;
        private System.Windows.Forms.ComboBox cboTaxYear;
        private System.Windows.Forms.CheckBox chkResubmissions;
        private System.Windows.Forms.Label lblResubID;
        private System.Windows.Forms.TextBox txtResubID;
        private System.Windows.Forms.Label lblEmployeeSupplemental;
        private System.Windows.Forms.TextBox txtEmployeeSupplemental;
    }
}

