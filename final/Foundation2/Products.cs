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

    protected string Name { get; }
    protected int ProductId { get; }
    protected double Price { get; }
    protected int Quantity { get; }

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