using System;

class Program
{
    static void Main()
    {
        int bardak1 = 5;  // 1. bardaktaki portakal suyu (değer: 5)
        int bardak2 = 10; // 2. bardaktaki vişne suyu (değer: 10)

        Console.WriteLine($"Değişmeden önce -> Bardak 1: {bardak1}, Bardak 2: {bardak2}");

        // --- SWAP (YER DEĞİŞTİRME) İŞLEMİ ---
        
        // 1. Adım: Boş bir bardak (temp) oluşturup 1. bardağın değerini içine yedekliyoruz.
        int temp = bardak1; // temp = 5 (Bardak 1 boşaldı ama değeri temp'te güvende)

        // 2. Adım: 2. bardağın değerini boşalan 1. bardağa aktarıyoruz.
        bardak1 = bardak2; // bardak1 = 10 oldu.

        // 3. Adım: Geçici bardaktaki (temp) yedek değeri 2. bardağa veriyoruz.
        bardak2 = temp; // bardak2 = 5 oldu.

        // ----------------------------------

        Console.WriteLine($"Deştikten sonra -> Bardak 1: {bardak1}, Bardak 2: {bardak2}");
    }
}
