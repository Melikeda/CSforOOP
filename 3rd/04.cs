using System;

class Car
{
    // 1. Otomatik Property (C#'ın en çok kullanılan pratik yöntemi)
    // Arka planda private bir değişkeni C# kendisi oluşturur.
    public string Brand { get; set; }

    // 2. Kontrollü Property (Özel mantık içeren durumlar için)
    private int speed;

    public int Speed
    {
        get 
        { 
            return speed; 
        }
        set 
        {
            // Hız negatif girilirse 0 yapar
            if (value < 0)
            {
                speed = 0;
            }
            else
            {
                speed = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        // Property'lere değer atama (set çalışır)
        myCar.Brand = "BMW";
        myCar.Speed = -50; // Negatif girildiği için set bloğu bunu 0 yapacak

        // Property değerlerini okuma (get çalışır)
        Console.WriteLine($"Araba Markası: {myCar.Brand}");
        Console.WriteLine($"Araba Hızı: {myCar.Speed}"); // Ekrana 0 yazar
    }
}
