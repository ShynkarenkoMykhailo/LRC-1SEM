using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Drink : MenuItem 
    {
        public double Volume { get; private set; } 
        public bool IsAlcoholic { get; private set; } 

        public Drink(string name, decimal price, double volume, bool isAlcoholic) 
            : base(name, price, MenuCategory.Drink) 
        {
            Volume = volume; 
            IsAlcoholic = isAlcoholic;
        }

        public override string GetInfo() 
        {
            string alc = IsAlcoholic ? "Алкогольний" : "Без алкоголю"; 
            return $"Напій: {Name}, Об'єм: {Volume}мл, {alc}, Ціна: {Price} грн"; 
        }

        public void OpenBottle() 
        {
            Console.WriteLine($"Пляшку {Name} відкрито.");
        }
    }
}