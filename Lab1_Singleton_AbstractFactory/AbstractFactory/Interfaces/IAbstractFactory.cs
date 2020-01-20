using Lab1_Singleton_AbstractFactory.AbstractFactory.Classes;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        Drink CreateDrink();

        Soup CreateSoup();

        MainCourse CreateMainCourse();
    }
}
