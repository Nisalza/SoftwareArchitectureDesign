using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes
{
    public abstract class MainCourse : IDish
    {
        public int Cost { get; }

        public string Name { get; }

        public KitchenTypes Country { get; }

        public int Weight { get; }

        protected MainCourse(string name, int weight, int cost, KitchenTypes country)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
            Country = country;
        }

        public override string ToString() =>
            $"Наименование: {Name}; Вес блюда: {Weight} гр; Стоимость: {Cost} рублей; Кухня: {Country.ToString()}";
    }
}
