using System;

interface ITarget
{
    void Request();
}

class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific Request");
    }
}

class Adapter : ITarget
{
    private Adaptee adaptee = new Adaptee();

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}
