class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private string _zipcode;
    private string _string;

    // Constructor
    public Address()
    {
        Console.Write("Enter Street --> ");
        _street = Console.ReadLine();
        Console.Write("Enter City --> ");
        _city = Console.ReadLine();
        Console.Write("Enter State or Province --> ");
        _stateProvince= Console.ReadLine();
        Console.Write("Enter Country --> ");
        Console.Write("Enter Zip Code -->");
        _string = $"{_street}\n{_city}, {_stateProvince} {_zipcode}\n{_country}";
    }

    // Method
    public string GetAddress()
    {
        return _string;
    }
    public bool ShipCountry()
    {
        bool inCountry = true;
        if (_country == "US")
        {
            return inCountry;
        }
        else
        {
            return inCountry = false;
        }
    }

    public void PrintAddress()
    {
        Console.WriteLine(_string);
    }
}