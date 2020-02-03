using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Title : Text
    {
        public bool IsBold { get; private set; }

        public bool IsItalic { get; private set; }

        public bool IsUnderlined { get; private set; }

        public Title(string text, bool bold, bool italic, bool underlined) : base(text)
        {
            IsBold = bold;
            IsItalic = italic;
            IsUnderlined = underlined;
        }
    }
}
