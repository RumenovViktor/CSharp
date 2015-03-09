using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long lines = long.Parse(Console.ReadLine());
        long sum1 = 0;
        long sum = 0;

        for (int j = 3; j <= lines; j++)
        {
            sum1 += j;
        }

        long[] numbers = new long[sum1 + 4];

        numbers[0] = a;
        numbers[1] = b;
        numbers[2] = c;

        sum = a + b + c;

        for (int i = 3; i < numbers.Length; i++)
        {
            numbers[i] = sum;
            a = b;
            b = c;
            c = sum;
            sum = a + b + c;
        }

        long index = 0;

        for (int i = 1; i <= lines; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("{0} ", numbers[index]);

                if (index < numbers.Length - 1)
                {
                    index++;
                }
            }
            Console.WriteLine();
        }
    }
}