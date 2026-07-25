using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> maxHeap = new List<int>();

        maxHeap.Add(50);
        maxHeap.Add(30);
        maxHeap.Add(20);
        maxHeap.Add(15);
        maxHeap.Add(10);

        Console.WriteLine("Max Heap Elements:");

        foreach (int item in maxHeap)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Root Element: " + maxHeap[0]);

        maxHeap.RemoveAt(0);

        Console.WriteLine("Heap After Deleting Root:");

        foreach (int item in maxHeap)
        {
            Console.Write(item + " ");
        }
    }
}