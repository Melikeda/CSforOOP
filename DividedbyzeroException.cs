using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;

            int sonuc = a / b;   // HATA burada oluşur
            Console.WriteLine(sonuc);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Sıfıra bölme hatası!");
        }

        Console.ReadLine();
    }
}
