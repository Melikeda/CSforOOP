using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader file = null;
        try
        {
            file = new StreamReader("dosya.txt");
            Console.WriteLine(file.ReadLine());
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Dosya bulunamadı!");
        }
        finally
        {
            if (file != null)
                file.Close(); // Dosya her durumda kapatılır
            Console.WriteLine("Finally bloğu çalıştı.");
        }
    }
}
