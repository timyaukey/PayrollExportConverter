using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollExportConverter
{
    public class FixedWidthRecord
    {
        private readonly char[] mLine;
        private readonly int mLength;
        private readonly List<Field> mFields;

        public FixedWidthRecord(int length)
        {
            mLine = new char[length];
            for (int i = 0; i < length; i++)
                mLine[i] = ' ';
            mLength = length;
            mFields = new List<Field>();
        }

        public void SetString(int position, int length, string value, string tag)
        {
            SetInternal(position, length, value, value, tag);
        }

        public void SetMoney(int position, int length, decimal value, ref decimal accum, string tag)
        {
            accum += value;
            string formatted = value.ToString("F2").Replace(".", "");
            formatted = formatted.PadLeft(length, '0').Substring(0, length);
            SetInternal(position, length, value, formatted, tag);
        }

        private void SetInternal(int position, int length, object value, string formatted, string tag)
        {
            for (int i = 0; i < length; i++)
            {
                if (i < formatted.Length)
                    mLine[position + i - 1] = formatted[i];
                else
                    mLine[position + i - 1] = ' ';
            }
            mFields.Add(new Field(position, length, value, formatted, tag));
        }

        public string GetContents()
        {
            return new string(mLine);
        }

        public override string ToString()
        {
            return new string(mLine);
        }

        private class Field
        {
            private readonly int mPosition;
            private readonly int mLength;
            private readonly object mValue;
            private readonly string mFormatted;
            private readonly string mTag;

            public Field(int position, int length, object value, string formatted, string tag)
            {
                mPosition = position;
                mLength = length;
                mValue = value;
                mFormatted = formatted;
                mTag = tag;
            }

            public override string ToString()
            {
                return string.Format("P={0} L={1} V={2} F={3} T={4}", mPosition, mLength, mValue, mFormatted, mTag);
            }
        }

    }
}
