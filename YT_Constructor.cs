using System;

class Ogrenci
{
    public string Ad;
    public int Yas;

    // Constructor
    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
        Console.WriteLine("Ogrenci nesnesi oluşturuldu!");
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Yaş: {Yas}");
    }
}

class Program
{
    static void Main()
    {
        // Nesne oluşturulunca constructor çalışır
        Ogrenci ogr1 = new Ogrenci("Melike", 20);

        // Nesne metodu çağrılır
        ogr1.BilgiYazdir();
    }
}
