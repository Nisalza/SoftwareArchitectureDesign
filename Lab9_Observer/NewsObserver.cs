using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    class NewsObserver : IObserver
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public NewsObserver(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Id}: {message}");
        }
    }
}
