using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory
{
    public class Client
    {
        public Soup Soup { get; }

        public Drink Drink { get; }

        public MainCourse MainCourse { get; }

        public Client(IAbstractFactory factory)
        {
            Soup = factory.CreateSoup();
            Drink = factory.CreateDrink();
            MainCourse = factory.CreateMainCourse();
        }
    }
}
