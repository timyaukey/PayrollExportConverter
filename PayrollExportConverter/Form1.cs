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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadTestFiles_Click(object sender, EventArgs e)
        {
            ReadTestFile1();
            ReadTestFile2();
            MessageBox.Show("Tests passed!");
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
    }
}
