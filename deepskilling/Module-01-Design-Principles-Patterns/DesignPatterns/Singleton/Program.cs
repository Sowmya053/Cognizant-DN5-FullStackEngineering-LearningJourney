using System;

class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Singleton Object Created");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }

        return instance;
    }
}

class Program
{
    static void Main()
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("Both objects are same");
        }
    }
}