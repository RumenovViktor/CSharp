using System;
using System.Collections.Generic;

// 3. Write a program that prints to the console which day of the week is today. Use System.DateTime.


class WhichDayIsToday
{
    static void Main()
    {
        Console.WriteLine(System.DateTime.Now.DayOfWeek);
    }
}