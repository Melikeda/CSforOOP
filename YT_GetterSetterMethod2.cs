using System;

class Student
{
    private string name; // private değişken

    // Getter: isim okumak için
    public string GetName()
    {
        return name;
    }

    // Setter: isim atamak için
    public void SetName(string value)
    {
        name = value;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.SetName("Melike");           // setter ile isim atandı
        Console.WriteLine(s.GetName()); // getter ile isim okundu
    }
}
