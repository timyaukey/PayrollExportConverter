using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollExportConverter
{
    public class DelimitedRow : List<object>
    {
        public DelimitedRow(Dictionary<string, int> columnIndices, IEnumerable<object> contents)
            : base(contents)
        {
            ColumnIndices = columnIndices;
        }

        public DelimitedRow(Dictionary<string, int> columnIndices)
        {
            ColumnIndices = columnIndices;
        }

        private Dictionary<string, int> ColumnIndices;

        public int GetIndex(string columnName)
        {
            return ColumnIndices[columnName];
        }

        public object GetValue(string columnName)
        {
            return this[GetIndex(columnName)];
        }

        public string GetString(string columnName)
        {
            return (string)this[GetIndex(columnName)];
        }

        public decimal GetDecimal(string columnName)
        {
            return (decimal)this[GetIndex(columnName)];
        }

        public int GetInteger(string columnName)
        {
            return (int)this[GetIndex(columnName)];
        }
    }
}
