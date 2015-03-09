using System;
using System.Collections.Generic;

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class AllSystems
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter the system you want to use: ");
            int currentSystem = int.Parse(Console.ReadLine());

            Console.Write("Enter the system you want to convert to: ");
            int wantedSystem = int.Parse(Console.ReadLine());

            if (currentSystem < 2 || wantedSystem > 16)
            {
                Console.WriteLine("Invalied Input !");
                continue;
            }

            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            int numberToDecimal = ToDecimal(number, currentSystem);
            ToAnyNumeralSystem(numberToDecimal, wantedSystem);
        }
    }

    static int ToDecimal(string number, int system)
    {
        string digits = "0123456789ABCDEF";

        int decimalResult = 0;
        int power = number.Length - 1;
        
        for (int i = 0; i < number.Length; i++)
        {
            int index = digits.IndexOf(number[i]); // Get the number from the string
            decimalResult += index * (int)Math.Pow(system, power);
            power--;
        }

        return decimalResult;
    }

    static void ToAnyNumeralSystem(int number, int system)
    {
        string digit = "0123456789ABCDEF";
        List<int> digits = new List<int>();

        while (number != 0)
        {
            int reminder = number % system;
            number /= system;

            digits.Add(digit[reminder]);
        }

        ReverseRepresentation(digits);
    }

    static void ReverseRepresentation(List<int> number)
    {
        for (int i = number.Count - 1; i >= 0; i--)
        {
            Console.Write((char)number[i]);
        }

        Console.WriteLine();
    }
}