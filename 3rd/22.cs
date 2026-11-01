class Program
{
    static void Main()
    {
        int sayi = 10;
        Degistir(sayi);
        Console.WriteLine(sayi); // Ekran çıktısı HÂLÂ 10 olur!
    }

    static void Degistir(int x)
    {
        x = 99; // Sadece gelen kopyayı 99 yapar, orijinaline dokunamaz
    }
}

//karşılaştır!

class Program
{
    static void Main()
    {
        int sayi = 10;
        Degistir(ref sayi);
        Console.WriteLine(sayi); // Ekran çıktısı ARTIK 99 olur!
    }

    static void Degistir(ref int x)
    {
        x = 99; // Doğrudan orijinal kutunun kendisine müdahale eder
    }
}
