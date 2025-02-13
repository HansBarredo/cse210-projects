using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square();
        s1.SetColor("blue");
        s1.SetSide(45);
        Rectangle r1 = new Rectangle();
        r1.SetColor("red");
        r1.SetLength(15);
        r1.SethWidth(30);
        Circle c1 = new Circle();
        c1.SetColor("green");
        c1.SetRadius(15);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

         foreach(Shape shape in shapes)
         {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"Area = {area} \nColor = {color}");
         }
    }
    
}