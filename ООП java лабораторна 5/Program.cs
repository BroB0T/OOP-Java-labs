using System;

public interface IShape
{
    string name { get; set; }
    float GetArea();
}
public interface Test : IShape
{
    void Test();
}

abstract class Shape : IShape
{
    public static int ObjectCount { get; private set; } = 0;
    public string name { get; set; }

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

    public RightTriangle(float c, float d)
    {
        this.c = c;
        this.d = d;
        name = "Right Triangle";
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

    public Rectangle() { }
    public Rectangle(float a, float b)
    {
        this.a = a;
        this.b = b;
        name = "Rectangle";
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
        // IShape
        IShape triangle = new RightTriangle(1, 4);
        Console.WriteLine(triangle.name + "\tarea = " + triangle.GetArea().ToString("F2"));

        // Shape
        Shape rectangle = new Rectangle(5, 2);
        Console.WriteLine(rectangle.name + "\tarea = " + rectangle.GetArea().ToString("F2"));
        // Triangle
        RightTriangle triangle2 = new RightTriangle(6, 2);
        Console.WriteLine(triangle2.name + "\tarea = " + triangle2.GetArea().ToString("F2"));

        // Compare area
        int compare = rectangle.CompareArea((RightTriangle)triangle);
        if (compare > 0)
        {
            Console.WriteLine("Rectangle larger");
        }
        else if (compare < 0)
        {
            Console.WriteLine("Triangle larger");
        }
        else
        {
            Console.WriteLine("Equal area");
        }
            

        Console.WriteLine("Total objects created:" + Shape.ObjectCount);
    }
}