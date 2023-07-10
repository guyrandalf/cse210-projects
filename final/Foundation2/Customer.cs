using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.BuildAddress();
    }

    public bool OutsideorInside()
    {
        if (_address.CheckCountry())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
