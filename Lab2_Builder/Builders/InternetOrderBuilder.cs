using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_Builder.Sections;

namespace Lab2_Builder.Builders
{
    public class InternetOrderBuilder : IBuilder
    {
        public InternetOrderBuilder()
        {
            Result = new Report();
        }

        public void BuildDiagram(object[] values)
        {
            throw new NotImplementedException();
        }

        public void BuildLink(string text, bool highlight)
        {
            Link link = new Link(text, highlight);
            Result.AddSection(link);
        }

        public void BuildMarkedList(string text, char mark, byte shift)
        {
            MarkedList ml = new MarkedList(text, mark, shift);
            Result.AddSection(ml);
        }

        public void BuildPicture(string path)
        {
            throw new NotImplementedException();
        }

        public void BuildTable(byte rows, byte cols)
        {
            Table table = new Table(rows, cols);
            Result.AddSection(table);
        }

        public void BuildTable(byte rows, byte cols, Text[,] content)
        {
            throw new NotImplementedException();
        }

        public void BuildText(string content)
        {
            Text text = new Text(content);
            Result.AddSection(text);
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
            BuildTitle("Заказ №_____", true, false, false);
            BuildText("Условия доставки:");
            BuildMarkedList("Условие 1", '•', 1);
            BuildMarkedList("Условие 1.1", '•', 2);
            BuildMarkedList("Условие 1.2", '•', 2);
            BuildMarkedList("Условие 2", '•', 1);
            BuildTable(15, 5);
            BuildText("Сайт поставщика:");
            BuildLink("Адрес ссылки", true);
            return Result;
        }

        public void Reset()
        {
            Result = new Report();
        }
    }
}
