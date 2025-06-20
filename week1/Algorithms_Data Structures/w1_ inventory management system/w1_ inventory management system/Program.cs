using System;

namespace w1__inventory_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddProduct(new Product { ProductId = 1, ProductName = "Laptop", Quantity = 10, Price = 60000 });
            inventory.AddProduct(new Product { ProductId = 2, ProductName = "Mouse", Quantity = 50, Price = 500 });

            inventory.DisplayProducts();

            inventory.UpdateProduct(new Product { ProductId = 1, ProductName = "Laptop Pro", Quantity = 8, Price = 70000 });

            inventory.DeleteProduct(2);

            inventory.DisplayProducts();
        }
    }
}
