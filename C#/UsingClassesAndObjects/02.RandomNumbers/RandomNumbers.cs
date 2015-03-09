using System;
using System.Collections.Generic;

// 2. Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomNumbers
{
    static void Main()
    {
        GenerateRandomNumbers();
    }

    static void GenerateRandomNumbers()
    {
        Random number = new Random();

        for (int i = 0; i < 10; i++)
        {
            int num = number.Next(100, 200);

            Console.WriteLine(num);
        }
    }
}