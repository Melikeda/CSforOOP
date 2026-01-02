using System;

class Test
{
    public const int A = 10;
    public readonly int B;
    public static readonly int C;

    public Test(int b)
    {
        B = b;
    }

    static Test()
    {
        C = 30;
    }

    public void Yazdir()
    {
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
    }
}

class Program
{
    static void Main()
    {
        Test t1 = new Test(20);
        t1.Yazdir();

        Test t2 = new Test(40);
        t2.Yazdir();
    }
}
