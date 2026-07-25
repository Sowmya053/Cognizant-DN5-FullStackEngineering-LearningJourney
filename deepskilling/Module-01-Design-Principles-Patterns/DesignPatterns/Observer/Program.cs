using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(string message);
}

class Subscriber : IObserver
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received: {message}");
    }
}

class YouTubeChannel
{
    private List<IObserver> subscribers = new List<IObserver>();

    public void Subscribe(IObserver observer)
    {
        subscribers.Add(observer);
    }

    public void NotifySubscribers(string videoTitle)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(videoTitle);
        }
    }
}

class Program
{
    static void Main()
    {
        YouTubeChannel channel = new YouTubeChannel();

        Subscriber s1 = new Subscriber("Madhumitha");
        Subscriber s2 = new Subscriber("Rahul");

        channel.Subscribe(s1);
        channel.Subscribe(s2);

        channel.NotifySubscribers("New C# Tutorial Uploaded");
    }
}