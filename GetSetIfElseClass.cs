using System;

namespace Studentcs
{
    class Student  // öğrencinin adını, ortalamasını ve harf notunu içeren bir sınıf tanımlanır.
    {
        public string Name { set; get; }  // öğrencinin ismini tutar.
        private int average;  // öğrencinin not ortalamsını saklar.

        public Student(string studentName, int studentAverage)  // Student sınıfından bir nesne oluşturulduğunda, öğrencinin adı ve ortalaması ile başlatılmasını sağlar.
        {
            Name = studentName;
            average = studentAverage;
        }

        public int Average  // Öğrenci ortalamasını almak (get) veya ayarlamak (set) için kullanılır.
        {
            get 
            {
                return average;
            }

            set 
            {
                if (value>0)
                {
                    if (value <= 100)  // Koşul: Ortalamalar 0 ile 100 arasında olmalıdır.
                    {
                        average = value;
                    }
                }
            }
        }

        public string LetterGrade
        {
            get  // get: Hesaplanan harf notunu döner.
            {
                string letterGrade = string.Empty;

                if(average >= 90)
                {
                    letterGrade = "A";
                }

                else if(average >= 80)
                {
                    letterGrade = "B";
                }

                else if (average >= 70)
                {
                    letterGrade = "C";
                }

                else if (average >= 60)
                {
                    letterGrade = "B";
                }

                else
                {
                    letterGrade = "F";
                }

                return letterGrade;
            }
        }

    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Melike", 95);  // Student sınıfından iki nesne oluşturulur.
            Student student2 = new Student("Ali", 80);

            Console.Write($"{student1.Name}'s latter grade equilavent of ");
            Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
            Console.Write($"{student2.Name}'s latter garde equilavent of ");
            Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");

        }
    }



}
