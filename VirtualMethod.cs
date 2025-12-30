class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee çalışıyor");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager yönetim görevini yapıyor");
    }
}
