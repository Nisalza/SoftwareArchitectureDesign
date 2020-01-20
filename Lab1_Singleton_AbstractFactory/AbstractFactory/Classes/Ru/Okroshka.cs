using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes.Ru
{
    public class Okroshka : Soup
    {
        public Okroshka() : base("Окрошка", 90, 250, DensityTypes.Густой, KitchenTypes.Русская)
        {
        }
    }
}
