using System;

class Program
{
    static void Main()
    {
        try
        {
            int sayi1 = 10;
            int sayi2 = 0;

            // Sıfıra bölme işlemi
            int sonuc = sayi1 / sayi2;

            Console.WriteLine("Sonuç: " + sonuc);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Hata: Sıfıra bölme işlemi yapılamaz!");
        }

        Console.WriteLine("Program çalışmaya devam ediyor.");
    }
}
