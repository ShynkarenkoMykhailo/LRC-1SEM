using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Dish : MenuItem
    {
        private double weight;
        public Dish(string name, decimal price, MenuCategory category, double weight)
            : base(name, price, category)
        {
            this.weight = weight;
        }
        public override string GetInfo()
        {
            return $"Страва: {Name}, Категорія: {Category}, Вага: {weight}г, Ціна: {Price} грн";
        }
    }
}
