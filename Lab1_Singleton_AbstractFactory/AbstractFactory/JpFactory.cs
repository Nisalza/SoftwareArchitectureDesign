using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.Jp;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory
{
    public class JpFactory : IAbstractFactory
    {
        public Drink CreateDrink()
        {
            return new Matcha();
        }

        public Soup CreateSoup()
        {
            return new Ramen();
        }

        public MainCourse CreateMainCourse()
        {
            return new Gyoza();
        }
    }
}
