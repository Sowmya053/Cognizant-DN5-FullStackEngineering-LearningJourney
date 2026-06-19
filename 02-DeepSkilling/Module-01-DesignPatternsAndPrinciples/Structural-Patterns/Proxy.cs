using System;

interface IImage
{
    void Display();
}

class RealImage : IImage
{
    public void Display()
    {
        Console.WriteLine("Displaying Image");
    }
}

class ProxyImage : IImage
{
    private RealImage image = new RealImage();

    public void Display()
    {
        image.Display();
    }
}
