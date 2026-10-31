// 6 yüzlü bir zarı 60.000.000 kez atma simülasyonu
using System;

class RollDie
{
    static void Main()
    {
        var randomNumbers = new Random(); // rastgele sayı üreticisi
        
        // frequency yerine 'sayac' dizisini kullanıyoruz
        var sayac = new int[7]; // zar yüzlerinin çıkış adetlerini tutan dizi

        // zarı 60.000.000 kez at; gelen zar değerini sayac dizisinin indeksi olarak kullan
        for (var roll = 1; roll <= 60000000; ++roll)
        {
            ++sayac[randomNumbers.Next(1, 7)];
        }

        Console.WriteLine($"{"Zar",4}{"Tekrar Sayısı",15}");

        // her bir dizi elemanının değerini (kaç kez geldiğini) ekrana yazdır
        for (var face = 1; face < sayac.Length; ++face)
        {
            Console.WriteLine($"{face,4}{sayac[face],15}");
        }
    }
}
