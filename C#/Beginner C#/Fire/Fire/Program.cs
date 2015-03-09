using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int spaceBetween = 0;
        int dots = (n / 2) - 1;

        for (int i = 1; i < (n / 2) + 1; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', spaceBetween));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', dots));
            spaceBetween += 2;
            dots--;
            Console.WriteLine();
        }
        
        spaceBetween = n - 2;

        for (int i = 0; i < n / 4; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', spaceBetween));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', i));
            spaceBetween -= 2;
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', n));

        for (int i = 0; i < (n / 2)  ; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', (n / 2) - i));
            Console.Write(new string('/', (n / 2) - i));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
    }
}
