//16.Write a program that reads two dates in the format: 
//day.month.year and calculates the number of days between them. 
namespace _16.CalculateDays
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CalculateDays
    {
        static void Main()
        {
            //getting input
            DateTime today = new DateTime();
            DateTime endDate = new DateTime();

            try
            {
                Console.Write("Start: ");
                string[] input = Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                int year = int.Parse(input[2]);
                int month = int.Parse(input[1]);
                int day = int.Parse(input[0]);

                today = new DateTime(year, month, day);

                Console.Write("End: ");
                input = Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                year = int.Parse(input[2]);
                month = int.Parse(input[1]);
                day = int.Parse(input[0]);

                endDate = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            endDate = endDate.AddDays(1);//because of the loop

            //counting
            int daysCount = 0;
            while (today <= endDate)
            {
                daysCount++;
                today = today.AddDays(1);
            }

            //printing
            Console.WriteLine("There are {0} days in that interval.", daysCount);
        }
    }
}
