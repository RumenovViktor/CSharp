using System;
using System.Collections.Generic;

class Workdays
{
    //5.Write a method that calculates the number of workdays between 
    //today and given date, passed as parameter. Consider that workdays 
    //are all days from Monday to Friday except a fixed list of
    //public holidays specified preliminary as array.

    //Gets Input
    static int Input(string message)
    {
        int number;

        Console.Write(message);
        string str = Console.ReadLine();

        if (int.TryParse(str, out number))
        {
            number = int.Parse(str);
            if (number < 0)
            {
                throw new System.ArgumentException("Bad Input.");
            }
            return number;
        }
        else
        {
            throw new System.ArgumentException("Bad Input.");
        }
    }
    static void Main()
    {
        //http://en.wikipedia.org/wiki/Public_holidays_in_Bulgaria
        DateTime[] holidays = {
            new DateTime(1970,1,1), 
            new DateTime(1970,1,2), 
            new DateTime(1970,3,3), 
            new DateTime(1970,5,1), 
            new DateTime(1970,5,6), 
            new DateTime(1970,5,24), 
            new DateTime(1970,9,6), 
            new DateTime(1970,9,22), 
            new DateTime(1970,11,1), 
            new DateTime(1970,12,24), 
            new DateTime(1970,12,25), 
            new DateTime(1970,12,26)
            };

        //getting input
        int year = Input("Enter Year: ");
        int month = Input("Enter Month: ");
        int day = Input("Enter Day: ");

        //validating
        if (month > 12)
        {
            Console.WriteLine("Invalid date {0}.{1}.{2}!", year, month, day);
            return;
        }
        if (day > DateTime.DaysInMonth(year, month) || (DateTime.Today > new DateTime(year, month, day)))
        {
            Console.WriteLine("Invalid date {0}.{1}.{2}!", year, month, day);
            return;
        }

        DateTime today = DateTime.Today;
        DateTime endDate = new DateTime(year, month, day);
        endDate = endDate.AddDays(1);//because of the loop

        //counting
        int workdaysCount = 0;
        while (today != endDate)
        {
            today.AddDays(1);
            bool aHoliday = false;
            for (int i = 0; i < holidays.Length; i++)
            {
                if (today.Day == holidays[i].Day && today.Month == holidays[i].Month)
                {
                    aHoliday = true;
                    break;
                }
            }
            if (!(aHoliday || today.DayOfWeek.ToString() == "Sunday"
                || today.DayOfWeek.ToString() == "Saturday"))
            {
                workdaysCount++;
            }
            today = today.AddDays(1);
        }
        //printing
        Console.WriteLine("There are {0} working days in that onterval.", workdaysCount);
    }
}