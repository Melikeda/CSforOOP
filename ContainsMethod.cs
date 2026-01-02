using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sayilar = new List<int> { 10, 20, 30, 40 };

        bool sonuc1 = sayilar.Contains(20);
        bool sonuc2 = sayilar.Contains(25);

        Console.WriteLine(sonuc1);
        Console.WriteLine(sonuc2);
    }
}
