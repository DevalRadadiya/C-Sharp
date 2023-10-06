/* 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of 
(x+y).z and x.y + y.z.  */

using System;


class program10
{
    static void Main()
    {
        int x, y, z;

        Console.WriteLine("Enter First Number: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number: ");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Third Number: ");
        z = int.Parse(Console.ReadLine());

        int a = (x + y) * z;
        Console.WriteLine("( x + y ) * z : " +a);

        int b = (x * y) + (y * z);
        Console.WriteLine("(x * y) + (y * z) : " +b);
    }
}