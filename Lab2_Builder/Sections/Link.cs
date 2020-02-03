using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Link : Text
    {
        public bool NeedToHighlight { get; private set; }

        public Link(string text, bool needToHighlight) : base(text)
        {
            NeedToHighlight = needToHighlight;
        }
    }
}
