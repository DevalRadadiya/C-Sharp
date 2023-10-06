/* 4. Write a C# Sharp program to print the result of the specified operations.  */

using System;


class program4
{
    static void Main()
    {
        int a = -1, b = 4, c = 6,d;
        d = a + b * c;
        Console.WriteLine(d);

        int e = 35, f = 5, g = 7, h;
        h = (e + f) % g;
        Console.WriteLine(h);

        int i = 14, j = -4, k = 6, l = 11, m;
        m = i + j * k / l;
        Console.WriteLine(m);

        int n = 2, o = 15, p = 6, q = 1, r = 7, s = 2, t;
        t = n + o / p * q - r % s;
        Console.WriteLine(t);
    }
}