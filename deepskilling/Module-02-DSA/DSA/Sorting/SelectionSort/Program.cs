using System;

class Program
{
    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };

        Console.WriteLine("Original Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }

        Console.WriteLine("\nSorted Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}