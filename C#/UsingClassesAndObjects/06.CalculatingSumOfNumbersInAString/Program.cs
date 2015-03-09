using System;
using System.Collections.Generic;

//6. You are given a sequence of positive integer values written into a string, separated 
//   by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//   string = "43 68 9 23 318"  result = 461

class CalculatingSum
{
    static void Main()
    {
        string numbers = Console.ReadLine();

        string[] separated = SplitNumbers(numbers);

        Console.WriteLine(GetSum(separated));
    }

    static string[] SplitNumbers(string numbers)
    {
        string[] separatedNumbers = new string[numbers.Length];

        separatedNumbers = numbers.Split(' ');

        return separatedNumbers;
    }

    static int GetSum(string[] separatedNumbers)
    {
        int sum = 0;

        foreach (var item in separatedNumbers)
        {
            int number = 0;
            number = int.Parse(item);
            sum += number;
        }

        return sum;
    }
}