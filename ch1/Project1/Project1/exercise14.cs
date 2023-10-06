/* 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
Test Data */

using System;


class program14
{
    static void Main()
    {
        int celsius;

        Console.Write("Enter a Celsius : ");
        celsius = int.Parse(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}
