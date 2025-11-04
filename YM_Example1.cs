
using System;

class Student // Student adında bir sınıf tanımlıyoruz
{
    public string Name { get; set; } // Name public bir property. get; set; ile hem okunabilir hem de değiştirilebilir.
    private int average;  // average private bir field

    public Student(string studentName, int studentAverage)  // Bu constructor: sınıftan nesne oluştururken çalışır.
    {
        Name = studentName;
        Average = studentAverage;
    }

    public int Average  // Average property’si:
    {
        get { return average; }  // get kısmı: private average değerini döndürür.
        set
        {
            if (value > 0 && value <= 100) // set kısmı: atanan değeri kontrol eder; 0–100 arasıysa average alanına atar.
                average = value;
        }
    }

    public string LetterGrade  // LetterGrade property’si:
    {
        get      // Sadece get var, yani okunabilir, değiştirilemez.
        {
            string letterGrade = string.Empty;

            if (average >= 90)
                letterGrade = "A";
            else if (average >= 80)
                letterGrade = "B";
            else if (average >= 70)
                letterGrade = "C";
            else if (average >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            return letterGrade;
        }
    }
}

class StudentTest
{
    static void Main()
    {
        Student student1 = new Student("Melike", 95);   // İki Student nesnesi oluşturuluyor:
        Student student2 = new Student("Hayri", 67);

        Console.Write($"{student1.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");

        Console.Write($"{student2.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
    }
}

                                          
