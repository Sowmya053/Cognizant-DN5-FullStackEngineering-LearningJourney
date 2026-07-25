using System;

interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

class Human : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Human is working");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating");
    }
}

class Robot : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot is working");
    }
}

class Program
{
    static void Main()
    {
        Human human = new Human();
        human.Work();
        human.Eat();

        Robot robot = new Robot();
        robot.Work();
    }
}