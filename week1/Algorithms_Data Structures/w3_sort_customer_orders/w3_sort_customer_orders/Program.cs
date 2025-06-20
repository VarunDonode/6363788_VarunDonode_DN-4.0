using System;
using w3_sort_customer_orders;

namespace w3__sort_customer_orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[]
            {
                new Order { OrderId = 1, CustomerName = "Varun", TotalPrice = 4500 },
                new Order { OrderId = 2, CustomerName = "Aman", TotalPrice = 12000 },
                new Order { OrderId = 3, CustomerName = "Sneha", TotalPrice = 800 },
                new Order { OrderId = 4, CustomerName = "Riya", TotalPrice = 3200 }
            };

            Sorter sorter = new Sorter();

            Console.WriteLine("Before Sorting:");
            sorter.PrintOrders(orders);


            Console.WriteLine("\n--- Bubble Sort ---");
            sorter.BubbleSort(orders);

            Console.WriteLine("\nAfter Sorting by TotalPrice:");
            sorter.PrintOrders(orders);
        }
    }
}
