using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    class NewsObservable : IObservable
    {
        private readonly List<IObserver> _observers;

        private string _message;

        public NewsObservable()
        {
            _observers = new List<IObserver>();
        }

        public void SendMessage(string m)
        {
            _message = m;
            NotifyObservers();
        }

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
            string m = $"Пользователь {o.Name} подписался на получение новостей.";
            SendMessage(m);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
            string m = $"Пользователь {o.Name} отписался от получения новостей.";
            SendMessage(m);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_message);
            }
        }
    }
}
