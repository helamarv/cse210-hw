using System;

public class Customer
{
    private string _name { get; set; }
    private Address _address { get; set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {_name}");
        _address.DisplayAddress();
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}