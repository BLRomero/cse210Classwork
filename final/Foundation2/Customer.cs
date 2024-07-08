using System;

class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public void AddCustomerName(string name)
    {
        _customerName = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool isInUSA()
    {
        return _address.isUSA();
    }
}
