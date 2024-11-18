using System;

class RandomNunber
{
    static void Main()
    {
        Random myRandom = new Random();

        for(int counter = 1; counter <= 20; ++counter)
        {
            int face = myRandom.Next(1,7);  // 7: Üst sınır (hariç tutulur, bu yüzden 6'ya kadar değer üretir).
                                            // Rastgele bir sayı üretmek için random sınıfının next methodunu kullanırız
            Console.Write(" " + face);
        }

        Console.WriteLine();
    }
}
