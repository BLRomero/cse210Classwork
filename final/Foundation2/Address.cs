using System;

class Address
{
    protected string _streetAddress;
    protected string _city;
    protected string _state;
    protected string _country;


    Address(string streetAddress, string city, string state, string country)
    {

        streetAddress = _streetAddress;
        city = _city;
        state = _state;
        country = _country;

    }

    // IsUSA(Boolean){

    // }
    public string GetFullAddress()
    {
        return ($"{_streetAddress} {_city}, {_state}, {_country}");

    }
}
