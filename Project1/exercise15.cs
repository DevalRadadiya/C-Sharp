/* 15. Write a C# program remove specified a character from a non-empty string using index of a 
character.  */

using System;
using System.Collections.Generic;

public class program15
{
    static void Main(string[] args)
    {
        Console.WriteLine(remove_char("Atmiya University", 1));
        Console.WriteLine(remove_char("Atmiya University", 9));
        Console.WriteLine(remove_char("Atmiya University", 6));
    }
    public static string remove_char(string str, int n)
    {
        return str.Remove(n, 1);
    }
}
