abstract class Sekil
{
    public abstract void CizAbstract();

    public virtual void CizVirtual()
    {
        Console.WriteLine("Sekil çizildi");
    }
}

class Daire : Sekil
{
    public override void CizAbstract()
    {
        Console.WriteLine("Daire çizildi");
    }

    // Virtual override edilmezse base çalışır
}
