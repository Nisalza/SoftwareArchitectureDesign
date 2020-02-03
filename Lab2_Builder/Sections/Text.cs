using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Text
    {
        public string Content { get; private set; }

        public Text(string content)
        {
            Content = content;
        }
    }
}
