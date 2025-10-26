using System;

class Ogrenci
{
    // Özellikler (Fields)
    public string ad;
    public int yas;

    // Metot (Davranış)
    public void BilgiYazdir()
    {
        Console.WriteLine("Öğrenci Adı: " + ad);
        Console.WriteLine("Yaşı: " + yas);
    }
}

class Program
{
    static void Main()
    {
        // Ogrenci sınıfından bir nesne oluşturuyoruz
        Ogrenci ogr1 = new Ogrenci();

        // Özellik değerleri atıyoruz
        ogr1.ad = "Melike";
        ogr1.yas = 20;

        // Metodu çağırıyoruz
        ogr1.BilgiYazdir();
    }
}
