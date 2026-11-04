using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal MonthlySalary { get; set; }
}

class Program
{
    static void Main()
    {
        // Çalışan listemizi oluşturuyoruz
        List<Employee> employees = new List<Employee>
        {
            new Employee { FirstName = "Ahmet", LastName = "Yılmaz", MonthlySalary = 40000 },
            new Employee { FirstName = "Ayşe", LastName = "Demir", MonthlySalary = 55000 },
            new Employee { FirstName = "Mehmet", LastName = "Kaya", MonthlySalary = 60000 }
        };

        // LINQ sorgusu içinde 'select' kullanarak ANONİM TÜR (isimsiz nesne) oluşturuyoruz.
        // Önceden bir class tanımlamadık, derleyici bu yapıyı anında bizim için üretiyor.
        // Ayrıca projeksiyon (dönüştürme) yaparak maaşa %10 zam ekliyoruz.
        var query = from e in employees
                    select new  // Anonymous type
                    { 
                        FullName = e.FirstName + " " + e.LastName, 
                        NewSalary = e.MonthlySalary * 1.1m 
                    };

        // Sonuçları ekrana yazdırıyoruz
        Console.WriteLine("Zamlı Çalışan Listesi (Anonim Türler):\n");
        foreach (var item in query)
        {
            // 1. Derleyici anonim türler için otomatik bir ToString() metodu üretir[cite: 18]:
            // Console.WriteLine(item.ToString());

            // 2. Veya özelliklere nokta (.) koyarak doğrudan erişebiliriz:
            Console.WriteLine($"Çalışan: {item.FullName} | Yeni Maaş: {item.NewSalary} TL");
        }
    }
}
