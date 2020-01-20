using System.Collections.Generic;

namespace Lab1_Singleton_AbstractFactory.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        public List<string> History { get; private set; }

        public static Singleton GetInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }

        private Singleton()
        {
            History = new List<string>();
        }

        public void AddToHistory(string message)
        {
            _instance.History.Add(message);
        }

        public void AddToHistory()
        {
            _instance.History.Add("=== Конец заказа ===");
            _instance.History.Add("");
        }
    }
}
