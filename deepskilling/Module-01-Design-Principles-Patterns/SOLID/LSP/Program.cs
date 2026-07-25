using System;

interface IBird
{
}

interface IFlyable
{
    void Fly();
}

class Sparrow : IBird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

class Penguin : IBird
{
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming");
    }
}

class Program
{
    static void Main()
    {
        Sparrow sparrow = new Sparrow();
        sparrow.Fly();

        Penguin penguin = new Penguin();
        penguin.Swim();
    }
}