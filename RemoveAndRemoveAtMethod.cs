using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sayilar = new List<int> { 10, 20, 30, 20, 40 };

        sayilar.Remove(20);
        sayilar.RemoveAt(2);

        foreach (var s in sayilar)
        {
            Console.WriteLine(s);
        }
    }
}
