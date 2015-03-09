//14.Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

namespace _14.QuickSort
{
    using System;

    class Quicksort
    {
        //I'm using the Pseudocode from wikipedia
        static void Swap(int[] toSort, int first, int second)
        {
            int temp = toSort[first];
            toSort[first] = toSort[second];
            toSort[second] = temp;
        }

        static void QuickSort(int[] toSort, int left, int right)
        {
            if (right > left)
            {
                int pivot = (left + right) / 2;
                pivot = Partition(toSort, left, right, pivot);
                QuickSort(toSort, left, pivot - 1);
                QuickSort(toSort, pivot + 1, right);
            }
        }

        static int Partition(int[] toSort, int left, int right, int pivot)
        {
            int pivotValue = toSort[pivot];
            Swap(toSort, right, pivot);
            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (toSort[i] <= pivotValue)
                {
                    Swap(toSort, i, storeIndex);
                    storeIndex++;
                }
            }
            Swap(toSort, storeIndex, right);
            return storeIndex;
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

            //Calling the Quick Sort
            QuickSort(numbers, 0, n - 1);

            //Printing on Console
            foreach (int num in numbers)
            {
                Console.Write(num + ",");
            }
        }
    }
}
