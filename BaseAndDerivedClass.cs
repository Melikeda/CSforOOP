using System;

class Hayvan
{
    public void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor");
    }
}

class Kedi : Hayvan
{
    public void Miyavla()
    {
        Console.WriteLine("Kedi miyavlıyor");
    }
}

class Program
{
    static void Main()
    {
        Kedi k = new Kedi();
        k.SesCikar();
        k.Miyavla();
    }
}
