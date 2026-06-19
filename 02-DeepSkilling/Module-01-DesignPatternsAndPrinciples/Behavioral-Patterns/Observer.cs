using System;

interface IObserver
{
    void Update();
}

class User : IObserver
{
    public void Update()
    {
        Console.WriteLine("Notification Received");
    }
}
