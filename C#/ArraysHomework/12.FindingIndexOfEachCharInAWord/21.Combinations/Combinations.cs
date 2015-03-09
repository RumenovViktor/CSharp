//21.Write a program that reads two numbers N and K and 
//generates all the combinations of K distinct elements from the set [1..N]. 

namespace _21.Combinations
{
    using System;

    class Combinations
    {
        static void Main()
        {
            //Getting input
            string str;
            int n, k;//Don't use too big numbers since permutations grow quickly

            Console.Write("N= ");
            str = Console.ReadLine();

            if (int.TryParse(str, out n))
            {
                n = int.Parse(str);
                if (n <= 0)
                {
                    Console.WriteLine("Invalid N: {0}", str);
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Invalid N: {0}", str);
                Environment.Exit(1);
            }

            Console.Write("K= ");
            str = Console.ReadLine();

            if (int.TryParse(str, out k))
            {
                k = int.Parse(str);
                if (k > n || k <= 0)
                {
                    Console.WriteLine("Invalid K: {0}", str);
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Invalid K: {0}", str);
                Environment.Exit(1);
            }

            //Bitwise operation instead of Pow
            int numberOfCombinations = 1<<n;
            
            for (int i = 0; i < numberOfCombinations; i++)
            {
                int elements = 0;
                for (int j = 0; j < n; j++)
                {
                    if (((1 << j) & i) != 0)
                    {
                        elements++;
                    }
                }
                if (elements == k)
                {
                    Console.Write("{");
                    for (int j = 1; j <= n; j++)
                    {
                        if (((1 << j - 1) & i) != 0)
                        {
                            Console.Write(j + ",");
                        }
                    }
                    Console.WriteLine("\b}");
                }
            }
        }
    }
}
