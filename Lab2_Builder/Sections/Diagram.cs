using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Diagram
    {
        public List<object> Values { get; private set; }

        public Diagram()
        {
            Values = new List<object>();
        }

        public void AddValue(object value)
        {
            Values.Add(value);
        }

        public void AddValues(object[] values)
        {
            Values.AddRange(values);
        }
    }
}
