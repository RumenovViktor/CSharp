using System;
/*
 * Write a program that allocates array of 20 integers and initializes 
 * each element by its index multiplied by 5. Print the obtained array 
 * on the console.
*/
class InitialiseArray
{
    static void Main()
    {
        int [] arr = new int [20];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
            arr[i] *= 5;
        }

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}