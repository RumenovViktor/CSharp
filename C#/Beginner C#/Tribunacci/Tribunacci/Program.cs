using System;
using System.Numerics;

class Program
{
    static void Main()
    {

        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        short border = short.Parse(Console.ReadLine());
        BigInteger sum = 0;

        sum = a + b + c;

        switch (border)
        {
            case 1:
                sum = a;
                break;
            case 2:
                sum = b;
                break;
            case 3:
                sum = c;
                break;
        }

        for (int i = 4; i < border; i++)
        {            
            a = b;
            b = c;
            c = sum;
            sum = a + b + c;
        }

        Console.WriteLine(sum);
    }
}

