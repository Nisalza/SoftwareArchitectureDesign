using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces
{
    public interface IDish
    {
        string Name { get; }

        KitchenTypes Country { get; }

        int Cost { get; }
    }
}
