using System;

// Base class
class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }

    // Object sınıfından gelen ToString metodunu override ediyoruz
    public override string ToString()
    {
        return $"Employee Name: {Name}, ID: {ID}";
    }
}

// Derived class
class CommissionEmployee : Employee
{
    public double CommissionRate { get; set; }

    // ToString metodunu override ederek daha detaylı bilgi veriyoruz
    public override string ToString()
    {
        return base.ToString() + $", Commission Rate: {CommissionRate}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee { Name = "Melike", ID = 101 };
        Console.WriteLine(emp.ToString());  
        // Çıktı: Employee Name: Melike, ID: 101

        CommissionEmployee comEmp = new CommissionEmployee
        {
            Name = "Ahmet",
            ID = 102,
            CommissionRate = 0.2
        };
        Console.WriteLine(comEmp.ToString());  
        // Çıktı: Employee Name: Ahmet, ID: 102, Commission Rate: 0.2
    }
}
