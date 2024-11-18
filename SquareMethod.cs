using System;

class Program
{
    static void Main()
    {
        int x = 10;
        Console.WriteLine($" x squared: {Square(x)}");
    }

    static int Square(int y)  // static ifadesi, bu metodun sınıfın bir örneği (instance) oluşturulmadan, doğrudan sınıf ismi üzerinden erişilebileceği anlamına gelir.
                              // Yani, Square metodunu çağırırken bir nesne oluşturmanıza gerek yoktur.
    {
        return  y * y;
    }
}
