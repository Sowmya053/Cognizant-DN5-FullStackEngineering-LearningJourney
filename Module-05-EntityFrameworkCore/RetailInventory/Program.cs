using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Retrieve all products
Console.WriteLine("All Products");
Console.WriteLine("------------");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine();

// Find product by ID
var product = await context.Products.FindAsync(1);

Console.WriteLine("Find By ID");
Console.WriteLine("----------");

if (product != null)
{
    Console.WriteLine($"Found: {product.Name}");
}
else
{
    Console.WriteLine("Product not found");
}

Console.WriteLine();

// First product with price greater than 50000
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine("First Expensive Product");
Console.WriteLine("-----------------------");

if (expensive != null)
{
    Console.WriteLine($"Expensive: {expensive.Name}");
}
else
{
    Console.WriteLine("No expensive product found");
}