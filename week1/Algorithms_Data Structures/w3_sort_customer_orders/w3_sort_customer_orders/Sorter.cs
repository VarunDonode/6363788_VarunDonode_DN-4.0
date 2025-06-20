﻿using System;
using w3_sort_customer_orders;

namespace w3_sort_customer_orders
{
    public class Sorter
    {
        public void BubbleSort(Order[] orders)
        {
            int n = orders.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                    {
                        var temp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = temp;
                    }
                }
            }
        }

        public void QuickSort(Order[] orders, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(orders, low, high);
                QuickSort(orders, low, pivotIndex - 1);
                QuickSort(orders, pivotIndex + 1, high);
            }
        }

        private int Partition(Order[] orders, int low, int high)
        {
            double pivot = orders[high].TotalPrice;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (orders[j].TotalPrice < pivot)
                {
                    i++;
                    var temp = orders[i];
                    orders[i] = orders[j];
                    orders[j] = temp;
                }
            }

            var t = orders[i + 1];
            orders[i + 1] = orders[high];
            orders[high] = t;

            return i + 1;
        }

        public void PrintOrders(Order[] orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"OrderID: {order.OrderId}, Customer: {order.CustomerName}, Price: {order.TotalPrice}");
            }
        }
    }
}
