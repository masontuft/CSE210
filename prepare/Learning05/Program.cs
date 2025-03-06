using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
         Square square = new Square(5, "blue");
        Console.WriteLine($"Square area: {square.GetArea()}");
        Console.WriteLine($"Square color: {square.GetColor()}");
        square.SetColor("red");
        Console.WriteLine($"Square color: {square.GetColor()}");
        Circle circle = new Circle(5, "green");
        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine($"Circle color: {circle.GetColor()}");
        circle.SetColor("yellow");
        Console.WriteLine($"Circle color: {circle.GetColor()}");
        Rectangle rectangle = new Rectangle(5, 10, "purple");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
        rectangle.SetColor("orange");
        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape area: {shape.GetArea()}");
            Console.WriteLine($"Shape color: {shape.GetColor()}");
        }
        
    }
}