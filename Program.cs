using System;

class ForEachTest
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int total = 0;

        foreach (int number in array)
        {
            total = total + number;
        }

        Console.WriteLine($"Total of array elements: {total}");
    }
}
   

 