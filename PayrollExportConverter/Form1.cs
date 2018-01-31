using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollExportConverter
{
    public partial class Form1 : Form
    {
        private string mFileName;

        private const int mRecordLength = 512;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadTestFiles_Click(object sender, EventArgs e)
        {
            ReadTestFile1();
            ReadTestFile2();
            MessageBox.Show("Tests complete.");
        }

        private void ReadTestFile1()
        {
            try
            {
                mFileName = "TestFile1.txt";
                using (TextReader reader = new StreamReader(mFileName))
                {
                    DelimitedReader delReader = new DelimitedReader(reader, ',', true);
                    DelimitedRow row = delReader.CurrentValues;
                    DelimitedRow totals = delReader.ColumnTotals;
                    if (row == null)
                        Failure("Initial row is null");
                    if (row.Count != 6)
                        Failure("Initial row column wrong count");
                    if (totals != null)
                        Failure("Initial totals must be null");
                    if (!delReader.HasCurrent)
                        Failure("Initial has no current");
                    if (row.GetIndex("Name") != 0)
                        Failure("Name index != 0");
                    if (row.GetIndex("Weight") != 2)
                        Failure("Weight index != 2");
                    if ((string)row.GetValue("Name") != "Dog")
                        Failure("Name!=Dog");
                    if (!(row.GetValue("Weight") is decimal))
                        Failure("Dog weight is not decimal");
                    if ((decimal)row.GetValue("Weight") != 20.5M)
                        Failure("Dog weight is not 20.5M");
                    if (row.GetDecimal("Weight") != 20.5M)
                        Failure("Dog weight is not 20.5M (2)");
                    if (!(row.GetValue("Length") is int))
                        Failure("Length is not integer");
                    if (row.GetInteger("Length") != 26)
                        Failure("Dog Length is not 26");

                    row = delReader.NextLine();

                    if (!delReader.HasCurrent)
                        Failure("Second has no current");
                    if (row.Count != 6)
                        Failure("Second row column count wrong");
                    if (row.GetString("Name") != "Big Fish")
                        Failure("Second name is not Fish");
                    if (row.GetString("Color") != "Silver")
                        Failure("Second color is not Silver");
                    if (row.GetDecimal("Weight") != 3.5M)
                        Failure("Second Weight should be 3.5M");
                    if (row.GetInteger("Units") != 200)
                        Failure("Second units is not 200");

                    totals = delReader.ReadUntilChange("Break");
                    row = delReader.CurrentValues;

                    if (row.GetString("Name") != "Small Fish")
                        Failure("UntilChange Break wrong row");
                    if (!(totals.GetValue("Name") is string))
                        Failure("UntilChange Name should be string");
                    if (!(totals.GetValue("Weight") is decimal))
                        Failure("UntilChange Weight should be decimal");
                    if (totals.GetDecimal("Weight") != 3.5M)
                        Failure("UntilChange Weight should be 3.5M");

                    totals = delReader.ReadUntilChange("Break");
                    row = delReader.CurrentValues;

                    if (row.GetString("Name") != "guppy")
                        Failure("UntilChange2 Break wrong row");
                    if (totals.GetDecimal("Weight") != ((decimal)1 + 8.5M + 300.5M))
                        Failure("UntilChange2 wrong Weight total");
                    if (totals.GetInteger("Units") != (3000 + 5 + 1))
                        Failure("UntilChange2 wrong Units total");
                    if (!(row.GetValue("Units") is int))
                        Failure("UntilChange2 wrong Units type");

                    row = delReader.NextLine();

                    if (row.GetString("Name") != "")
                        Failure("Blank Name is not blank");
                    if (row.GetString("Color") != "none")
                        Failure("Blank Color is not none");
                    if (row.GetString("Weight") != "")
                        Failure("Blank Weight is not blank");
                    if (row.GetString("Length") != "")
                        Failure("Blank Length is not blank");
                    if (row.GetInteger("Units") != 100)
                        Failure("Blank Units is not 100");

                    row = delReader.NextLine();

                    if (row.GetString("Name") != "tall grass")
                        Failure("tall grass wrong name");
                    if (!delReader.HasCurrent)
                        Failure("tall grass has no current");

                    delReader.NextLine();

                    if (delReader.HasCurrent)
                        Failure("should not have current");

                    if (!(delReader.Add("a", "B") is string))
                        Failure("Add string string is not string");
                    if (!(delReader.Add("a", 1) is string))
                        Failure("Add string int is not string");
                    if (!(delReader.Add(2, "B") is string))
                        Failure("Add int string is not string");
                    if (!(delReader.Add(2.5M, "B") is string))
                        Failure("Add decimal string is not string");
                    if (!(delReader.Add(2, 1) is int))
                        Failure("Add int int is not int");
                    if (!(delReader.Add(2.5M, 3.5M) is decimal))
                        Failure("Add decimal decimal is not decimal");
                    if (!(delReader.Add(2.5M, 3) is decimal))
                        Failure("Add decimal int is not decimal");
                    if (!(delReader.Add(2, 3.5M) is decimal))
                        Failure("Add int decimal is not decimal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadTestFile2()
        {
            try
            {
                mFileName = "TestFile2.txt";
                using (TextReader reader = new StreamReader(mFileName))
                {
                    DelimitedReader delReader = new DelimitedReader(reader, '\t', false);
                    DelimitedRow row = delReader.CurrentValues;
                    DelimitedRow totals = delReader.ColumnTotals;
                    if (row == null)
                        Failure("Initial row is null");
                    if (totals != null)
                        Failure("Initial totals must be null");
                    if (!delReader.HasCurrent)
                        Failure("Initial has no current");

                    if (row.GetString("Color") != "Red")
                        Failure("Initial color must be Red");
                    if (row.GetString("Group") != "Reds")
                        Failure("Initial group must be Reds");
                    if (row.GetString("Depth") != "\"Deep\"")
                        Failure("Initial Depth is not Deep");
                    if (row.GetString("Description") != "\"Very deep red\"")
                        Failure("Initial description wrong");
                    if (!(row.GetValue("Level") is int))
                        Failure("Initial Level must be int");
                    if (row.GetInteger("Level") != 100)
                        Failure("Initial Level must be 100");

                    totals = delReader.ReadUntilChange("Group");
                    row = delReader.CurrentValues;

                    if (row != null)
                        Failure("UntilChanges did not read through end");
                    if (totals.GetInteger("Level") != 150)
                        Failure("UntilChanges Level was not 150");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Failure(string msg)
        {
            throw new Exception(mFileName + ": " + msg);
        }

        private void btnCreateW2_Click(object sender, EventArgs e)
        {
            if (cboTaxYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a tax year");
                return;
            }
            Accumulators accum = new Accumulators();
            Dictionary<string, DelimitedRow> employees = LoadEmployeeDictionary(txtEmployeeFile.Text);;
            Dictionary<string, DelimitedRow> supplemental = LoadEmployeeDictionary(txtEmployeeSupplemental.Text);
            using (TextWriter writer = new StreamWriter("W2Output.txt"))
            {
                OutputRARecord(writer);
                OutputRERecord(writer);
                using (TextReader payText = new StreamReader(txtPayrollFile.Text))
                {
                    DelimitedReader payParser = new DelimitedReader(payText, ',', true);
                    for (;;)
                    {
                        if (!payParser.HasCurrent)
                            break;
                        DelimitedRow paySummary = payParser.ReadUntilChange("SSN");
                        string ssn = paySummary.GetString("SSN");
                        DelimitedRow empRow;
                        if (!employees.TryGetValue(ssn, out empRow))
                        {
                            MessageBox.Show("Could not find SSN in employee file: " + ssn);
                            return;
                        }
                        DelimitedRow supRow;
                        if (!supplemental.TryGetValue(ssn, out supRow))
                        {
                            MessageBox.Show("Could not find SSN in supplemental file: " + ssn);
                            return;
                        }
                        OutputRWRecord(writer, paySummary, empRow, accum);
                        OutputRSRecord(writer, paySummary, empRow, supRow, accum);
                    }
                }
                OutputRTRecord(writer, accum);
                // No "RU" record, because no "RO" records.
                OutputRVRecord(writer, accum);
                OutputRFRecord(writer, accum);
                
            }
            MessageBox.Show("Wrote W2Output.txt to working directory.");
        }

        private Dictionary<string, DelimitedRow> LoadEmployeeDictionary(string fileName)
        {
            Dictionary<string, DelimitedRow> result = new Dictionary<string, DelimitedRow>();
            using (TextReader empText = new StreamReader(fileName))
            {
                DelimitedReader empParser = new DelimitedReader(empText, ',', true);
                for (;;)
                {
                    DelimitedRow empRow = empParser.CurrentValues;
                    if (empRow == null)
                        break;
                    if (empRow.Count > 0)
                    {
                        result.Add(empRow.GetString("SSN"), empRow);
                    }
                    empParser.NextLine();
                }
            }
            return result;
        }

        /// <summary>
        /// Submitter record
        /// </summary>
        /// <param name="writer"></param>
        private void OutputRARecord(TextWriter writer)
        {
            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);

            rec.SetString(1, 2, "RA", "Record Identifier");
            rec.SetString(3, 9, "261667772", "Submitter's EIN");
            rec.SetString(12, 8, "QS4K6SMS", "User ID");
            rec.SetString(29, 1, chkResubmissions.Checked ? "1" : "0", "Resub Indicator");
            rec.SetString(30, 6, txtResubID.Text, "WFID");
            rec.SetString(36, 2, "98", "Software Code");

            rec.SetString(38, 57, "Schmidt's Garden Center, Inc.", "Company Name");
            rec.SetString(95, 22, "1299 NW 29th Street", "Location Address");
            rec.SetString(117, 22, "1299 NW 29th Street", "Delivery Address");
            rec.SetString(139, 22, "Corvallis", "City");
            rec.SetString(161, 2, "OR", "State Abbreviation");
            rec.SetString(163, 5, "97330", "Zipcode");
            rec.SetString(168, 4, "1843", "Zip Extension");

            rec.SetString(217, 57, "Schmidt's Garden Center, Inc.", "Submitter Name");
            rec.SetString(274, 22, "1299 NW 29th Street", "Submitter Location Address");
            rec.SetString(296, 22, "1299 NW 29th Street", "Submitter Delivery Address");
            rec.SetString(318, 22, "Corvallis", "Submitter City");
            rec.SetString(340, 2, "OR", "Submitter State Abbreviation");
            rec.SetString(342, 5, "97330", "Submitter Zipcode");
            rec.SetString(347, 4, "1843", "Submitter Zip Extension");

            rec.SetString(396, 27, "Timothy Yaukey", "Contact Name");
            rec.SetString(423, 15, "4132379149", "Contact Phone");
            rec.SetString(446, 40, "yaukey@willowsoft.com", "Contact Email");

            rec.SetString(500, 1, "L", "Preparer Code (Self-Prepared)");

            writer.WriteLine(rec.GetContents());
        }

        /// <summary>
        /// Employer record
        /// </summary>
        /// <param name="writer"></param>
        private void OutputRERecord(TextWriter writer)
        {
            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);

            rec.SetString(1, 2, "RE", "Record Identifier");
            rec.SetString(3, 4, cboTaxYear.SelectedItem as string, "Tax Year");
            rec.SetString(8, 9, "261667772", "Employer EIN");
            rec.SetString(26, 1, "0", "Terminating Business Indicator");

            rec.SetString(40, 57, "Schmidt's Garden Center, Inc.", "Employer Name");
            rec.SetString(97, 22, "1299 NW 29th Street", "Location Address");
            rec.SetString(119, 22, "1299 NW 29th Street", "Delivery Address");
            rec.SetString(141, 22, "Corvallis", "City");
            rec.SetString(163, 2, "OR", "State Abbreviation");
            rec.SetString(165, 5, "97330", "Zipcode");
            rec.SetString(170, 4, "1843", "Zip Extension");

            rec.SetString(174, 1, "N", "Kind of Employer");
            rec.SetString(219, 1, "R", "Employment Code (Regular, 941)");
            rec.SetString(221, 1, "0", "Third Party Sick Pay Indicator");

            rec.SetString(222, 27, "Timothy Yaukey", "Contact Name");
            rec.SetString(249, 15, "4132379149", "Contact Phone");
            rec.SetString(279, 40, "yaukey@willowsoft.com", "Contact Email");

            writer.WriteLine(rec.GetContents());
        }

        /// <summary>
        /// Employee wage record
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paySummary"></param>
        /// <param name="empRow"></param>
        private void OutputRWRecord(TextWriter writer, DelimitedRow paySummary, DelimitedRow empRow, Accumulators accum)
        {
            decimal grossPay = paySummary.GetDecimal("Gross Taxable Income");
            accum.EmployeeRecordCount++;

            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);
            decimal dummy = 0M;

            //MessageBox.Show("Name=" + empSummary.GetString("Name") + " GrossPay=" + grossPay.ToString() +
            //    " Address=" + empRow.GetString("Address1"));

            rec.SetString(1, 2, "RW", "Record Identifier");
            rec.SetString(3, 9, paySummary.GetString("SSN").Replace("-", "").PadLeft(9, '0'), "SSN");
            rec.SetString(12, 15, empRow.GetString("FName"), "First Name");
            rec.SetString(27, 15, empRow.GetString("MInit"), "Middle Initial");
            rec.SetString(42, 20, empRow.GetString("LName"), "Last Name");
            string address = empRow.GetString("Address1") + " " + empRow.GetString("Address2");
            rec.SetString(66, 22, address, "Location Address");
            rec.SetString(88, 22, address, "Delivery Address");
            rec.SetString(110, 22, empRow.GetString("City"), "City");
            rec.SetString(132, 2, empRow.GetString("State"), "State");
            string zip = empRow.GetInteger("Zip Code").ToString("00000");
            rec.SetString(134, 5, zip, "Zipcode");

            rec.SetMoney(188, 11, grossPay, ref accum.FederalWages, "Federal Taxable Wages");
            rec.SetMoney(199, 11, paySummary.GetDecimal("Federal Tax"), ref accum.FITW, "FITW");
            rec.SetMoney(210, 11, paySummary.GetDecimal("Gross SS Taxable Income"), ref accum.SocialSecurityWages, "Social Security Wages");
            rec.SetMoney(221, 11, paySummary.GetDecimal("Social Security Tax"), ref accum.SocialSecurityTaxes, "Social Security Tax");
            rec.SetMoney(232, 11, paySummary.GetDecimal("Gross FICA Taxable Income"), ref accum.MedicareWages, "Medicare Wages");
            rec.SetMoney(243, 11, paySummary.GetDecimal("Medicare Tax"), ref accum.MedicareTaxes, "Medicare Tax");
            rec.SetMoney(254, 11, paySummary.GetDecimal("Tips"), ref accum.SocialSecurityTips, "Social Security Tips");
            rec.SetMoney(276, 11, 0M, ref dummy, "Dependent Care Benefits");
            rec.SetMoney(287, 11, 0M, ref dummy, "Deferred Comp 401(K)");
            rec.SetMoney(298, 11, 0M, ref dummy, "Deferred Comp 403(B)");
            rec.SetMoney(309, 11, 0M, ref dummy, "Deferred Comp 408(K)");
            rec.SetMoney(320, 11, 0M, ref dummy, "Deferred Comp 457(b)");
            rec.SetMoney(331, 11, 0M, ref dummy, "Deferred Comp 501(c)");
            rec.SetMoney(353, 11, 0M, ref dummy, "Non-Qualified 457 Dist/Cont");
            rec.SetMoney(364, 11, 0M, ref dummy, "Employer FSA");
            rec.SetMoney(375, 11, 0M, ref dummy, "Non-qualified NOT 457");
            rec.SetMoney(386, 11, 0M, ref dummy, "Non-taxable Combat Pay");
            rec.SetMoney(408, 11, 0M, ref dummy, "Employer Group Term Premiums");
            rec.SetMoney(419, 11, 0M, ref dummy, "Income from Nonstatutory Stock Options");
            rec.SetMoney(430, 11, 0M, ref dummy, "Section 409A Deferrals");
            rec.SetMoney(441, 11, 0M, ref dummy, "ROTH Contributions 401(k)");
            rec.SetMoney(452, 11, 0M, ref dummy, "ROTH Contributions 403(b)");
            rec.SetMoney(463, 11, 0M, ref dummy, "Cost of Employer Health Coverage");
            rec.SetMoney(474, 11, 0M, ref dummy, "Small Employer Health Reimbursement Arrangement");
            rec.SetString(486, 1, "1", "Statutory Employee");
            rec.SetString(488, 1, "0", "Retirement Plan");
            rec.SetString(489, 1, "0", "Third Party Sick Pay");

            writer.WriteLine(rec.GetContents());
        }

        private void OutputRSRecord(TextWriter writer, DelimitedRow paySummary, DelimitedRow empRow, DelimitedRow supRow, Accumulators accum)
        {
            decimal grossPay = paySummary.GetDecimal("Gross Taxable Income");

            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);

            rec.SetString(1, 2, "RS", "Record Identifier");
            rec.SetString(3, 2, "41", "State Numeric Code");
            rec.SetString(10, 9, paySummary.GetString("SSN").Replace("-", "").PadLeft(9, '0'), "SSN");

            rec.SetString(19, 15, empRow.GetString("FName"), "First Name");
            rec.SetString(34, 15, empRow.GetString("MInit"), "Middle Initial");
            rec.SetString(49, 20, empRow.GetString("LName"), "Last Name");
            string address = empRow.GetString("Address1") + " " + empRow.GetString("Address2");
            rec.SetString(73, 22, address, "Location Address");
            rec.SetString(95, 22, address, "Delivery Address");
            rec.SetString(117, 22, empRow.GetString("City"), "City");
            rec.SetString(139, 2, empRow.GetString("State"), "State");
            string zip = empRow.GetInteger("Zip Code").ToString("00000");
            rec.SetString(141, 5, zip, "Zipcode");

            //rec.SetString(197, 6, "12" + (string)cboTaxYear.SelectedItem, "Reporting Period");

            DateTime hireDate = DateTime.Parse(supRow.GetString("HireDate"));
            rec.SetString(227, 8, hireDate.ToString("MMddyyyy"), "Hire Date");
            string termDate = supRow.GetString("TerminationDate");
            if (string.IsNullOrEmpty(termDate))
                termDate = "00000000";
            else
                termDate = DateTime.Parse(termDate).ToString("MMddyyyy");
            rec.SetString(235, 8, termDate, "Termination Date");
            rec.SetString(248, 20, "013375439", "Oregon BIN");
            rec.SetString(274, 2, "41", "State Numeric Code");

            rec.SetMoney(276, 11, grossPay, ref accum.StateWages, "State Taxable Wages");
            rec.SetMoney(287, 11, paySummary.GetDecimal("State Tax"), ref accum.SITW, "SITW");

            writer.WriteLine(rec.GetContents());
        }

        private void OutputRTRecord(TextWriter writer, Accumulators accum)
        {
            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);
            decimal dummy = 0M;

            rec.SetString(1, 2, "RT", "Record Identifier");
            rec.SetString(3, 7, accum.EmployeeRecordCount.ToString("0000000"), "RW Record Count");
            rec.SetMoney(10, 15, accum.FederalWages, ref dummy, "Total Gross Pay");
            rec.SetMoney(25, 15, accum.FITW, ref dummy, "Total FITW");
            rec.SetMoney(40, 15, accum.SocialSecurityWages, ref dummy, "Total SocSec Wages");
            rec.SetMoney(55, 15, accum.SocialSecurityTaxes, ref dummy, "Total SecSec Withholding");
            rec.SetMoney(70, 15, accum.MedicareWages, ref dummy, "Total Medicare Wages");
            rec.SetMoney(85, 15, accum.MedicareTaxes, ref dummy, "Total Medicare Taxes");
            rec.SetMoney(100, 15, accum.SocialSecurityTips, ref dummy, "Total SocSec Tips");
            rec.SetMoney(130, 15, 0M, ref dummy, "Total Dependent Care");
            rec.SetMoney(145, 15, 0M, ref dummy, "Deferred Contrib 401(k)");
            rec.SetMoney(160, 15, 0M, ref dummy, "Deferred Contrib 403(b)");
            rec.SetMoney(175, 15, 0M, ref dummy, "Deferred Contrib 408(k)");
            rec.SetMoney(190, 15, 0M, ref dummy, "Deferred Contrib 457(b)");
            rec.SetMoney(205, 15, 0M, ref dummy, "Deferred Contrib 501(c)");
            rec.SetMoney(235, 15, 0M, ref dummy, "Non-qual Section 401(k)");
            rec.SetMoney(250, 15, 0M, ref dummy, "Total Employer FSA Contrib");
            rec.SetMoney(265, 15, 0M, ref dummy, "Non-qual Section 457");
            rec.SetMoney(280, 15, 0M, ref dummy, "Non-taxable Combat Pay");
            rec.SetMoney(295, 15, 0M, ref dummy, "Employer Sponsored Health Plan");
            rec.SetMoney(310, 15, 0M, ref dummy, "Group Term Life");
            rec.SetMoney(325, 15, 0M, ref dummy, "Tax on Third Party Sick Pay");
            rec.SetMoney(340, 15, 0M, ref dummy, "Non-statutory Stock Options");
            rec.SetMoney(355, 15, 0M, ref dummy, "409A Deferrals");
            rec.SetMoney(370, 15, 0M, ref dummy, "Roth 401(k) Contributions");
            rec.SetMoney(385, 15, 0M, ref dummy, "Roth 403(b) Salary Reduction");
            rec.SetMoney(400, 15, 0M, ref dummy, "Small Employer Health Reimbursement Arrangement");

            writer.WriteLine(rec.GetContents());
        }

        private void OutputRVRecord(TextWriter writer, Accumulators accum)
        {
            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);
            decimal dummy = 0M;

            rec.SetString(1, 2, "RV", "Record Identifier");
            rec.SetString(3, 7, accum.EmployeeRecordCount.ToString("0000000"), "RS Record Count");
            rec.SetMoney(10, 15, accum.StateWages, ref dummy, "Total State Wages");
            rec.SetMoney(25, 15, accum.SITW, ref dummy, "Total SITW");

            writer.WriteLine(rec.GetContents());
        }

        private void OutputRFRecord(TextWriter writer, Accumulators accum)
        {
            FixedWidthRecord rec = new FixedWidthRecord(mRecordLength);

            rec.SetString(1, 2, "RF", "Record Identifier");
            rec.SetString(8, 9, accum.EmployeeRecordCount.ToString("000000000"), "Total RW Recordss");

            writer.WriteLine(rec.GetContents());
        }
        private class Accumulators
        {
            public int EmployeeRecordCount;
            public decimal FederalWages;
            public decimal FITW;
            public decimal SocialSecurityWages;
            public decimal SocialSecurityTaxes;
            public decimal MedicareWages;
            public decimal MedicareTaxes;
            public decimal StateWages;
            public decimal SITW;
            public decimal SocialSecurityTips;
        }
    }
}
