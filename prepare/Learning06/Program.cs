using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        Square square = new Square("blue", 4);
        


        Circle circle = new Circle("red", 5.65);
        

        Rectangle rectangle = new Rectangle("pink", 12, 2);
       

        List<Shape> shapes = [square, circle, rectangle];

        foreach (Shape s in shapes)
        {   
            Console.WriteLine();
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
        }

    }
}