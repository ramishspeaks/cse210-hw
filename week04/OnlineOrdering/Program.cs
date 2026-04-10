using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address a1 = new Address("Street 1", "New York", "NY", "USA");
        Customer c1 = new Customer("Ramish", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Laptop", "P001", 500, 1));
        order1.AddProduct(new Product("Mouse", "P002", 20, 2));

        // Order 2 (International)
        Address a2 = new Address("Street 2", "Lahore", "Punjab", "Pakistan");
        Customer c2 = new Customer("Ali", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Phone", "P003", 300, 1));
        order2.AddProduct(new Product("Charger", "P004", 15, 3));

        // Display
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: {order1.GetTotalCost()}");

        Console.WriteLine("-------------------");

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: {order2.GetTotalCost()}");
    }
} 