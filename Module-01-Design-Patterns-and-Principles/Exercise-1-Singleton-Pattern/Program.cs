using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();

        logger1.Log("First Message");

        Logger logger2 = Logger.GetInstance();

        logger2.Log("Second Message");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both objects are the same instance.");
        }
        else
        {
            Console.WriteLine("Objects are different.");
        }
    }
}