using System;

interface IArac
{
    void Calistir();   // Gövde yok
    void Durdur();
}

class Araba : IArac
{
    public void Calistir()
    {
        Console.WriteLine("Araba çalıştı");
    }

    public void Durdur()
    {
        Console.WriteLine("Araba durdu");
    }
}

class Program
{
    static void Main()
    {
        IArac arac = new Araba();
        arac.Calistir();
        arac.Durdur();
    }
}
