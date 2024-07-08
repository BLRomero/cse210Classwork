using System;

class Customer{
    protected string _name;

       public string GetFullAddress()
    {
        return ($"{_streetAddress} {_city}, {_state}, {_country}");

    }
}