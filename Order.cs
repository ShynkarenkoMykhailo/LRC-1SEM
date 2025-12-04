using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public  class Order
    {
        private static int idCounter = 100; 
        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public  OrderStatus Status { get; set; }

        private List<MenuItem> items;

        public Order(int tableNumber)
        {
            Id = idCounter++;
            TableNumber = tableNumber;
            Status = OrderStatus.New;
            items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            items.Add(item);
            Console.WriteLine($"У замовлення {Id} додано: {item.Name}");
        }

        public decimal GetTotal()
        {
            
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
            return total;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"\n--- Замовлення #{Id} (Стіл {TableNumber}) ---");
            Console.WriteLine($"Статус: {Status}");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.GetInfo()}");
            }
            Console.WriteLine($"СУМА: {GetTotal()} грн\n");
        }
    }
}