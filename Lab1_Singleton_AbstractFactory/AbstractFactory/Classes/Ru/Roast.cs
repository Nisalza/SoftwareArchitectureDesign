using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.Ru
{
    public class Roast : MainCourse
    {
        public Roast() : base("Жаркое", 300, 500, KitchenTypes.Русская)
        {
        }
    }
}
