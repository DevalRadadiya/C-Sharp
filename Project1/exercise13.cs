/* 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns 
wide and 5 rows tall using that digit  */

using System;


class program13
{
    static void Main()
    {
        int num;

        Console.Write("Enter a digit: ");
        num = int.Parse(Console.ReadLine());

        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);

        for (int i = 0; i <= 2; i++)
        {
            Console.Write(num);
            Console.Write(" ");
            Console.WriteLine(num);
        }

        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);
    }
}