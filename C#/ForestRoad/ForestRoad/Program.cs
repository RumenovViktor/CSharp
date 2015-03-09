using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n - 1;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', dots));
            Console.WriteLine();
            dots--;
        }

        for (int j = n - 1; j >= 0; j--)
        {
            Console.Write(new string('.', j));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', dots));
            Console.WriteLine();
            dots++;
        }
    }
}
