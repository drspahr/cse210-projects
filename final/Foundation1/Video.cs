class Videos
{
    public  string _title;
    public string _author;
    public int _length;
    public List<Comments> _comments =new List<Comments>();

    // Constructors

    public Videos(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    
    // Methods

    public int NumComment()
    {
        return _comments.Count;
    }

    public void DisplayVid()
    {
        Console.WriteLine($"Title: {_title} - Author: {_author} - Video Length: {_length} - Number of Comments: {NumComment()}");

        foreach (Comments com in _comments)
        {
            Console.WriteLine(com.DisplayCom());
        }
    }

    public void CreateComment()
    {
        Comments comment = new Comments();
        comment.GetComment();
        _comments.Add(comment);
    }
}