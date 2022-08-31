/* 17. Write a C# program to check two given integers and return true if one is negative and one is 
positive.  */

using System;


class program17
{
    static void Main()
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Check if one is negative and one is positive:");
        if ((x < 0 && y > 0) || (x > 0 && y < 0)) ; 
        {
            Console.WriteLine("True");
        }
        
    }
}
