/*  9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
Test Data:  */

using System;


class program9
{
    static void Main()
    {
        int a, b, c, d, avg;
        Console.WriteLine("Enter First Number: ");
        a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter Second Number: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Third Number: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Fourth Number: ");
        d = int.Parse(Console.ReadLine());

        avg = a + b + c + d / 4;

        Console.WriteLine("Average is "+avg);
    }
}