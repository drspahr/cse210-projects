class Comments
{
    public string _name;
    public string _comments;

    // Constructor

    public Comments()
    {
    
    }

    // Methods
    public void GetComment()
    {
        Console.Write("Enter name of commentor: ");
        _name = Console.ReadLine();

        Console.Write("Enter comment: ");
        _comments = Console.ReadLine();
    }

    public string DisplayCom()
    {
        return $"{_name}, {_comments}";
    }
}