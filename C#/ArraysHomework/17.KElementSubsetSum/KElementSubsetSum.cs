//17.* Write a program that reads three integer numbers N, K and S and an array 
//of N elements from the console. Find in the array a subset of
//K elements that have sum S or indicate about its absence.

namespace _17.KElementSubsetSum
{
    using System;

    class KElementSubsetSum
    {
        static void Main()
        {
            //Getting input
            string str;
            int n;//length
            int s;
            int k;

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

            int[] numbers = new int[n];//The array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]: ", i);
                str = Console.ReadLine();

                if (int.TryParse(str, out numbers[i]))
                {
                    numbers[i] = int.Parse(str);
                }
                else
                {
                    Console.WriteLine("Invalid number: {0}", str);
                    Environment.Exit(1);
                }
            }

            //The sum
            Console.Write("S= ");
            str = Console.ReadLine();

            if (int.TryParse(str, out s))
            {
                s = int.Parse(str);
            }
            else
            {
                Console.WriteLine("Invalid S: {0}", str);
                Environment.Exit(1);
            }

            //The Subset Array lenght
            Console.Write("K= ");
            str = Console.ReadLine();

            if (int.TryParse(str, out k))
            {
                k = int.Parse(str);
                if (k <= 0 || k > n)
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

            bool exsists = false;
            //Bitwise operation instead of Pow
            int numberOfCombinations = 1 << n;

            //Finding a subset
            for (int i = 0; i < numberOfCombinations; i++)
            {
                int receivables = 0;
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (((1 << j) & i) != 0)
                    {
                        sum += numbers[j];
                        receivables++;
                    }
                }
                //printing if a subset exsists
                if (sum == s && receivables == k)
                {
                    Console.Write("yes {");
                    for (int j = 0; j < n; j++)
                    {
                        if (((1 << j) & i) != 0)
                        {
                            Console.Write(numbers[j] + ",");
                        }
                    }
                    Console.WriteLine("\b}");
                    exsists = true;
                    break;
                }
            }

            //Printing
            if (!exsists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
