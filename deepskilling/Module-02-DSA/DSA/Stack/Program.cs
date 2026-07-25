using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack Elements:");

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nTop Element: " + stack.Peek());

        Console.WriteLine("Removed Element: " + stack.Pop());

        Console.WriteLine("\nStack After Pop:");

        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}