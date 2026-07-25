using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

class SMS : IMessage
{
    public void Send()
    {
        Console.WriteLine("SMS Sent");
    }
}

class Notification
{
    private readonly IMessage _message;

    public Notification(IMessage message)
    {
        _message = message;
    }

    public void NotifyUser()
    {
        _message.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessage email = new Email();
        Notification notification = new Notification(email);

        notification.NotifyUser();
    }
}