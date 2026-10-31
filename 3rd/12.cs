class Program
{
    static void Main()
    {
        int odul; // Başlangıçta değer atamamıza gerek yok (out için boş olabilir)
        
        KutuyuAc(out odul);
        
        Console.WriteLine(odul); // Ekran çıktısı: 500 (Metot içinden doldurulup dışarı aktarıldı)
    }

    static void KutuyuAc(out int sonuc)
    {
        sonuc = 500; // Metot bitmeden önce bu değişkene mutlaka bir değer ATANMALIDIR.
    }
}
