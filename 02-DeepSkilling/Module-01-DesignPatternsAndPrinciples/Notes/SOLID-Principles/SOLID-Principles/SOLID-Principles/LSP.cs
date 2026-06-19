using System;

class Bird
{
    public virtual void Move()
    {
        Console.WriteLine("Bird Moving");
    }
}

class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Sparrow Flying");
    }
}
