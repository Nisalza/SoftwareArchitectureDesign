using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    interface IObserver
    {
        int Id { get; }

        string Name { get; }

        void Update(string message);
    }
}
