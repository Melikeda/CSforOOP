using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] sayilar = { 1, 2, 3 };

            // Geçersiz bir indeks ile diziye erişim
            Console.WriteLine(sayilar[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Hata: Dizi sınırlarının dışına çıkıldı!");
        }

        Console.WriteLine("Program çalışmaya devam ediyor.");
    }
}
