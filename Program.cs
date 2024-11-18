using System;

class ReferanceAndOutputParameters
{
    static void Main()
    {
        int y = 5;
        int z;

        Console.WriteLine($"Original value of y: {y}");
        Console.WriteLine($"Original value of z: uninitialized");
        Console.WriteLine();

        SquareRef(ref y);
        SquareOut(out z);

        Console.WriteLine($" Value of y after SquareRef: {y}");
        Console.WriteLine($" Value of z after SquareOut: {z}");
        Console.WriteLine();

        Square(y);    // Square(y) ve Square(z) metotları, sadece parametrelerin kopyalarını işler, dolayısıyla orijinal y ve z değerleri değişmez.
        Square(z);

        Console.WriteLine($" Value of y after Square: {y}");
        Console.WriteLine($" Value of z after Square: {z}");

    }

    static void SquareRef( ref int x)  // ref, var olan bir değeri günceller.
    {
        x = x * x;
    }

    static void SquareOut(out int x)  // out, sıfırdan yeni bir değer döndürmek için kullanılır.
    {
        x = 6;
        x = x * x;
    }

    static void Square(int x)
    {
        x = x * x;
    }
}

 