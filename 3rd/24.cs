using System;

class Program
{
    static void Main()
    {
        // --- SENARYO 1: Tüm Diziyi Metoda Aktarma ---
        int[] sayilar = { 1, 2, 3 };
        
        Console.WriteLine("Dizinin ilk hali (Metot öncesi): " + sayilar[0]);
        
        DiziyiDegistir(sayilar); // Tüm diziyi gönderiyoruz
        
        Console.WriteLine("Dizinin son hali (Metot sonrası): " + sayilar[0]); 
        // Çıktı 99 olacak çünkü dizi referansla (adres üzerinden) çalışır.


        Console.WriteLine("-----------------------------------");


        // --- SENARYO 2: Tek Bir Dizi Elemanını (Değer Türü) Aktarma ---
        int[] puanlar = { 10, 20, 30 };

        Console.WriteLine("Puanın ilk hali (Metot öncesi): " + puanlar[0]);

        TekElemaniDegistir(puanlar[0]); // Sadece 10 değerini kopyalayıp gönderiyoruz

        Console.WriteLine("Puanın son hali (Metot sonrası): " + puanlar[0]); 
        // Çıktı hala 10 olacak çünkü sadece değerin kopyası gitti, aslı değişmedi.
    }

    // Tüm diziyi alan metot (Referans kopyalanır)
    static void DiziyiDegistir(int[] dizi)
    {
        dizi[0] = 99; // Orijinal dizinin ilk elemanını değiştirir
    }

    // Tek bir tamsayı elemanı alan metot (Değerin kopyası alınır)
    static void TekElemaniDegistir(int sayi)
    {
        sayi = 999; // Sadece yerel kopyayı değiştirir, orijinal diziyi etkilemez
    }
}
