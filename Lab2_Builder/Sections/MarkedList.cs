using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class MarkedList : Text
    {
        public char Mark { get; private set; }

        public byte Shift { get; private set; }

        public  MarkedList(string text, char mark = '–', byte shift = 0) : base(text)
        {
            Mark = mark;
            Shift = shift;
        }
    }
}
