//13. *Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

namespace _13.MergeSort
{
    using System;

    class MergeSort
    {
        //I'm using the Pseudocode from wikipedia
        static int[] Merge(int[] a, int[] b)
        {
            int positionA = 0;
            int positionB = 0;
            int position = 0;
            int[] merged = new int[a.Length + b.Length];

            while (positionA < a.Length && positionB < b.Length)
            {
                if (a[positionA] < b[positionB])
                {
                    merged[position] = a[positionA];
                    positionA++;
                }
                else
                {
                    merged[position] = b[positionB];
                    positionB++;
                }
                position++;
            }

            while (positionA < a.Length)
            {
                merged[position] = a[positionA];
                positionA++;
                position++;
            }

            while (positionB < b.Length)
            {
                merged[position] = b[positionB];
                positionB++;
                position++;
            }
            return merged;
        }

        static int[] Mergesort(int[] toSplit)
        {
            if (toSplit.Length <= 1)
            {
                return toSplit;
            }
            else
            {
                int middle = toSplit.Length / 2;
                int[] left = new int[middle];
                int[] right = new int[toSplit.Length - middle];
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = toSplit[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = toSplit[middle + i];
                }
                left = Mergesort(left);
                right = Mergesort(right);
                return Merge(left, right);
            }
        }

        static void Main()
        {
            //Getting input
            string str;
            int n;//length

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
                Console.Write("Array[{0}]: ",i);
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

            //Calling the Merge Sort
            numbers = Mergesort(numbers);

            //Printing on Console
            foreach (int num in numbers)
            {
                Console.Write(num + ",");
            }
        }
    }
}
