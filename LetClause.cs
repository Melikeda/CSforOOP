using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sayilar = new[] { 10, 20, 30 };

        var sonuc = from s in sayilar
                    let kare = s * s
                    where kare > 300
                    select kare;

        foreach (var x in sonuc)
        {
            Console.WriteLine(x);
        }
    }
}
