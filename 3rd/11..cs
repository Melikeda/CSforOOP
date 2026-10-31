class Program
{
    static void Main()
    {
        int para = 100; // Başlangıç değeri mutlaka atanmalı (ref için şarttır)
        
        ParaEkle(ref para);
        
        Console.WriteLine(para); // Ekran çıktısı: 150 (Orijinal değer değişti!)
    }

    static void ParaEkle(ref int miktar)
    {
        miktar += 50; // Gelen paraya 50 TL ekler
    }
}
