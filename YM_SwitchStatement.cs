/*
switch (expression)
{
    case value1:
        // value1 olduğunda çalışacak kodlar
        break;

    case value2:
        // value2 olduğunda çalışacak kodlar
        break;

    default:
        // Hiçbir değer eşleşmezse çalışacak kodlar
        break;
}
*/

int grade = 85;

switch (grade / 10)
{
    case 10:
    case 9:
        Console.WriteLine("A");
        break;
    case 8:
        Console.WriteLine("B");
        break;
    case 7:
        Console.WriteLine("C");
        break;
    case 6:
        Console.WriteLine("D");
        break;
    default:
        Console.WriteLine("F");
        break;
}
