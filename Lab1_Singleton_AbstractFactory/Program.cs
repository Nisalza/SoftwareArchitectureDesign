using System;
using Lab1_Singleton_AbstractFactory.AbstractFactory;

//Работа ресторана. Подготовка блюд различного меню (русская кухня, китайская кухня, итальянская кухня) из ассортимента на заказ.

namespace Lab1_Singleton_AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton.Singleton receipt = Singleton.Singleton.GetInstance();
            CreateFirstOrder();
            CreateSecondOrder();
            CreateThirdOrder();

            foreach (string s in receipt.History)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

        private static void CreateFirstOrder()
        {
            Singleton.Singleton receipt = Singleton.Singleton.GetInstance();
            Client client = new Client(new RuFactory());
            receipt.AddToHistory(client.MainCourse.ToString());
            receipt.AddToHistory(client.Drink.ToString());
            receipt.AddToHistory(client.Drink.ToString());
            receipt.AddToHistory(client.Soup.ToString());
            receipt.AddToHistory();
        }

        private static void CreateSecondOrder()
        {
            Singleton.Singleton receipt = Singleton.Singleton.GetInstance();
            Client client = new Client(new JpFactory());
            receipt.AddToHistory(client.Soup.ToString());
            receipt.AddToHistory(client.MainCourse.ToString());
            receipt.AddToHistory();
        }

        private static void CreateThirdOrder()
        {
            Singleton.Singleton receipt = Singleton.Singleton.GetInstance();
            Client client = new Client(new ItFactory());
            receipt.AddToHistory(client.Drink.ToString());
            receipt.AddToHistory(client.Drink.ToString());
            receipt.AddToHistory(client.Drink.ToString());
            receipt.AddToHistory();
        }
    }
}
