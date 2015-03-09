//19.Write a program that extracts from a given text all
//dates that match the format DD.MM.YYYY. Display them
//in the standard date format for Canada.

namespace _19.FindDates
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;

    class FindDates
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-CA");

            Console.WriteLine("Enter text: ");
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length == 10)
                {
                    try
                    {
                        DateTime date = DateTime.ParseExact(input[i], "dd.MM.yyyy", culture);
                        Console.WriteLine(date);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
