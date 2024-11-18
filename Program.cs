using System;

class FactorialTest
{
    static void Main()
    {
        for(int counter = 0; counter <= 10; ++counter)
        {
            Console.WriteLine($" {counter}! = {Factorial(counter)} ");
        }
    }

    static long Factorial(long number)  // sayıların artışı birden arttığı için int yerine long kullandık
    {
        if( number <= 1)  // 0! = 1 ve 1! = 1, bu bir tanımdır.
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

 