using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sayilar = new List<int> { 10, 20, 30 };

        sayilar.Add(40);
        sayilar.Insert(1, 15);
        sayilar.Add(50);

        foreach (var s in sayilar)
        {
            Console.WriteLine(s);
        }
    }
}
