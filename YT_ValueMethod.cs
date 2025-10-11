using System;

class Program
{
    // Value parametre örneği
    static void Degistir(int x)
    {
        x = 10; // sadece kopyayı değiştirir
    }

    static void Main()
    {
        int sayi = 5;
        Degistir(sayi); // sayi'nin kopyası metoda gönderilir
        Console.WriteLine(sayi); // Çıktı: 5 (değişmedi)
    }
}
