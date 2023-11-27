using System;

public class Customer
{
    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public string Name { get; }
    public Address Address { get; }

    public bool IsUSCustomer()
    {
        return Address.IsUSAddress();
    }

    public string GetName()
    {
        return Name;
    }

    public string GetAddress()
    {
        return Address.GetAddressDetails();
    }
}