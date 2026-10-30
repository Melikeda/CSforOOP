using System;

namespace ControlStatementsApp
{
    // ----------------------------------------------------
    // Student.cs
    // Öğrenci adını ve ortalamasını tutan Sınıf (Class)
    // ----------------------------------------------------
    class Student
    {
        public string Name { get; set; } // Otomatik property
        private int average; // Nesne değişkeni (instance variable)

        // Yapıcı Metot (Constructor)
        public Student(string studentName, int studentAverage)
        {
            Name = studentName;
            Average = studentAverage; // Average property'sinin set blokunu tetikler
        }

        // Average Property'si (get ve set erişimcileri içerir)
        public int Average
        {
            get
            {
                return average;
            }
            set
            {
                // Değerin 0 ile 100 arasında olduğunu doğrular (Validation)
                if (value > 0)
                {
                    if (value <= 100)
                    {
                        average = value;
                    }
                }
            }
        }

        // Salt Okunur (Read-only) LetterGrade Property'si
        public string LetterGrade
        {
            get
            {
                string letterGrade = string.Empty; // Boş dize ("") ile başlatma

                // İç içe (nested) else-if merdiveni ile harf notu tespiti
                if (average >= 90)
                {
                    letterGrade = "A";
                }
                else if (average >= 80)
                {
                    letterGrade = "B";
                }
                else if (average >= 70)
                {
                    letterGrade = "C";
                }
                else if (average >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                return letterGrade;
            }
        }
    }

    // ----------------------------------------------------
    // StudentTest.cs
    // Student nesnelerini oluşturan ve test eden Çalıştırılabilir Sınıf
    // ----------------------------------------------------
    class StudentTest
    {
        static void Main(string[] args)
        {
            // Öğrenci nesnelerinin oluşturulması
            Student student1 = new Student("Jane Green", 93);
            Student student2 = new Student("John Blue", 72);

            // Sonuçların ekrana yazdırılması
            Console.Write($"{student1.Name}'s letter grade equivalent of ");
            Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");

            Console.Write($"{student2.Name}'s letter grade equivalent of ");
            Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
        }
    }
}
