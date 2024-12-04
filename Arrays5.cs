using System;

class InitArray
{
    static void Main()
    {
        int[] array = { 12, 23, 34, 45, 56 };

        Console.WriteLine($"{"Index"}{"Value",8}");

        for (int counter = 0; counter < array.Length; ++counter)
        {
            Console.WriteLine($"{counter,5}{array[counter],8}");
        }
    }
}
