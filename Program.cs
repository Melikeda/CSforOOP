using System;

public class Time1
{
    public int Hour { get; set; }
    public int Minute { get; set; }
    public int Second { get; set; }

    public void SetTime(int hour, int minute, int second)
    {
        if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || (second < 0 || second > 59))
        {
            throw new ArgumentOutOfRangeException();  // Hata meydana geldiğinde programı durdurur ve bu hatayı bir üst katmana bildirir.

        }

        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public string ToUniversalString() => $" {Hour:D2}:{Minute:D2}: {Second:D2}";    // ToUniversalString metodu, Time sınıfında yer alan ve saat, dakika, saniye gibi zaman bilgilerini evrensel zaman formatında (24 saatlik format) döndüren bir metodur.

    // => lambda ifadesi:
    //Bu, metodu aşağıdaki gibi uzun bir şekilde yazmaya alternatif olarak kullanılmıştır:
    /* 
    public string ToUniversalString()
    {
        return $" {Hour:D2}:{Minute:D2}:{Second:D2}";
    }
    */

    public override string ToString() => $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +             // ToString metodu, C# dilinde tüm nesneler için varsayılan olarak bulunan bir metoddur. Bu metodun amacı, bir nesnenin düz metin (string) biçiminde bir temsilini döndürmektir. 
                                         $"{Minute:D2}: {Second:D2} {(Hour < 12 ? "AM" : "PM")}";
}
// override, bir sınıfın bir metodu veya özelliği temel sınıftan (base class) devraldığı (inheritance) bir üyeyi yeniden tanımlamak (override etmek) için kullanılır.
class Time1Test
{
    static void Main()
    {
        var time = new Time1();

        Console.WriteLine($"The initial universal time is: {time.ToUniversalString()}");
        Console.WriteLine($"The initial standart time is: {time.ToString()}");
        Console.WriteLine();

        time.SetTime(13, 27, 6);

        Console.WriteLine($"Universal time after SetTime is: {time.ToUniversalString()}");
        Console.WriteLine($"Standart time after SetTime is: {time.ToString()}");
        Console.WriteLine();

        try   // try bloğundaki kod çalıştırılır. Eğer bu kod sırasında bir istisna (exception) oluşursa, try bloğundaki kod çalışmayı durdurur ve kontrol catch bloğuna geçer.
        {
            time.SetTime(99, 99, 99);
        }
        catch(ArgumentOutOfRangeException ex)  // try bloğunda bir hata meydana gelirse, hata türüne uygun bir catch bloğu çalıştırılır. Hata bilgisi, catch bloğundaki parametre (örneğin, ex) ile yakalanır.
        {
            Console.WriteLine(ex.Message + "\n");
        }

        Console.WriteLine("After attempting invalid setting:");
        Console.WriteLine($"Universal time: {time.ToUniversalString()}");
        Console.WriteLine($"Standart time: {time.ToString}");

    }
}


   

 