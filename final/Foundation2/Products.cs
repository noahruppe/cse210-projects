using System;

public class Product
{
    public Product(string name, int productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    private string Name { get; }
    private int ProductId { get; }
    private double Price { get; }
    private int Quantity { get; }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }

    public string GetProductName()
    {
        return Name;
    }

    public int GetProductId()
    {
        return ProductId;
    }
}