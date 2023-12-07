using System;

public class Address
{
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    private string Street { get; }
    private string City { get; }
    private string State { get; }
    private string Country { get; }

    public bool IsUSAddress()
    {
        return Country == "USA";
    }

    public string GetAddressDetails()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}