using OrderSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrederSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Restaurant restaurant = new Restaurant();

            restaurant.AddToMenu(new Dish("Борщ", 120, MenuCategory.Soup, 350));
            restaurant.AddToMenu(new Dish("Цезар", 180, MenuCategory.MainDish, 250));
            restaurant.AddToMenu(new Drink("Кола", 40, 500, false));
            restaurant.AddToMenu(new Drink("Вино", 150, 200, true));

            restaurant.ShowMenu();

            restaurant.CreateOrder(5); 

            Order myOrder = restaurant.FindOrder(100);

            MenuItem item1 = restaurant.FindInMenu("Борщ");
            MenuItem item2 = restaurant.FindInMenu("Вино");

            if (myOrder != null)
            {
                myOrder.AddItem(item1);
                myOrder.AddItem(item2);

                if (item2 is Drink)
                {
                    ((Drink)item2).OpenBottle();
                }

                myOrder.Status = OrderStatus.InProgress;
                myOrder.Status = OrderStatus.Ready;

                myOrder.PrintOrder();

                myOrder.Status = OrderStatus.Paid;
                Console.WriteLine("Замовлення оплачено.");
            }

            restaurant.ShowActiveOrders();

            Console.ReadLine();
        }
    }
}

