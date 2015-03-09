using System;
using System.Collections.Generic;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class Program
{
    static void Main()
    {
        string mathExpression = Console.ReadLine();
        const char openingBracket = '(';
        const char closingBracket = ')';
        int counter = 0;
        bool validExpression = true;

        for (int i = 0; i < mathExpression.Length; i++)
        {
            if (mathExpression[i] == openingBracket)
            {
                counter++;
            }
            else if (mathExpression[i] == closingBracket)
            {
                counter--;
            }

            if (counter < 0)
            {
                validExpression = false;
                Console.WriteLine(validExpression);
                return;
            }
        }

        if (counter > 0)
        {
            validExpression = false;
            Console.WriteLine(validExpression);
            return;
        }
        else
        {
            Console.WriteLine(validExpression);
        }
    }
}