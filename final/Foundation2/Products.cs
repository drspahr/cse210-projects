class Product
{
    private string _name;
    private string _product;
    private float _price;
    private int _quantity;

    // Constructor
    public Product()
    {

    }

    // Method
    public void CalPrice()
    {

    }

    public void DispalyProd()
    {
        Console.Clear(); 
        Console.WriteLine($"{_name}, {_product}, {_price}, {_quantity}");
    }
}