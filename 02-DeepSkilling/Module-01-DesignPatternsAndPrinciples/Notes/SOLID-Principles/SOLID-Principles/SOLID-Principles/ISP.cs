using System;

interface IPrinter
{
    void Print();
}

interface IScanner
{
    void Scan();
}

class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}
