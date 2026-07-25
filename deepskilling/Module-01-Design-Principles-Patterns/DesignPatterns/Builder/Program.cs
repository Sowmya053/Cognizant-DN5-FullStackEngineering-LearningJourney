using System;

class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
    }
}

class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRAM(string ram)
    {
        computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        computer.Storage = storage;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        Computer computer = new ComputerBuilder()
            .SetCPU("Intel i7")
            .SetRAM("16GB")
            .SetStorage("512GB SSD")
            .Build();

        computer.ShowDetails();
    }
}