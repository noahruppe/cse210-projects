using System;
using System.Collections.Generic;

public class Order
{
    private readonly Customer customer;
    private readonly List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0.0;
        foreach (var product in products)
        {
            total += product.GetTotalPrice();
        }
        total += (customer.IsUSCustomer() ? 5.0 : 35.0);
        return double.Parse(total.ToString("F2"));
    }

    public string GetPackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"Product: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer Name: {customer.GetName()}\nCustomer Address: {customer.GetAddress()}";
    }
}