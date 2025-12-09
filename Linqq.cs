using System;
using System.Linq;

class LinqWithSimpleTypeArray
{
  static void Main()
  {
    var values = new [] {2,9,5,0,3,7,1,4,8,5};

    Consolo.Write("Original Array: ");
    foreach (var element in values)
    {
      Console.Write($" {element}" );
    }

    var filtered =
      from value in values
      where value > 4
      select  value;

    Console.WriteLine("Array values greater than 4: ");
    foreach (var element in filtered)
    {
      Console.Write($" {element}" );
    }

    var sorted = 
      from value in values 
      ordey by value
      select value;

    Console.WriteLine("Original array sorted: ");
    foreach (var element in sorted)
    {
      Console.Write($" {element}" );
    }

    var sortFilteredResults = 
      from value in filtered
      ordey by value descending 
      select value;

    Console.WriteLine("Values greater than 4, descending order (two queries): ");

    foreach (var element in sortFilteredResults)
    {
      Console.Write($" {element}" );
    }

    var sortAndFilter = 
      from value in values
      where value > 4
      order by value descending
      select value;

     Console.WriteLine("Values greater than 4, descending order (one query): ");

    foreach (var element in sortAndFilter)
    {
      Console.Write($" {element}" );
    }
  }
