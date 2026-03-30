using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (Pakistan)
        Address a1 = new Address("Street 1", "Lahore", "Pakistan");
        Customer c1 = new Customer("Ramish", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Laptop", "A1", 500, 1));
        order1.AddProduct(new Product("Mouse", "B2", 20, 2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("Total Cost:");
        Console.WriteLine(order1.GetTotalCost());

        Console.WriteLine("\n---------------------\n");

        // Order 2 (USA)
        Address a2 = new Address("Street 2", "New York", "USA");
        Customer c2 = new Customer("John", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Phone", "C3", 300, 1));
        order2.AddProduct(new Product("Charger", "D4", 15, 2));

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("Total Cost:");
        Console.WriteLine(order2.GetTotalCost());
    }
}