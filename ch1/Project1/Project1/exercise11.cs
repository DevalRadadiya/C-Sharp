/* 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something 
as "You look older than 20".   */

using System;


class program11
{
    static void Main()
    {
        int age;

        Console.WriteLine("Enter Your Age : ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("You look older than " +age);
    }
}