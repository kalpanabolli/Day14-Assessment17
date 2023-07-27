using System;

class Shape
{
    public string ShapeType { get; set; }

    public virtual double Area { get; }
    public virtual double Perimeter { get; }

    public Shape(string shapeType)
    {
        ShapeType = shapeType;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine("Shape Type: " + ShapeType);
        Console.WriteLine("Area: " + Area);
        Console.WriteLine("Perimeter: " + Perimeter);
    }
}