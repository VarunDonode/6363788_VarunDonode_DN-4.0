using System;

namespace w2__ecommerce_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product { ProductId = 101, ProductName = "Mouse", Category = "Electronics" },
                new Product { ProductId = 102, ProductName = "Keyboard", Category = "Electronics" },
                new Product { ProductId = 103, ProductName = "Charger", Category = "Accessories" },
                new Product { ProductId = 104, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 105, ProductName = "Pen", Category = "Stationery" }
            };

            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            SearchEngine search = new SearchEngine();

            Console.WriteLine("Searching for 'Laptop' (Binary Search):");
            var result1 = search.BinarySearch(products, "Laptop");
            Console.WriteLine(result1 != null ? $"Found: {result1.ProductName} ({result1.Category})" : "Not Found");

            Console.WriteLine("\nSearching for 'Pen' (Linear Search):");
            var result2 = search.LinearSearch(products, "Pen");
            Console.WriteLine(result2 != null ? $"Found: {result2.ProductName} ({result2.Category})" : "Not Found");
        }
    }
}
