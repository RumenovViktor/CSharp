//17.Write a program that reads a date and time given in 
//the format: day.month.year hour:minute:second and prints
//the date and time after 6 hours and 30 minutes (in the
//same format) along with the day of week in Bulgarian.

namespace _17.AfterSixHours
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    class AfterSixHours
    {
        static void PrintDay(DateTime date)
        {
            switch (date.DayOfWeek)
            {

                case DayOfWeek.Friday: Console.WriteLine("Петък");
                    break;
                case DayOfWeek.Monday: Console.WriteLine("Понеделник");
                    break;
                case DayOfWeek.Saturday: Console.WriteLine("Събота");
                    break;
                case DayOfWeek.Sunday: Console.WriteLine("Неделя");
                    break;
                case DayOfWeek.Thursday: Console.WriteLine("Четвъртък");
                    break;
                case DayOfWeek.Tuesday: Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday: Console.WriteLine("Сряда");
                    break;
            }
        }
        static void Main()
        {
            //makeing possible the printing of cirilic
            Console.OutputEncoding = Encoding.UTF8;

            DateTime today = new DateTime();

            try
            {
                Console.Write("Date: ");

                string[] input = Console.ReadLine().Split(new char[] { '.', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int year = int.Parse(input[2]);
                int month = int.Parse(input[1]);
                int day = int.Parse(input[0]);
                int hour = int.Parse(input[3]);
                int minute = int.Parse(input[4]);
                int second = int.Parse(input[5]);

                today = new DateTime(year, month, day, hour, minute, second);
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            today = today.AddHours(6.5);
            PrintDay(today);
        }
    }
}
