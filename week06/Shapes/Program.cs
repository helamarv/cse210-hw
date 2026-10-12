using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        //Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} {s.GetType().Name} has an area of: {area}"); 
        }   
    }
}