using System;

class InitArray
{
    static void Main()
    {
        int[] array = new int[5];  // 5 elemanlı bir tamsayı dizisi tanımlanır. Tüm elemanlar varsayılan 0 olarak başlatılır.

        Console.WriteLine($"{"Index"}{"Value", 8}"); // value başlığını 8 boşluk sağa hizalayarak yazar.

        for (int counter = 0; counter < array.Length; ++counter)  // Döngü, dizinin uzunluğuna (Length) kadar çalışır.
        {
            Console.WriteLine($"{counter,5}{array[counter],8}");   // Dizinin indeksi (counter) ekrana 5 karakter genişliğinde, sağa hizalanmış şekilde yazdırılır.
        }                                                          // Dizinin değeri (array[counter]) 8 karakter genişliğinde, sağa hizalanmış şekilde yazdırılır.
    }
}
