using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes
{
    public abstract class Drink : IDish
    {
        public int Cost { get; }

        public string Name { get; }

        public KitchenTypes Country { get; }

        public int Volume { get; }

        protected Drink(string name, int volume, int cost, KitchenTypes country)
        {
            Cost = cost;
            Name = name;
            Country = country;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"Наименование: {Name}; Объём: {Volume} мл; Стоимость: {Cost} рублей; Кухня: {Country.ToString()}";
        }
    }
}
