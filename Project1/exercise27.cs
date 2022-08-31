/* 27. Write a C# program to find the size of a specified file in bytes. */

using System;
using System.Collections.Generic;
using System.IO;


public class program27
{
    static void Main()
    {
        FileInfo f = new FileInfo("D:\\Sem5\\C#\\basic steps to create account.txt");
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }
}