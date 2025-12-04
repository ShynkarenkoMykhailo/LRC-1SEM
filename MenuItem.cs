using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public abstract class MenuItem
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public MenuCategory Category { get; protected set; }


        public MenuItem(string name, decimal price, MenuCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public abstract string GetInfo();
    }
}
