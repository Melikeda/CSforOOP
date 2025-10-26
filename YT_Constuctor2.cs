using System;

class Araba
{
    public string Marka;
    public string Renk;
    public int Hiz;

    // Parametresiz constructor
    public Araba()
    {
        Marka = "Bilinmeyen";
        Renk = "Beyaz";
        Hiz = 0;
    }

    // Parametreli constructor
    public Araba(string marka, string renk, int hiz)
    {
        Marka = marka;
        Renk = renk;
        Hiz = hiz;
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"Marka: {Marka}, Renk: {Renk}, Hız: {Hiz}");
    }
}

class Program
{
    static void Main()
    {
        // Parametresiz constructor ile nesne
        Araba araba1 = new Araba();
        araba1.BilgiYazdir();

        // Parametreli constructor ile nesne
        Araba araba2 = new Araba("Toyota", "Kırmızı", 180);
        araba2.BilgiYazdir();
    }
}
