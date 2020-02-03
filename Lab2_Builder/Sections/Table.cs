using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Table
    {
        public Text[,] Content { get; private set; }

        public byte Rows { get; private set; }

        public byte Columns { get; private set; }

        public Table(byte rows, byte columns)
        {
            Rows = rows;
            Columns = columns;
            Content = new Text[rows, columns];
        }

        public Table(byte rows, byte columns, Text[,] content)
        {
            if (rows * columns != content.Length) { throw new Exception(); }

            Rows = rows;
            Columns = columns;
            Content = content;
        }

        public void SetContentToCell(byte i, byte j, Text value)
        {
            Content[i, j] = value;
        }
    }
}
