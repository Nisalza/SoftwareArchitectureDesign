using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.Ru
{
    public class Kvass : Drink
    {
        public Kvass() : base("Квас", 350, 50, KitchenTypes.Русская)
        {
        }
    }
}
