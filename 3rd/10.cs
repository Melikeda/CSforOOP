// Prefix increment and postfix increment operators.

using System;

class Increment
{
    static void Main()
    {
        // demonstrate postfix increment operator
        int c = 5; // assign 5 to c
        Console.WriteLine($"c before postincrement: {c}"); // displays 5
        Console.WriteLine($"c postincrement: {c++}"); // displays 5
        Console.WriteLine($"c after postincrement: {c}"); // displays 6

        Console.WriteLine(); // skip a line

        // demonstrate prefix increment operator
        c = 5; // assign 5 to c
        Console.WriteLine($"c before preincrement: {c}"); // displays 5
        Console.WriteLine($"c preincrement: {++c}"); // displays 6
        Console.WriteLine($"c after preincrement: {c}"); // displays 6
    }
}
