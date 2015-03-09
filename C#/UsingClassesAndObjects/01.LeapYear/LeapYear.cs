using System;
using System.Collections.Generic;

// 1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);

        Console.WriteLine("Is it leap ?: {0}", isLeap);
    }
}