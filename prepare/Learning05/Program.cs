using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Square sqr = new Square("red", 10);
        // Console.WriteLine($"The colore is {sqr.GetColor()} with an area of {sqr.GetArea()}\n");

        // Rectangle rec = new Rectangle("blue", 5, 15);
        // Console.WriteLine($"The color is {rec.GetColor()} with an area of {rec.GetArea()}\n");

        // Circle cir = new Circle("green", 4);
        // Console.WriteLine($"The color is {cir.GetColor()} with an area of {cir.GetArea()}\n");

        List<Shape> shapes = new List<Shape>();
        
        Square sq1 = new Square("White", 5);
        shapes.Add(sq1);

        Rectangle rec1 = new Rectangle("Yellow", 4, 25);
        shapes.Add(rec1);

        Circle cir1 = new Circle("Orange", 20);
        shapes.Add(cir1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape} is {shape.GetColor()} with an area of {shape.GetArea()}\n");
        }

    }
}