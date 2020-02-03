using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Chart
    {
        public Dictionary<object, object> Values { get; private set; }

        public Chart()
        {
            Values = new Dictionary<object, object>();
        }

        public void AddValue(object key, object value)
        {
            Values.Add(key, value);
        }

        public void ChangeValue(object key, object value)
        {
            Values[key] = value;
        }
    }
}
