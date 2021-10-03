using System;
using static OpenClosedPrinciple.Constants;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();
            Console.WriteLine("Green products (Old): ");
            foreach (var product in productFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            var betterFilter = new BetterFilter();
            Console.WriteLine("Green products (New): ");
            foreach (var product in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            Console.WriteLine("Large Blue Items");
            foreach(var product in betterFilter.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {product.Name} is Large and Blue");
            }
        }
    }
}
