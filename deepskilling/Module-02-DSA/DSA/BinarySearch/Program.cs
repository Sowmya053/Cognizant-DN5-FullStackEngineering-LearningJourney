using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };

        int target = 50;

        int left = 0;
        int right = numbers.Length - 1;

        bool found = false;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (numbers[mid] == target)
            {
                Console.WriteLine("Element found at index: " + mid);
                found = true;
                break;
            }
            else if (numbers[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found");
        }
    }
}