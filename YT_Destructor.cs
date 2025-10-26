using System;

class Ogrenci
{
    public string Ad;

    public Ogrenci(string ad)
    {
        Ad = ad;
        Console.WriteLine(Ad + " nesnesi oluşturuldu.");
    }

    // Destructor
    ~Ogrenci()
    {
        Console.WriteLine(Ad + " nesnesi bellekten siliniyor.");
    }
}

class Program
{
    static void Main()
    {
        Ogrenci ogr1 = new Ogrenci("Melike");
        Ogrenci ogr2 = new Ogrenci("Ali");

        Console.WriteLine("Program sonuna yaklaşılıyor...");
    }
}
