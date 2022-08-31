/* 5. Write a C# Sharp program to swap two numbers. */

using System;

class program5
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Input First Number : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Second Number : ");
        b = int.Parse(Console.ReadLine());
        a = a * b;
        b = a / b;
        a = a / b;
        Console.Write("After swap a= " + a + " b= " + b);
    }
}