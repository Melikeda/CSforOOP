using System;

class Program
{
    static void Main()
    {
        Topla(5, 10);          // 1. metot çağrılır
        Topla(3.2, 4.8);       // 2. metot çağrılır
        Topla(2, 3, 4);        // 3. metot çağrılır
    }

    static void Topla(int a, int b)
    {
        Console.WriteLine("int metodu: " + (a + b));
    }

    static void Topla(double a, double b)
    {
        Console.WriteLine("double metodu: " + (a + b));
    }

    static void Topla(int a, int b, int c)
    {
        Console.WriteLine("3 parametreli metot: " + (a + b + c));
    }
}
