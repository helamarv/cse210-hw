using System;

public class Address
{
    private string _street { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _country { get; set; }


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"Street: {_street}");
        Console.WriteLine($"City: {_city}");
        Console.WriteLine($"State: {_state}");
        Console.WriteLine($"Country: {_country}");
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }
}