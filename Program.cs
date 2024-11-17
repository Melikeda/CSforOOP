using System;

namespace Studentcs
{

    class Program
    {
        static void Main()  // Klavyeden girilen 10 notun ortalamasının bulunması
        {
            int total = 0;
            int gradeCounter = 1;
            int average;

            while (gradeCounter <= 10)
            {
                Console.WriteLine("Enter grade");
                int grade = int.Parse(Console.ReadLine());
                total = total + gradeCounter;
                gradeCounter = gradeCounter + 1; 
            }

            average = total / 10;

            Console.WriteLine($"Total all of 10 grades is {total}");
            Console.WriteLine($"Class average is {average}");

        }
    }

}
