using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            File.ReadAllText("dosya.txt"); // Dosya yok
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Dosya bulunamadı!");
        }

        Console.ReadLine();
    }
}
