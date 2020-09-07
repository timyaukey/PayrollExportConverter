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
            this.dlgTaxFilingsFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblTaxFilingsFolder = new System.Windows.Forms.Label();
            this.lblStatewideTransitFiles = new System.Windows.Forms.Label();
            this.txtStatewideTransitQ1 = new System.Windows.Forms.TextBox();
            this.txtStatewideTransitQ2 = new System.Windows.Forms.TextBox();
            this.txtStatewideTransitQ3 = new System.Windows.Forms.TextBox();
            this.txtStatewideTransitQ4 = new System.Windows.Forms.TextBox();
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
            this.btnCreateW2.Location = new System.Drawing.Point(12, 95);
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
            this.txtEmployeeFile.Location = new System.Drawing.Point(12, 141);
            this.txtEmployeeFile.Name = "txtEmployeeFile";
            this.txtEmployeeFile.Size = new System.Drawing.Size(655, 20);
            this.txtEmployeeFile.TabIndex = 2;
            this.txtEmployeeFile.Text = "EmployeeExport.csv";
            // 
            // lblEmployeeFile
            // 
            this.lblEmployeeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployeeFile.AutoSize = true;
            this.lblEmployeeFile.Location = new System.Drawing.Point(13, 125);
            this.lblEmployeeFile.Name = "lblEmployeeFile";
            this.lblEmployeeFile.Size = new System.Drawing.Size(222, 13);
            this.lblEmployeeFile.TabIndex = 3;
            this.lblEmployeeFile.Text = "Employee File (CSV export from ezPaycheck):";
            // 
            // lblPayrollFile
            // 
            this.lblPayrollFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPayrollFile.AutoSize = true;
            this.lblPayrollFile.Location = new System.Drawing.Point(13, 223);
            this.lblPayrollFile.Name = "lblPayrollFile";
            this.lblPayrollFile.Size = new System.Drawing.Size(354, 13);
            this.lblPayrollFile.TabIndex = 5;
            this.lblPayrollFile.Text = "Payroll File (CSV export from ezPaycheck):  MUST BE SORTED BY SSN!";
            // 
            // txtPayrollFile
            // 
            this.txtPayrollFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayrollFile.Location = new System.Drawing.Point(12, 239);
            this.txtPayrollFile.Name = "txtPayrollFile";
            this.txtPayrollFile.Size = new System.Drawing.Size(655, 20);
            this.txtPayrollFile.TabIndex = 4;
            this.txtPayrollFile.Text = "PayrollExport.csv";
            // 
            // lblTaxYear
            // 
            this.lblTaxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTaxYear.AutoSize = true;
            this.lblTaxYear.Location = new System.Drawing.Point(17, 436);
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
            this.cboTaxYear.Location = new System.Drawing.Point(76, 433);
            this.cboTaxYear.Name = "cboTaxYear";
            this.cboTaxYear.Size = new System.Drawing.Size(121, 21);
            this.cboTaxYear.TabIndex = 7;
            this.cboTaxYear.SelectedIndexChanged += new System.EventHandler(this.cboTaxYear_SelectedIndexChanged);
            // 
            // chkResubmissions
            // 
            this.chkResubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkResubmissions.AutoSize = true;
            this.chkResubmissions.Location = new System.Drawing.Point(238, 435);
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
            this.lblResubID.Location = new System.Drawing.Point(346, 436);
            this.lblResubID.Name = "lblResubID";
            this.lblResubID.Size = new System.Drawing.Size(55, 13);
            this.lblResubID.TabIndex = 9;
            this.lblResubID.Text = "Resub ID:";
            // 
            // txtResubID
            // 
            this.txtResubID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResubID.Location = new System.Drawing.Point(407, 433);
            this.txtResubID.Name = "txtResubID";
            this.txtResubID.Size = new System.Drawing.Size(55, 20);
            this.txtResubID.TabIndex = 10;
            // 
            // lblEmployeeSupplemental
            // 
            this.lblEmployeeSupplemental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployeeSupplemental.AutoSize = true;
            this.lblEmployeeSupplemental.Location = new System.Drawing.Point(13, 173);
            this.lblEmployeeSupplemental.Name = "lblEmployeeSupplemental";
            this.lblEmployeeSupplemental.Size = new System.Drawing.Size(270, 13);
            this.lblEmployeeSupplemental.TabIndex = 12;
            this.lblEmployeeSupplemental.Text = "Employee Supplemental File (CSV manually maintained):";
            // 
            // txtEmployeeSupplemental
            // 
            this.txtEmployeeSupplemental.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeSupplemental.Location = new System.Drawing.Point(12, 189);
            this.txtEmployeeSupplemental.Name = "txtEmployeeSupplemental";
            this.txtEmployeeSupplemental.Size = new System.Drawing.Size(655, 20);
            this.txtEmployeeSupplemental.TabIndex = 11;
            this.txtEmployeeSupplemental.Text = "EmployeeSupplemental.csv";
            // 
            // dlgTaxFilingsFolder
            // 
            this.dlgTaxFilingsFolder.ShowNewFolderButton = false;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(12, 54);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(208, 23);
            this.btnChooseFolder.TabIndex = 13;
            this.btnChooseFolder.Text = "Choose Tax Filings Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblTaxFilingsFolder
            // 
            this.lblTaxFilingsFolder.AutoSize = true;
            this.lblTaxFilingsFolder.Location = new System.Drawing.Point(226, 59);
            this.lblTaxFilingsFolder.Name = "lblTaxFilingsFolder";
            this.lblTaxFilingsFolder.Size = new System.Drawing.Size(150, 13);
            this.lblTaxFilingsFolder.TabIndex = 14;
            this.lblTaxFilingsFolder.Text = "C:\\Dropbox\\Payroll\\TaxFilings";
            // 
            // lblStatewideTransitFiles
            // 
            this.lblStatewideTransitFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatewideTransitFiles.AutoSize = true;
            this.lblStatewideTransitFiles.Location = new System.Drawing.Point(13, 276);
            this.lblStatewideTransitFiles.Name = "lblStatewideTransitFiles";
            this.lblStatewideTransitFiles.Size = new System.Drawing.Size(233, 13);
            this.lblStatewideTransitFiles.TabIndex = 16;
            this.lblStatewideTransitFiles.Text = "Statewide Transit Files (from PayrollSummarizer):";
            // 
            // txtStatewideTransitQ1
            // 
            this.txtStatewideTransitQ1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatewideTransitQ1.Location = new System.Drawing.Point(12, 292);
            this.txtStatewideTransitQ1.Name = "txtStatewideTransitQ1";
            this.txtStatewideTransitQ1.Size = new System.Drawing.Size(655, 20);
            this.txtStatewideTransitQ1.TabIndex = 15;
            this.txtStatewideTransitQ1.Text = "Q1\\StatewideTransit.txt";
            // 
            // txtStatewideTransitQ2
            // 
            this.txtStatewideTransitQ2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatewideTransitQ2.Location = new System.Drawing.Point(12, 318);
            this.txtStatewideTransitQ2.Name = "txtStatewideTransitQ2";
            this.txtStatewideTransitQ2.Size = new System.Drawing.Size(655, 20);
            this.txtStatewideTransitQ2.TabIndex = 17;
            this.txtStatewideTransitQ2.Text = "Q2\\StatewideTransit.txt";
            // 
            // txtStatewideTransitQ3
            // 
            this.txtStatewideTransitQ3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatewideTransitQ3.Location = new System.Drawing.Point(12, 344);
            this.txtStatewideTransitQ3.Name = "txtStatewideTransitQ3";
            this.txtStatewideTransitQ3.Size = new System.Drawing.Size(655, 20);
            this.txtStatewideTransitQ3.TabIndex = 18;
            this.txtStatewideTransitQ3.Text = "Q3\\StatewideTransit.txt";
            // 
            // txtStatewideTransitQ4
            // 
            this.txtStatewideTransitQ4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatewideTransitQ4.Location = new System.Drawing.Point(12, 370);
            this.txtStatewideTransitQ4.Name = "txtStatewideTransitQ4";
            this.txtStatewideTransitQ4.Size = new System.Drawing.Size(655, 20);
            this.txtStatewideTransitQ4.TabIndex = 19;
            this.txtStatewideTransitQ4.Text = "Q4\\StatewideTransit.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 481);
            this.Controls.Add(this.txtStatewideTransitQ4);
            this.Controls.Add(this.txtStatewideTransitQ3);
            this.Controls.Add(this.txtStatewideTransitQ2);
            this.Controls.Add(this.lblStatewideTransitFiles);
            this.Controls.Add(this.txtStatewideTransitQ1);
            this.Controls.Add(this.lblTaxFilingsFolder);
            this.Controls.Add(this.btnChooseFolder);
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
        private System.Windows.Forms.FolderBrowserDialog dlgTaxFilingsFolder;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lblTaxFilingsFolder;
        private System.Windows.Forms.Label lblStatewideTransitFiles;
        private System.Windows.Forms.TextBox txtStatewideTransitQ1;
        private System.Windows.Forms.TextBox txtStatewideTransitQ2;
        private System.Windows.Forms.TextBox txtStatewideTransitQ3;
        private System.Windows.Forms.TextBox txtStatewideTransitQ4;
    }
}

