using System;

public class Product
{
    public string _name { get; set; }
    public string _productId { get; set; }
    private double _price { get; set; }
    private int _quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Price: ${_price}");
        Console.WriteLine($"Quantity: {_quantity}");
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}