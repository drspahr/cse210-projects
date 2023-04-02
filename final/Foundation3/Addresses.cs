class Address : Events
{
    private string _address;
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    // Constructor
    public Address()
    {

    }
    public Address(string title, string desc, string date, string time) : base(title, desc, date, time)
    {

    }

    // Method
    public void DisplayAddress()
    {
        Console.WriteLine(_address);
    }

    public void GetAddress()
    {
        Console.WriteLine("Enter Address.");
        Console.Write("Street? ");
        _street = Console.ReadLine();
        Console.Write("City? ");
        _city = Console.ReadLine();
        Console.Write("State? ");
        _state = Console.ReadLine();
        Console.Write("Zip? ");
        _zip = Console.ReadLine();

        _address = $"{_street}\n{_city}, {_state} {_zip}";
    }
}