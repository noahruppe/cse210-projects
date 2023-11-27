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

    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }

    public bool IsUSAddress()
    {
        return Country == "USA";
    }

    public string GetAddressDetails()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}