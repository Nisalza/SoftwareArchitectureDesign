using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.Ru;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory
{
    public class RuFactory: IAbstractFactory
    {
        public Drink CreateDrink()
        {
            return new Kvass();
        }

        public Soup CreateSoup()
        {
            return new Okroshka();
        }

        public MainCourse CreateMainCourse()
        {
            return new Roast();
        }
    }
}
