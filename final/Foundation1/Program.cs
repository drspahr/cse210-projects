using System;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> _videos = new List<Videos>();

        Console.WriteLine();
        Videos vid1 = new Videos("Fun Flying", "DGS Fly", 1800);
        vid1.CreateComment();
        vid1.CreateComment();
        vid1.CreateComment();
        _videos.Add(vid1);

        Console.WriteLine();
        Videos vid2 = new Videos("C4 Care", "VetteMaint", 1200);
        vid2.CreateComment();
        vid2.CreateComment();
        vid2.CreateComment();
        _videos.Add(vid2);

        Console.WriteLine();
        Videos vid3 = new Videos("Pre-Flight", "DGS Fly", 2700);
        vid3.CreateComment();
        vid3.CreateComment();
        vid3.CreateComment();
        _videos.Add(vid3);

        Console.Clear();
        foreach (Videos vid in _videos)
        {   
            vid.DisplayVid();
            Console.WriteLine();
        }
    }
}