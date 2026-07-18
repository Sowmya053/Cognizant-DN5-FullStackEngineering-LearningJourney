using System;

public class Logger
{
    // Stores the single object
    private static Logger instance;

    // Prevents creating objects from outside
    private Logger()
    {
        Console.WriteLine("Logger Instance Created");
    }

    // Returns the single instance
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}