class Order
{
    private string _customer;
    private List<Product> _products = new List<Product>();

    // Constructor
    public Order()
    {

    }

    // Method
    public void CalcTotal()
    {

    }

    public void CalcShip()
    {

    }

    public void MakePack()
    {

    }

    public void MakeShip()
    {
        
    }

    public void PlaceOrder(string order, int qunt)
    {
        Console.Clear();

        Console.Write("Customer Name? --> ");
        _customer = Console.ReadLine();

        Customers cust = new Customers(_customer);

        



    }
}