using System;

class  ClassAverage
{
    static void Main()
    {
        int total = 0;
        int gradeCounter = 0;

        Console.WriteLine("Enter grade or -1 to quit: ");
        int grade = int.Parse(Console.ReadLine());

        while (grade != -1)
        {
            total = total + grade;
            gradeCounter = gradeCounter + 1;

            Console.WriteLine("Enter grade or -1 to quit: ");
            grade = int.Parse(Console.ReadLine());
        }

        if(gradeCounter != 0)
        {
            double average = (double)total / gradeCounter;

            Console.WriteLine($"Total of the {gradeCounter} gardes entered is {total}");
            Console.WriteLine($"Class average is {average:F}");  // F: sayıyı ondalık formatında (fixed-point format) yazdırmak için kullanılır.
        }
        else
        {
            Console.WriteLine("No grade were entered");
        }
    }
}
