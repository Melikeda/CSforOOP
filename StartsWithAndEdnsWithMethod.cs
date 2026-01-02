using System;

class Program
{
    static void Main()
    {
        string metin = "Programlama";

        bool a = metin.StartsWith("Pro");
        bool b = metin.StartsWith("pro");
        bool c = metin.EndsWith("ma");
        bool d = metin.EndsWith("MA");

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}
