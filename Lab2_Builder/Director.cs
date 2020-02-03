using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder
{
    public class Director
    {
        public IBuilder Builder { get; private set; }

        public Director(IBuilder builder)
        {
            Builder = builder;
        }

        public Report GetReport()
        {
            Report result = Builder.Construct();
            return result;
        }
    }
}
