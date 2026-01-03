using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] dizi = { 10, 20, 30 };

            Console.WriteLine(dizi[5]); // HATA: index yok
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Dizi sınırları aşıldı!");
        }

        Console.ReadLine();
    }
}
