using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int length = n;
        int spaceBetweent = n - 1;

        Console.Write(new string('.', length));
        Console.Write(new string('*', length));

        length--;

        for (int i = 0; i < n * 2 - (n + 1) ; i++)
        {
            Console.WriteLine();
            Console.Write(new string('.', length));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', spaceBetweent));
            Console.Write(new string('*', 1));
            length--;
            spaceBetweent++;
        }
        Console.WriteLine();
        Console.Write(new string('*', n * 2));

    }
}

