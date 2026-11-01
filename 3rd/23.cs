using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. List<T> Oluşturma: Metin türünde dinamik bir liste tanımlıyoruz
        List<string> meyveler = new List<string>();

        // 2. Add Metodu: Listenin en SONUNA eleman ekler
        meyveler.Add("Elma");
        meyveler.Add("Karpuz");
        Console.WriteLine("Add Sonrası: " + string.Join(", ", meyveler));

        // 3. Insert Metodu: Belirtilen indekse (0. sıra yani en başa) eleman ekler, diğerlerini kaydırır
        meyveler.Insert(0, "Muz");
        Console.WriteLine("Insert(0, 'Muz') Sonrası: " + string.Join(", ", meyveler));

        // 4. Remove Metodu: Değeri arar ve bulduğu İLK eşleşmeyi listeden siler
        meyveler.Remove("Elma");
        Console.WriteLine("Remove('Elma') Sonrası: " + string.Join(", ", meyveler));

        // 5. RemoveAt Metodu: Belirtilen INDEKS NUMARASINDAKİ elemanı siler (Örn: 0. indeksteki "Muz")
        meyveler.RemoveAt(0);
        Console.WriteLine("RemoveAt(0) Sonrası: " + string.Join(", ", meyveler));
    }
}
