/* 26. Write a C# program to reverse the words of a sentence. */

using System;
using System.Linq;

class program26
{
    static void Main()
    {
        string txt = "My Name Is Deval";

        Console.WriteLine(string.Join(" ",txt.Split(' ').Reverse()));
    }
}