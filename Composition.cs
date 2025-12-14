# Date Sınıfı:
class Date
{
    public int Day { get; }
    public int Month { get; }
    public int Year { get; }

    public Date(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }
}

# Employee Sınıfı (Composition Kullanımı):

class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    public Date BirthDate { get; }
    public Date HireDate { get; }

    public Employee(string firstName, string lastName, Date birthDate, Date hireDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        HireDate = hireDate;
    }
}
