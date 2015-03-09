//15.Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

namespace _15.FindAllPrimes
{
    using System;

    class FindAllPrimes
    {
        static void Main()
        {
            //Hard coded because the task says so
            const int n = 100000000;
            bool[] multipals = new bool[n];//False is the defaut value so my logic is inverted

            //I'm using the Pseudocode from wikipedia
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (!multipals[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        multipals[j] = true;
                    }
                }
            }

            //Printing on console
            for (int i = 2; i < n; i++)
            {
                if (!multipals[i])
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
}
