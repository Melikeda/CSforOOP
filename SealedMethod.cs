using System;

class Base
{
    public virtual void Yaz()
    {
        Console.WriteLine("Base sınıfı");
    }
}

class Derived : Base
{
    public sealed override void Yaz()
    {
        Console.WriteLine("Derived (sealed) sınıfı");
    }
}

// Daha alt sınıf
class Child : Derived
{
    // ❌ HATA VERİR (sealed olduğu için)
    /*
    public override void Yaz()
    {
        Console.WriteLine("Child sınıfı");
    }
    */
}

class Program
{
    static void Main()
    {
        Base b = new Child();
        b.Yaz();
    }
}
