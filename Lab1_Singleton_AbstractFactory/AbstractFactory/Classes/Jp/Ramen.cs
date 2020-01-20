using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.Jp
{
    public class Ramen : Soup
    {
        public Ramen() : base("Рамэн", 260, 300, DensityTypes.Жидкий, KitchenTypes.Японская)
        {

        }
    }
}
