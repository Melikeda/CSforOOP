// Computing the sum of the elements of an array.
using System;

class SumArray
{
    static void Main()
    {
        int[] array = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
        int total = 0;

        // add each element's value to total
        for (int counter = 0; counter < array.Length; ++counter)
        {
            total += array[counter]; // add element value to total
        }

        Console.WriteLine($"Total of array elements: {total}");
    }
}
