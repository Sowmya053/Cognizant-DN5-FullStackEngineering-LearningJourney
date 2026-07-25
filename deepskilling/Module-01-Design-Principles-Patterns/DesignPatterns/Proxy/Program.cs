using System;

interface IInternet
{
    void ConnectTo(string website);
}

class RealInternet : IInternet
{
    public void ConnectTo(string website)
    {
        Console.WriteLine("Connecting to " + website);
    }
}

class ProxyInternet : IInternet
{
    private RealInternet internet = new RealInternet();

    public void ConnectTo(string website)
    {
        if (website.ToLower() == "facebook.com")
        {
            Console.WriteLine("Access Denied");
        }
        else
        {
            internet.ConnectTo(website);
        }
    }
}

class Program
{
    static void Main()
    {
        IInternet internet = new ProxyInternet();

        internet.ConnectTo("google.com");
        internet.ConnectTo("facebook.com");
    }
}