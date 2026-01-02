class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Kedi miyavlıyor");
    }
}

class Program
{
    static void Main()
    {
        Hayvan h = new Kedi();
        h.SesCikar();
    }
}
