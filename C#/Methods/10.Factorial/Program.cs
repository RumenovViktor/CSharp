using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Factorial
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());

        Console.WriteLine(CalculateFactorial(n));
    }

    static BigInteger CalculateFactorial (BigInteger n)
    {
        if (n == 1)
        {
            return n;
        }

        return n * CalculateFactorial(n - 1);
    }
}