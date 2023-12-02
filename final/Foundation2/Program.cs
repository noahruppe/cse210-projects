using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Townsville", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);

        Product product1 = new Product("Laptop", 101, 899.99, 2);
        Product product2 = new Product("Smartphone", 102, 499.99, 1);
        Product product3 = new Product("Tablet", 103, 299.99, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\n\nOrder 2 Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}