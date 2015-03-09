//Write a program that reads two numbers N and K and 
//generates all the variations of K elements from the set [1..N]. 

namespace _20.Variations
{
    using System;

    class Variations
    {
        //Using the same recursion from the previous task with some small changes
        //I wont change the name
        static public void Permutations(int[] a, int position, int n)
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
            for (int i = 1; i <= n; i++)
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
                    Permutations(a, position - 1, n);
                    a[a.Length - position] = 0;
                }
            }
        }
        static void Main()
        {
            //Getting input
            string str;
            int n,k;//Don't use too big numbers since permutations grow quickly

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

            int[] a = new int[k]; //need it for my logic
            //calling the recursive function
            Permutations(a, k, n);
        }
    }
}
