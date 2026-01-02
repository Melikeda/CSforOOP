using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var isimler = new[] { "ali", "ayşe", "mehmet" };

        var sonuc = from i in isimler
                    select i.ToUpper();

        foreach (var x in sonuc)
            Console.WriteLine(x);
    }
}
