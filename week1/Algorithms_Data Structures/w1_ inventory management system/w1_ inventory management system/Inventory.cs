using System;
using System.Collections.Generic;

namespace w1__inventory_management_system
{
    public class Inventory
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.ProductId))
            {
                products[product.ProductId] = product;
                Console.WriteLine("Product added successfully.");
            }
            else
            {
                Console.WriteLine("Product ID already exists.");
            }
        }

        public void UpdateProduct(Product updatedProduct)
        {
            if (products.ContainsKey(updatedProduct.ProductId))
            {
                products[updatedProduct.ProductId] = updatedProduct;
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DeleteProduct(int productId)
        {
            if (products.Remove(productId))
            {
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Current Inventory:");
            foreach (var product in products.Values)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
        }
    }
}
