//16. * We are given an array of integers and a number S. Write a program to 
//find if there exists a subset of the elements of the array that has a sum S. 

namespace _16.SubSetSumRandom
{
    using System;

    class SubSetSumRandom
    {
        static void Main()
        {
            //Getting input
            string str;
            int n;//length
            int s;

            Console.Write("Lenght of array: ");
            str = Console.ReadLine();

            if (int.TryParse(str, out n))
            {
                n = int.Parse(str);
                if (n <= 0)
                {
                    Console.WriteLine("Invalid Length: {0}", str);
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Invalid Length: {0}", str);
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

            bool exsists = false;
            //Bitwise operation instead of Pow
            int numberOfCombinations = 1 << n;

            //Finding a subset
            for (int i = 0; i < numberOfCombinations; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (((1 << j) & i) != 0)
                    {
                        sum += numbers[j];
                    }
                }
                //printing if a subset exsists
                if (sum == s)
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
