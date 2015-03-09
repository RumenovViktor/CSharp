using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitName
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int digit = number % 10;

        Console.WriteLine(GetDigitName(digit));
    }

    static string GetDigitName(int digit)
    {
        string name = "";

        switch (digit)
        {
            case 0:
                name = "Zero";
                break;
            case 1:
                name = "One";
                break;
            case 2:
                name = "Two";
                break;
            case 3:
                name = "Three";
                break;
            case 4:
                name = "Four";
                break;
            case 5:
                name = "Five";
                break;
            case 6:
                name = "Six";
                break;
            case 7:
                name = "Seven";
                break;
            case 8:
                name = "Eight";
                break;
            case 9:
                name = "Nine";
                break;
            default:
                break;
        }
        return name;
    }
}
