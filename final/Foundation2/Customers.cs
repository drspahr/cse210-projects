class Customers
{
    private string _name;
    private string _address;

    // Constructor
    public Customers(string name)
    {
        _name = name;
    }

    // Method
    public void CustomerAddress()
    {
        Address address = new Address();
        _address = address.GetAddress();


    }

    
}