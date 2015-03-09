using System;
using System.Collections.Generic;

// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:


class Program
{
    static void Main()
    {
        int counter = 0;

        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        for (int i = 0; i < text.Length - 1; i++)
        {
            if ((text[i] == 'i' || text[i] == 'I') && (text[i + 1] == 'n' || text[i + 1] == 'N'))
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}