using Lab1_Singleton_AbstractFactory.AbstractFactory.Enums;
using Lab1_Singleton_AbstractFactory.AbstractFactory.Interfaces;

namespace Lab1_Singleton_AbstractFactory.AbstractFactory.Classes
{
    public abstract class Soup : IDish
    {
        public int Cost { get; }
        public string Name { get; }
        public KitchenTypes Country { get; }
        public int Weight { get; }
        public DensityTypes Density { get; }

        protected Soup(string name, int cost, int weight, DensityTypes density, KitchenTypes kitchen)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
            Density = density;
            Country = kitchen;
        }

        public override string ToString() =>
            $"Наименование: {Name}; Стоимость: {Cost} рублей; Вес порции: {Weight} грамм; Плотность: {Density.ToString()}; Кухня: {Country.ToString()}";
    }
}
