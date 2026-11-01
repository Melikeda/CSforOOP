using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bölünecek sayıyı girin:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen bölen sayıyı girin:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            // Hata çıkma ihtimali olan kod (Sıfıra bölme hatası oluşabilir)
            int sonuc = sayi1 / sayi2;
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        catch (DivideByZeroException ex)
        {
            // Hata gerçekleştiğinde çalışacak kod
            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
            Console.WriteLine($"Sistem mesajı: {ex.Message}");
        }
        
        Console.WriteLine("Program güvenli bir şekilde çalışmaya devam ediyor.");
    }
}
