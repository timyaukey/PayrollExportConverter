using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PayrollExportConverter
{
    /// <summary>
    /// Read and parse lines from a TextReader.
    /// There is always a header row with column names.
    /// After instantiation, CurrentValues contains data from the first row
    /// after the header row, or null if there is only a header row.
    /// </summary>
    public class DelimitedReader
    {
        private TextReader mReader;
        private readonly char mDelimiter;
        private readonly bool mAllowQuoted;

        private DelimitedRow ColumnNames;
        private Dictionary<string, int> ColumnIndices;
        public DelimitedRow CurrentValues;
        public DelimitedRow ColumnTotals;

        public DelimitedReader(TextReader reader, char delimiter, bool allowQuoted)
        {
            mReader = reader;
            mDelimiter = delimiter;
            mAllowQuoted = allowQuoted;
            ReaderHeaderLine();
            // Starts with the first line after the header row loaded into CurrentValues.
            CurrentValues = ReadLine(false);
            // Undefined until ReadUntilChange() called.
            ColumnTotals = null;
        }

        public bool HasCurrent
        {
            get
            {
                return CurrentValues != null;
            }
        }

        private void ReaderHeaderLine()
        {
            ColumnNames = ReadLine(true);
            ColumnIndices = new Dictionary<string, int>();
            for (int index = 0; index < ColumnNames.Count; index++)
            {
                ColumnIndices.Add((string)ColumnNames[index], index);
            }
        }

        /// <summary>
        /// Read through rows until the specified column changes value.
        /// Leaves CurrentValues positioned at the first row with a different value of "columnName".
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>A DelimitedRow with the sums of the rows read before the new CurrentValues.</returns>
        public DelimitedRow ReadUntilChange(string columnName)
        {
            ColumnTotals = new DelimitedRow(ColumnIndices, CurrentValues);
            string initialValue = CurrentValues.GetValue(columnName).ToString();
            for (;;)
            {
                CurrentValues = ReadLine(false);
                if (CurrentValues == null)
                    break;
                string newValue = CurrentValues.GetValue(columnName).ToString();
                if (newValue != initialValue)
                {
                    break;
                }
                for (int index = 0; index < ColumnNames.Count; index++)
                {
                    object currentValue = CurrentValues[index];
                    object columnTotal = ColumnTotals[index];
                    ColumnTotals[index] = Add(columnTotal, currentValue);
                }
            }
            return ColumnTotals;
        }

        public DelimitedRow NextLine()
        {
            CurrentValues = ReadLine(false);
            return CurrentValues;
        }

        /// <summary>
        /// Add two objects together, representing the result as a
        /// numeric value if the two inputs are numeric, otherwise as a string.
        /// If the result is numeric, return it as an integer
        /// if both inputs were of type integer, otherwise return a decimal.
        /// If the result is not numeric, return the first value if it
        /// is a string, otherwise return the second value converted to a string.
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public object Add(object value1, object value2)
        {
            if (value1 is decimal && value2 is decimal)
            {
                return (decimal)value1 + (decimal)value2;
            }
            if (value1 is int && value2 is int)
            {
                return (int)value1 + (int)value2;
            }
            if (value1 is decimal && value2 is int)
            {
                return (decimal)value1 + (decimal)(int)value2;
            }
            if (value1 is int && value2 is decimal)
            {
                return (decimal)(int)value1 + (decimal)value2;
            }
            if (value1 is string)
                return value1;
            else
                return value2.ToString();
        }

        private DelimitedRow ReadLine(bool forceStrings)
        {
            DelimitedRow newValues = new DelimitedRow(ColumnIndices);
            string line = mReader.ReadLine();
            if (string.IsNullOrEmpty(line))
                return null;
            for (int nextIndex = 0; ;)
            {
                if (nextIndex > line.Length)
                    break;
                if (nextIndex == line.Length)
                {
                    newValues.Add(MakeValue("", forceStrings));
                    break;
                }
                char firstChar = line[nextIndex];
                if (firstChar == '"' && mAllowQuoted)
                {
                    nextIndex++;
                    int secondQuoteIndex = line.IndexOf('"', nextIndex);
                    if (secondQuoteIndex <= 0)
                    {
                        newValues.Add(MakeValue(line.Substring(nextIndex), forceStrings));
                        break;
                    }
                    newValues.Add(MakeValue(line.Substring(nextIndex, secondQuoteIndex - nextIndex), forceStrings));
                    nextIndex = secondQuoteIndex + 2;
                }
                else
                {
                    int nextCommaIndex = line.IndexOf(mDelimiter, nextIndex);
                    if (nextCommaIndex < 0)
                    {
                        newValues.Add(MakeValue(line.Substring(nextIndex), forceStrings));
                        break;
                    }
                    newValues.Add(MakeValue(line.Substring(nextIndex, nextCommaIndex - nextIndex), forceStrings));
                    nextIndex = nextCommaIndex + 1;
                }
            }
            return newValues;
        }

        private object MakeValue(string input, bool forceString)
        {
            if (!forceString)
            {
                if (int.TryParse(input, out int intValue))
                    return intValue;
                if (decimal.TryParse(input, out decimal decValue))
                    return decValue;
            }
            return input;
        }
    }
}
