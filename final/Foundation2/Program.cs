using System;
using System.Collections.Generic;

class Order
{
    // Attributes
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    // Methods
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.Price;
        }

        // Add shipping cost based on customer location
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        // Implement packing label generation
        return "Packing Label";
    }

    public string GetShippingLabel()
    {
        // Implement shipping label generation
        return "Shipping Label";
    }
}

class Product
{
    // Attributes
    private string name;
    private string productId;
    private double price;

    // Constructor
    public Product(string name, string productId, double price)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
    }

    // Properties
    public double Price
    {
        get { return price; }
    }
}

class Customer
{
    // Attributes
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Methods
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}

class Address
{
    // Attributes
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Methods
    public bool IsInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        // Create a customer
        Address customerAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer myCustomer = new Customer("John Doe", customerAddress);

        // Create an order
        Order myOrder = new Order(myCustomer);

        // Add products to the order
        Product product1 = new Product("Product A", "A001", 10.99);
        Product product2 = new Product("Product B", "B002", 20.49);
        myOrder.AddProduct(product1);
        myOrder.AddProduct(product2);

        // Display order information
        Console.WriteLine($"Total Cost: ${myOrder.CalculateTotalCost()}");
    }
}
