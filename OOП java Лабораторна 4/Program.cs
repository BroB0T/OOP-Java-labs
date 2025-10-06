using System;

abstract class Shape
{
    public static int ObjectCount { get; private set; } = 0;

    protected string shapeName;

    public Shape()
    {
        ObjectCount++;
    }

    public abstract float GetArea();
    public int CompareArea(Shape other)
    {
        if (GetArea() > other.GetArea()) return 1;
        if (GetArea() < other.GetArea()) return -1;
        return 0;
    }
}

class RightTriangle : Shape
{
    private float c;
    private float d;

    public float C { get => c; set => c = value; }
    public float D { get => d; set => d = value; }

    public RightTriangle(float c, float d)
    {
        this.c = c;
        this.d = d;
    }

    public override float GetArea()
    {
        return 0.5f * c * d;
    }
}

class Rectangle : Shape
{
    private float a;
    private float b;

    public float A { get => a; set => a = value; }
    public float B { get => b; set => b = value; }

    public Rectangle() { }
    public Rectangle(float a, float b)
    {
        this.a = a;
        this.b = b;
    }

    public override float GetArea()
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        // triangle
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


        // rectangle
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
        Shape rectangle = new Rectangle() { A = a, B = b };

        Console.WriteLine("\nrectangle area = " + rectangle.GetArea().ToString("F2"));

        // compare area
        int compare = rightTriangle.CompareArea(rectangle);

        if (compare > 0)
        {
            Console.WriteLine("The triangle has a larger area");
        }   
        else if (compare < 0)
        {
            Console.WriteLine("The rectangle has a larger area");
        }
        else
        {
            Console.WriteLine("The areas are equal");
        }
            

        Console.WriteLine($"Total objects created: {Shape.ObjectCount}");
    }
}