using System;

abstract class Sekil
{
    public abstract void Ciz();
}

class Kare : Sekil
{
    public override void Ciz()
    {
        Console.WriteLine("Kare çizildi");
    }
}

class Program
{
    static void Main()
    {
        Sekil s = new Kare();
        s.Ciz();
    }
}
