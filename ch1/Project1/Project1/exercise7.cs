/* 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and 
dividing of two numbers which will be entered by the user. */

using System;

class program7
{
    static void Main()
    {
        int a, b, c, d, e, f, g;
        Console.WriteLine("Input First Number : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Second Number : ");
        b = int.Parse(Console.ReadLine());
        c = a + b;
        d = a - b;
        e = a * b;
        f = a / b;
        g = a % b;
        Console.WriteLine("Addition is " + c);
        Console.WriteLine("Subtraction is " + d);
        Console.WriteLine("Multiplication is " + e);
        Console.WriteLine("Division is " + f);
        Console.WriteLine("Modulo is " + g);
    }
}