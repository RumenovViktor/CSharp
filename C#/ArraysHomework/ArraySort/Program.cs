using System;
/*
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the 
 * smallest from the rest, move it at the second position, etc.
*/
class ArraySort
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int [] arr = new int [length];

        // Initialising the array
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Checking element with every single next element in the array
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                // The sorting is like changing the values of 2 numbers
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
