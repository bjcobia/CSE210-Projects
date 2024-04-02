using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "SomeTown", "CA", "USA");
        Address address2 = new Address("555 W St", "Ontario", "Providence", "Canada");

        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        Product product1 = new Product("Cereal", "#198561", 5.99, 10);
        Product product2 = new Product("Milk", "#946512", 3.99, 20);
        Product product3 = new Product("Eggs", "#2598415", 2.99, 30);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${Math.Round(order1.CalculateTotalCost(), 2)}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${Math.Round(order2.CalculateTotalCost(), 2)}");

    }
}
