using System;

class FireTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = n;
        int stars = 1;

        Console.Write(new string(' ', n));
        Console.Write(new string('*', 1));
        Console.WriteLine();

        for (int i = 1; i <= r - 1; i++)
        {
            Console.Write(new string(' ', n - 1));
            Console.Write(new string('*', stars));
            Console.Write(new string('|', 1));
            Console.Write(new string('*', stars));
            Console.Write(new string(' ', n - 1));
            Console.WriteLine();
            n--;
            stars++;
        }
    }
}
