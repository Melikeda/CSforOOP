using System;

class Program
{
    static int Topla(params int[] sayilar)  //// params ile istenilen sayıda sayı alıyoruz
    {
        int toplam = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }
        return toplam;
    }

    static void Main()
    {
        Console.WriteLine(Topla(1, 2, 3)); // Çıktı: 6
    }
}
