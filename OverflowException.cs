using System;

class Program
{
    static void Main()
    {
        try
        {
            int sayi = int.Parse("999999999999"); // int sınırını aşıyor
            Console.WriteLine(sayi);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Taşma (Overflow) hatası!");
        }

        Console.ReadLine();
    }
}
