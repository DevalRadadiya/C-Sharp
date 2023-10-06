/* 6. Write a C# Sharp program to print the output of multiplication of three numbers which will be 
entered by the user.  */

using System;


class program6
{
    static void Main()
    {
        int a, b, c, d;
        Console.WriteLine("Input the first number to multiply : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the second number to multiply : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the third number to multiply : ");
        c = int.Parse(Console.ReadLine());
        d = a * b * c;
        Console.WriteLine("Multiplication is : " + d);
    }
}