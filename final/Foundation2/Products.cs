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

    public string Name { get; }
    public int ProductId { get; }
    public double Price { get; }
    public int Quantity { get; }

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