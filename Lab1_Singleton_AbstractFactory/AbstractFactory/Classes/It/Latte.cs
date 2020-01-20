using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.It
{
    public class Latte : Drink
    {
        public Latte() : base("Латте", 300, 150, KitchenTypes.Итальянская)
        {

        }
    }
}
