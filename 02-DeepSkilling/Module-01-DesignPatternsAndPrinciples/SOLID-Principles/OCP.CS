using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius = 5;

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}
