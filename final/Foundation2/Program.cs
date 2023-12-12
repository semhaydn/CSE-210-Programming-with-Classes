using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating address for customers
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address nonUsaAddress = new Address("456 Oak St", "Othercity", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Jane Doe", nonUsaAddress);

        // Creating products
        Product product1 = new Product("Product A", "A123", 10.99, 2);
        Product product2 = new Product("Product B", "B456", 7.50, 3);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

        // Displaying order information
        DisplayOrderInformation(order1);
        DisplayOrderInformation(order2);
    }

    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
    }
}
