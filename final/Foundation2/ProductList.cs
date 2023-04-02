class ProductList
{
    private List<string> _list = new List<string>();

    // Constructor
    public ProductList()
    {
        string [] lines = File.ReadAllLines("productlist.txt");
        foreach (string line in lines)
        {
            string [] parts = line.Split("|");
            _list.Add($"{parts[0]},{parts[1]},{parts[2]},{parts[3]}");
        }
    }

    // Method

    public void DisplayList()
    {
        Console.Clear();
        int index = 1;
        foreach (string line in _list)
        {
            Console.WriteLine($"{index}. {line}");
            index += 1;
        }
    }

    public string ProdOrder()
    {
        Console.Write("Select item to order --> ");
        char prodOrd = char.Parse(Console.ReadLine());

        string ordLine = "";

        foreach(string line in _list)
        {
            if (prodOrd == line[0])
            {
                ordLine = line;
            }
        }

        return ordLine;
    }
}