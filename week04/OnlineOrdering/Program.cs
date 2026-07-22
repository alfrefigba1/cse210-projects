using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer and address
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        // First order
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(
            "Laptop",
            "P1001",
            850.00,
            1
        ));

        order1.AddProduct(new Product(
            "Wireless Mouse",
            "P1002",
            25.00,
            2
        ));

        order1.AddProduct(new Product(
            "Keyboard",
            "P1003",
            45.00,
            1
        ));

        // Second customer and address
        Address address2 = new Address(
            "15 Gwarzo Road",
            "Kano",
            "Kano State",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "Amina Bello",
            address2
        );

        // Second order
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(
            "Smartphone",
            "P2001",
            500.00,
            1
        ));

        order2.AddProduct(new Product(
            "Phone Case",
            "P2002",
            20.00,
            2
        ));

        // Display first order
        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=================================");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

        // Display second order
        Console.WriteLine("\n=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=================================");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}