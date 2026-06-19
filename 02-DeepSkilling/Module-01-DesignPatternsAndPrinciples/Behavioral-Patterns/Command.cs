using System;

interface ICommand
{
    void Execute();
}

class LightOnCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Light ON");
    }
}
