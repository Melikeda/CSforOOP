using System;

class Program
{
    static void Main()
    {
        Yazdir("Merhaba");          // string parametreli metot
        Yazdir(123);                // int parametreli metot
        Yazdir(3.14);               // double parametreli metot
        Yazdir("Melike", 20);       // 2 parametreli metot
    }

    static void Yazdir(string mesaj)
    {
        Console.WriteLine("Mesaj: " + mesaj);
    }

    static void Yazdir(int sayi)
    {
        Console.WriteLine("Sayı: " + sayi);
    }

    static void Yazdir(double sayi)
    {
        Console.WriteLine("Ondalıklı sayı: " + sayi);
    }

    static void Yazdir(string isim, int yas)
    {
        Console.WriteLine($"İsim: {isim}, Yaş: {yas}");
    }
}
