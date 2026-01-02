using System;
using System.Collections.Generic;
using System.Linq;

class Ogrenci
{
    public string Ad { get; set; }
    public int Not { get; set; }
}

class Program
{
    static void Main()
    {
        var ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci { Ad = "Ali", Not = 60 },
            new Ogrenci { Ad = "Aylin", Not = 80 },
            new Ogrenci { Ad = "Mehmet", Not = 45 }
        };

        var sonuc = from o in ogrenciler
                    where o.Not > 60
                    select o;

        foreach (var item in sonuc)
        {
            Console.WriteLine(item.Ad);
        }
    }
}

