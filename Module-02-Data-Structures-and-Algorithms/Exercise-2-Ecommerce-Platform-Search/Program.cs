using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Mobile","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Book","Education")
        };

        Console.WriteLine("Linear Search");

        Product linear = SearchService.LinearSearch(products, "Shoes");

        if (linear != null)
        {
            Console.WriteLine($"Product Found: {linear.ProductName}");
        }

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        Console.WriteLine();

        Console.WriteLine("Binary Search");

        Product binary = SearchService.BinarySearch(products, "Shoes");

        if (binary != null)
        {
            Console.WriteLine($"Product Found: {binary.ProductName}");
        }
    }
}