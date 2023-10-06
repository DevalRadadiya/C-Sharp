/* 8. Write a C# Sharp program that takes a number as input and print its multiplication table. 
Test Data: */

using System;


class program8
{
    static void Main()
    {
        int x, result;
        Console.WriteLine("Enter Number : ");
        x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            result = x * i;
            Console.WriteLine("{0} * {1} = {2}",x,i,result);
        }
    }
}
       
        
        

