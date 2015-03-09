using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string expression = "ABBAA6BA";

        //char lastChar = expression[expression.Length - 1];
        Console.WriteLine(Decode(expression));
    }

    static string Decode(string expression)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder numbers = new StringBuilder();
        int n = 0;
        char lastChar = expression[expression.Length - 1];

        for (int i = 0; i < expression.Length - 1; i++)
        {
            numbers.Append(expression[i]);
            bool canParse = int.TryParse(numbers.ToString(), out n);
            if (!canParse)
            {
                numbers.Clear();
                result.Append(expression[i]);
            }
            else if (!Char.IsDigit(expression[i + 1]))
            {
                int num = int.Parse(numbers.ToString());

                result.Append(new string(expression[i + 1], num - 1));
            }
            else
            {
                result.Append(expression[i]);
            }
        }

        result.Append(lastChar);

        return result.ToString();
    }
}