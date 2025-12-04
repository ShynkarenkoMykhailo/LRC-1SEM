using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Restaurant
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private List<Order> orders = new List<Order>();

        public void AddToMenu(MenuItem item)
        {
            menu.Add(item);
        }

        public  Order FindOrder(int id)
        {
            foreach (var order in orders)
            {
                if (order.Id == id) return order;
            }
            return null;
        }

        public MenuItem FindInMenu(string name)
        {
            foreach (var item in menu)
            {
                if (item.Name == name) return item;
            }
            return null;
        }

        public void CreateOrder(int tableNumber)
        {
            Order newOrder = new(tableNumber);
            orders.Add(newOrder);
            Console.WriteLine($"Створено нове замовлення ID: {newOrder.Id} для столика {tableNumber}");
        }

        public void ShowMenu()
        {
            Console.WriteLine("\n--- МЕНЮ РЕСТОРАНУ ---");
            foreach (var item in menu)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine("----------------------");
        }

        public void ShowActiveOrders()
        {
            Console.WriteLine("\n--- АКТИВНІ ЗАМОВЛЕННЯ ---");
            foreach (var order in orders)
            {
                if (order.Status != OrderStatus.Paid)
                {
                    order.PrintOrder();
                }
            }
        }
    }
}

