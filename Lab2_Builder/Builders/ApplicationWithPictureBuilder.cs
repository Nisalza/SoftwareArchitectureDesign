using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_Builder.Sections;

namespace Lab2_Builder.Builders
{
    public class ApplicationWithPictureBuilder : IBuilder
    {
        public ApplicationWithPictureBuilder()
        {
            Result = new Report();
        }

        public void BuildDiagram(object[] values)
        {
            throw new NotImplementedException();
        }

        public void BuildLink(string text, bool highlight)
        {
            throw new NotImplementedException();
        }

        public void BuildMarkedList(string text, char mark, byte shift)
        {
            throw new NotImplementedException();
        }

        public void BuildPicture(string path)
        {
            Picture picture = new Picture(path);
            Result.AddSection(picture);
        }

        public void BuildTable(byte rows, byte cols)
        {
            throw new NotImplementedException();
        }

        public void BuildTable(byte rows, byte cols, Text[,] content)
        {
            throw new NotImplementedException();
        }

        public void BuildText(string content)
        {
            throw new NotImplementedException();
        }

        public void BuildTitle(string text, bool bold, bool italic, bool underlined)
        {
            Title title = new Title(text, bold, italic, underlined);
            Result.AddSection(title);
        }

        public void BuildChart(Dictionary<object, object> values)
        {
            throw new NotImplementedException();
        }

        public Report Result { get; private set; }

        public Report Construct()
        {
            BuildTitle("Приложение А. Диаграмма классов", true, true, false);
            BuildPicture("Адрес рисунка с диаграммой");
            return Result;
        }

        public void Reset()
        {
            Result = new Report();
        }
    }
}
