using System;

class CalculatePower
{
    static void Main()
    {
        Console.WriteLine($"Power 10 = {Power(10)} ");  // Üs (exponentValue) değeri belirtilmediği için, varsayılan değer olan 2 kullanılır.
        Console.WriteLine($"Power (2, 10) = {Power(2,10)} ");
    }

    static int Power(int baseValue, int exponentValue = 2)
    {
        int result = 1;  // Sonuç başlangıçta 1 olarak ayarlanır (çarpma işlemi için nötr eleman).

        for (int i= 1; i <= exponentValue; ++i)  // Döngü, exponentValue kadar tekrar eder.
        {                                        // Her tekrarda, *result = baseValue; ifadesiyle result, baseValue ile çarpılır.
            result *= baseValue;
        }

        return result;
    }
}

 