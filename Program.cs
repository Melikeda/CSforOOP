using System;
using System.Linq;

class LinqTest
{
    static void Main()
    {
        var values = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Original array ");

        foreach( var element in values)
        {
            Console.Write($" {element}");
        }

        var filtered =
            from value in values
            where value > 4
            select value;

        Console.Write("\nArray values greater than 4:");

        foreach(var element in filtered)
        {
            Console.Write($" {element}");
        }

        var sorted =
            from value in values
            orderby value
            select value;

        Console.Write("\nOriginal array, sorted:");

        foreach (var element in sorted)
        {
            Console.Write($" {element}");
        }

        var sortFilteredResults =
            from value in filtered
            orderby value descending
            select value;

        Console.Write("\nValues greater than 4; descending order (two quaries) : ");

        foreach (var element in sortFilteredResults)
        {
            Console.Write($" {element}");
        }


        var sortAndFilter =
            from value in values
            where value > 4
            orderby value descending
            select value;

        Console.Write("\nValues greater than 4; descending order (one query) : ");

        foreach (var element in sortAndFilter)
        {
            Console.Write($" {element}");
        }

    }
}


   

 