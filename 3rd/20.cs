using System;

class Program
{
    static void Main()
    {
        // 3 elemanlı basit bir dizi oluşturuyoruz
        int[] sayilar = { 10, 20, 30 };

        Console.WriteLine("--- BAŞLANGIÇ DURUMU ---");
        Console.WriteLine($"Orijinal dizi: {sayilar[0]}, {sayilar[1]}, {sayilar[2]}\n");

        // 1. ÖRNEK: Bütün diziyi metoda gönderme
        ModifyArray(sayilar);
        
        Console.WriteLine("--- MODIFY ARRAY METODUNDAN SONRA ---");
        Console.WriteLine($"Orijinal dizi (Değişti!): {sayilar[0]}, {sayilar[1]}, {sayilar[2]}\n");


        // 2. ÖRNEK: Dizinin sadece tek bir elemanını (değer türünü) metoda gönderme
        // (Örneğin 0. eleman olan 20'yi gönderelim)
        ModifyElement(sayilar[0]);

        Console.WriteLine("--- MODIFY ELEMENT METODUNDAN SONRA ---");
        Console.WriteLine($"Orijinal dizinin ilk elemanı (Değişmedi!): {sayilar[0]}");
    }

    // Bütün diziyi alan metot (Referans mantığıyla çalışır, aslı değişir)
    static void ModifyArray(int[] arrayParameter)
    {
        for (int i = 0; i < arrayParameter.Length; i++)
        {
            arrayParameter[i] = arrayParameter[i] * 2; // Her elemanı 2 ile çarpar
        }
    }

    // Tek bir elemanı alan metot (Sadece kopyası gelir, aslı etkilenmez)
    static void ModifyElement(int elementCopy)
    {
        elementCopy = elementCopy * 2; // Sadece kopyası 2 katına çıkar
        Console.WriteLine($"-> Metot içindeki geçici değer: {elementCopy}");
    }
}
