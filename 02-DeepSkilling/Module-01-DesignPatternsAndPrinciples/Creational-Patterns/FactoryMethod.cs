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

class ShapeFactory
{
    public static IShape CreateShape()
    {
        return new Circle();
    }
}
