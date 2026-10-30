using System;

class Student
{
    // Gizli değişkenler (Encapsulation)
    private string studentName;
    private int grade;

    // Öğrenci adını belirleme ve okuma
    public void SetStudentName(string name)
    {
        studentName = name;
    }

    public string GetStudentName()
    {
        return studentName;
    }

    // Not belirleme ve okuma (Kontrollü veri atama)
    public void SetGrade(int newGrade)
    {
        // Set metodları içine kontrol koyulabilir!
        if (newGrade >= 0 && newGrade <= 100)
        {
            grade = newGrade;
        }
        else
        {
            Console.WriteLine("Hata: Not 0 ile 100 arasında olmalıdır!");
        }
    }

    public int GetGrade()
    {
        return grade;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.SetStudentName("Melike");
        student1.SetGrade(95);

        Console.WriteLine($"Öğrenci Adı: {student1.GetStudentName()}");
        Console.WriteLine($"Öğrenci Notu: {student1.GetGrade()}");
    }
}
