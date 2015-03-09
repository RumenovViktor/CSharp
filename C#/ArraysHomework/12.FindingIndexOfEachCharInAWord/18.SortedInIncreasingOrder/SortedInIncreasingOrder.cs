//18.* Write a program that reads an array of integers and removes from it a minimal 
//number of elements in such way that the remaining array 
//is sorted in increasing order. Print the remaining sorted array. 

namespace _18.SortedInIncreasingOrder
{
    using System;

    class SortedInIncreasingOrder
    {
        //I'm using LIS dinamic programing algorithm
        static void PrintMaxSquences(int[] numbers)
        {
            string[] paths = new string[numbers.Length];
            int[] sequencesLenght = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                paths[i] = numbers[i].ToString() + ',';
                sequencesLenght[i] = 1;
            }

            int maxSequenceLenght = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] >= numbers[j] && sequencesLenght[i] < sequencesLenght[j] + 1)
                    {
                        sequencesLenght[i] = sequencesLenght[j] + 1;
                        paths[i] = paths[j] + numbers[i] + ',';
                        if (maxSequenceLenght < sequencesLenght[i])
                        {
                            maxSequenceLenght = sequencesLenght[i];
                        }
                    }
                }
            }

            //Printing all posible LIS
            for (int i = 1; i < numbers.Length; i++)
            {
                if (sequencesLenght[i] == maxSequenceLenght)
                {
                    Console.WriteLine("{" + paths[i] + "\b}");
                }
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

            //Calling the algorithm
            PrintMaxSquences(numbers);
        }
    }
}
