using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

#region Entities

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

public class OrderDetail
{
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int Quantity { get; set; }
}

#endregion

#region DbContext

public class ECommerceContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseInMemoryDatabase("ECommerceDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite Key for OrderDetail
        modelBuilder.Entity<OrderDetail>()
            .HasKey(od => new { od.OrderId, od.ProductId });

        base.OnModelCreating(modelBuilder);
    }
}

#endregion

#region Program

internal class Program
{
    static void Main(string[] args)
    {
        using var context = new ECommerceContext();

        // Create sample data
        var category = new Category { Name = "Electronics" };
        var product = new Product { Name = "Laptop", Price = 1200, Category = category };
        var customer = new Customer { Name = "Haidy", Email = "haidy@email.com" };
        var order = new Order { Customer = customer, OrderDate = DateTime.Now };
        var orderDetail = new OrderDetail { Order = order, Product = product, Quantity = 1 };

        context.Add(orderDetail);
        context.SaveChanges();

        // Query and display
        var orders = context.Orders
                            .Include(o => o.Customer)
                            .Include(o => o.OrderDetails)
                            .ThenInclude(od => od.Product)
                            .ToList();

        foreach (var o in orders)
        {
            Console.WriteLine($"{o.Customer.Name} ordered on {o.OrderDate}:");

            foreach (var detail in o.OrderDetails)
            {
                Console.WriteLine($" - {detail.Product.Name} (x{detail.Quantity}) at {detail.Product.Price}$");
            }
        }
    }
}

#endregion
