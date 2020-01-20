using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.It;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory
{
    public class ItFactory : IAbstractFactory
    {
        public Drink CreateDrink()
        {
            return new Latte();
        }

        public Soup CreateSoup()
        {
            return new Minestrone();
        }

        public MainCourse CreateMainCourse()
        {
            return new Risotto();
        }
    }
}
