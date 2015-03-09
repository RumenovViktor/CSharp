using System;
using System.Collections.Generic;

class MinimalMaximalAvarageSumProduct
{
    static void Main()
    {
        int minimal = Minimal(12, 2, 313, 23, 1, 0);

        Console.WriteLine("The minimal is: {0}", minimal);

        int maximal = Maximal(12, 132, 2, 1243124, 12, 123);

        Console.WriteLine("The maximal is: {0}", maximal);

        double avarage = Avarage(12, 3, 1);

        Console.WriteLine("Avarage: {0}", avarage);

        string product = Product(-1, 2, 12, 142, 123, 1);

        Console.WriteLine("The product is: {0}", product);
    }

    static int Minimal(params int[] numbers)
    {
        Array.Sort(numbers);

        return numbers[0];
    }

    static int Maximal(params int[] numbers)
    {
        Array.Sort(numbers);
        Array.Reverse(numbers);

        return numbers[0];
    }

    static double Avarage(params int[] numbers)
    {
        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return (double)(sum / numbers.Length);
    }

    static string Product(params int[] numbers)
    {
        int multiplicate = 1;
        string product = " ";

        for (int i = 0; i < numbers.Length; i++)
        {
            multiplicate *= numbers[i];
        }

        if (multiplicate > 0)
        {
            product = "positive";
        }
        else if (multiplicate < 0)
        {
            product = "negative";
        }

        return product;
    }
}