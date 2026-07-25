using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Queue Elements:");

        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nFront Element: " + queue.Peek());

        Console.WriteLine("Removed Element: " + queue.Dequeue());

        Console.WriteLine("\nQueue After Dequeue:");

        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}