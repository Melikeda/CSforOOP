//  variable declaration
using System;

class Class{
    static void Main() {
        int num1;  // declare first number
        int num2;
        int sum;
    
        Console.Write("Enter the first integer: ");  // prompt user
        // read first number from user
        num1 = int.Parse(Console.ReadLine());    // int.Parse yöntemi, bu karakter dizisini int türünde bir veriye dönüştürür
        Console.Write("Enter the second integer: ");  // prompt user
        // read second number from user
        num2 = int.Parse(Console.ReadLine());
        
        sum = num1 + num2;
        Console.WriteLine($"Sum is {sum}");
    } 
} 