using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_Builder.Builders;

namespace Lab2_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder order = new InternetOrderBuilder();
            Director director = new Director(order);
            Report orderReport = director.GetReport();

            IBuilder application = new ApplicationWithPictureBuilder();
            director = new Director(application);
            Report appReport = director.GetReport();
        }
    }
}
