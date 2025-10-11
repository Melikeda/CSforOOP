using System;

class Program
{
    // out parametre örneği
    static void Hesapla(out int toplam, out int fark)
    {
        toplam = 10 + 5;
        fark = 10 - 5;
    }

    static void Main()
    {
        int t, f; // Önceden değer atamaya gerek yok
        Hesapla(out t, out f); // out parametreleri metoda gönder
        Console.WriteLine($"Toplam: {t}, Fark: {f}"); // Çıktı: Toplam: 15, Fark: 5
    }
}
