using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Builder.Sections
{
    public class Picture
    {
        public string Path { get; private set; }

        public Picture(string path)
        {
            Path = path;
        }
    }
}
