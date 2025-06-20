using System;

namespace w2__ecommerce_search
{
    public class SearchEngine
    {
        public Product LinearSearch(Product[] products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }
        public Product BinarySearch(Product[] products, string name)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0) return products[mid];
                else if (comparison < 0) left = mid + 1;
                else right = mid - 1;
            }

            return null;
        }
    }
}
