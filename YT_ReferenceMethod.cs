using System;

class Program
{
    // Reference parametre örneği
    static void Degistir(ref int x)
    {
        x = 10; // Metod içindeki değişiklik, çağıran değişkene yansır
    }

    static void Main()
    {
        int sayi = 5;
        Degistir(ref sayi); // ref ile sayi değişkeninin referansı gönderildi
        Console.WriteLine(sayi); // Çıktı: 10
    }
}
