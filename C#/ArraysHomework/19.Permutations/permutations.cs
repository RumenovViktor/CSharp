//19.* Write a program that reads a number N and generates 
//and prints all the permutations of the numbers [1 … N]. 

namespace _19.Permutations
{
    using System;

    class permutations
    {
        //Using recursion
        static public void Permutations(int[] a, int position)
        {
            if (position == 0)
            {
                Console.Write("{");
                foreach (int number in a)
                {
                    Console.Write("{0},", number);
                }
                Console.WriteLine("\b}");
                return;
            }
            for (int i = 1; i <= a.Length; i++)
            {
                bool flag = true;
                for (int z = 0; z < a.Length && flag; z++)
                {
                    if (a[z] == i)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    a[a.Length - position] = i;
                    Permutations(a, position - 1);
                    a[a.Length - position] = 0;
                }
            }
        }

        static void Main()
        {
            //Getting input
            string str;
            int n;//Don't use too big numbers since permutations grow quickly

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

            int[] a = new int[n]; //need it for my logic
            //calling the recursive function
            Permutations(a, n);
        }
    }
}
