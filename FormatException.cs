using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse("abc"); // HATALI FORMAT
            Console.WriteLine("Girilen sayı: " + sayi);
        }
        catch (FormatException)
        {
            Console.WriteLine("Format hatası! Sayı girilmedi.");
        }

        Console.ReadLine();
    }
}
