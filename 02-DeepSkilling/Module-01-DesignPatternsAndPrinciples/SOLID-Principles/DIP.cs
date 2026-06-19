using System;

interface IMessageService
{
    void SendMessage();
}

class EmailService : IMessageService
{
    public void SendMessage()
    {
        Console.WriteLine("Email Sent");
    }
}

class Notification
{
    private IMessageService service;

    public Notification(IMessageService service)
    {
        this.service = service;
    }

    public void Notify()
    {
        service.SendMessage();
    }
}
