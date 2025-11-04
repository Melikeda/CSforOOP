/* 
if (koşul1)
{
    // koşul1 doğruysa yapılacak işlem
    if (koşul2)
    {
        // koşul2 doğruysa yapılacak işlem
    }
    else
    {
        // koşul2 yanlışsa yapılacak işlem
    }
}
else
{
    // koşul1 yanlışsa yapılacak işlem
}

*/

int grade = 85;

if (grade >= 60)
{
    if (grade >= 90)
    {
        Console.WriteLine("A");
    }
    else if (grade >= 80)
    {
        Console.WriteLine("B");
    }
    else
    {
        Console.WriteLine("C");
    }
}
else
{
    Console.WriteLine("Kaldı");
}
