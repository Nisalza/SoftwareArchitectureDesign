using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lab2_Builder.Sections;

namespace Lab2_Builder
{
    public interface IBuilder
    {
        void BuildDiagram(object[] values);

        void BuildLink(string text, bool highlight);

        void BuildMarkedList(string text, char mark, byte shift);

        void BuildPicture(string path);

        void BuildTable(byte rows, byte cols);

        void BuildTable(byte rows, byte cols, Text[,] content);

        void BuildText(string content);

        void BuildTitle(string text, bool bold, bool italic, bool underlined);

        void BuildChart(Dictionary<object, object> values);

        Report Result { get; }

        Report Construct();

        void Reset();
    }
}
