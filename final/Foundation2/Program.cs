using System;

class Program
{
    static void Main(string[] args)
    {
        ProductList prod = new ProductList();
        
        int menuSel = 0;
        do
        {
            switch (menuSel = Menu())
            {
                case 1: prod.DisplayList(); Console.ReadLine(); break;
                case 2: PlaceOrder(prod); Console.ReadLine(); break;
                case 3: ; break;
                case 4: ; break;
            }
        } while (menuSel != 4);
    }

    static int Menu()
    {
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. View Products");
        Console.WriteLine("2. Place Order");
        Console.WriteLine("3. View Order");
        Console.WriteLine("4. Exit");

        Console.Write("What would you like to do? -->  ");
        int select = int.Parse(Console.ReadLine());

        return select;
    }

    static void PlaceOrder(ProductList prod)
    {
        prod.DisplayList();
        string lineOrd = prod.ProdOrder();
        
        Console.Write("How many would you like to order? --> ");
        int quant = int.Parse(Console.ReadLine());

        Order ord = new Order();
        ord.PlaceOrder(lineOrd, quant);
    }
}