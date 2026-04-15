using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square sq1 = new Square("blue", 4);
        Console.WriteLine(sq1.GetColor());
        Console.WriteLine(sq1.GetArea());

        Rectangle rec1 = new Rectangle("orange", 3, 5);
        Console.WriteLine(rec1.GetColor());
        Console.WriteLine(rec1.GetArea());

        Circle cir1 = new Circle("yellow", 2);
        Console.WriteLine(cir1.GetColor());
        Console.WriteLine(cir1.GetArea());

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(sq1);
        _shapes.Add(rec1);
        _shapes.Add(cir1);

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}