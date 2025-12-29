using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Bir sayı girin: ");
            string input = Console.ReadLine();

            // Stringi tamsayıya dönüştürmeye çalışıyoruz
            int sayi = int.Parse(input);

            Console.WriteLine("Girdiğiniz sayı: " + sayi);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz!");
        }

        Console.WriteLine("Program çalışmaya devam ediyor.");
    }
}
