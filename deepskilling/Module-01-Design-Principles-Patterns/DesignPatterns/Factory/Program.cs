using System;

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class ShapeFactory
{
    public static IShape GetShape(string shapeType)
    {
        if (shapeType == "Circle")
            return new Circle();

        if (shapeType == "Rectangle")
            return new Rectangle();

        return null;
    }
}

class Program
{
    static void Main()
    {
        IShape shape1 = ShapeFactory.GetShape("Circle");
        shape1.Draw();

        IShape shape2 = ShapeFactory.GetShape("Rectangle");
        shape2.Draw();
    }
}