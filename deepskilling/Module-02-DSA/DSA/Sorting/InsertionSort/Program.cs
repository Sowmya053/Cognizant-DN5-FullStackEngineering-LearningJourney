using System;

class Program
{
    static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        Console.WriteLine("\nSorted Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}