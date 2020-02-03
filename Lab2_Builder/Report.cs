using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder
{
    public class Report
    {
        public List<object> Sections { get; private set; }

        public Report()
        {
            Sections = new List<object>();
        }

        public void AddSection(object section)
        {
            Sections.Add(section);
        }
    }
}
