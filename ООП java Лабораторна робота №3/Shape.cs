using System;

abstract class Shape
{
    public abstract float GetArea();
}

class RightTriangle : Shape
{
    private float C;
    private float D;

    public RightTriangle(float c, float d)
    {
        C = c;
        D = d;
    }

    public override float GetArea()
    {
        return 0.5f * C * D;
    }
}

class Rectangle : Shape
{
    private float A;
    private float B;
    
    public Rectangle(float a, float b)
    {
        A = a;
        B = b;
    }
    public override float GetArea()
    {
        return A * B;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter legs of a triangle");
        Console.Write("C = ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("D = ");
        float d = float.Parse(Console.ReadLine());

        if (c <= 0 || d <= 0)
        {
            Console.WriteLine("ERROR: incorrect input");
            return;
        }
        Shape rightTriangle = new RightTriangle(c, d);
        Console.WriteLine("\ntriangle area = " + rightTriangle.GetArea().ToString("F2"));


        Console.WriteLine("\n\nEnter sides of a rectangle");
        Console.Write("A = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("B = ");
        float b = float.Parse(Console.ReadLine());

        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("ERROR: incorrect input");
            return;
        }
        Shape rectangle = new Rectangle(a, b);
        Console.WriteLine("\nrectangle area = " + rectangle.GetArea().ToString("F2"));
    }
}