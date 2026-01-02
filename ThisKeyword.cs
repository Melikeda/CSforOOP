using System;

class Ogrenci
{
    string ad;

    public Ogrenci(string ad)
    {
        this.ad = ad;
    }

    public void Yazdir(string ad)
    {
        Console.WriteLine(ad);
        Console.WriteLine(this.ad);
    }
}

class Program
{
    static void Main()
    {
        Ogrenci o1 = new Ogrenci("Ali");
        o1.Yazdir("Ayşe");
    }
}
