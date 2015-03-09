using System;

class SevenlandNumbers
{
    static void Main()
    {
        //int [] numbers = new int[20];
        //string n = Console.ReadLine();
        //bool yes = true;
        //string checkedNumber;

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    checkedNumber = i.ToString();

        //    for (int j = 0; j < 0; j++)
        //    {
        //        int digit = checkedNumber[j] - '0';

        //        if (digit > 6 && digit < 10)
        //        {
        //            yes = false;
        //            break;
        //        }
        //    }

        //    if (yes)
        //    {
        //        numbers[i] = int.Parse(checkedNumber); 
        //    }
        //}

        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}
        int n = int.Parse(Console.ReadLine());

        int pow = 0;
        int nInBase10 = 0;
        while (n > 0)
        {
            int digit = n % 10;
            nInBase10 += digit * (int)Math.Pow(7, pow);
            pow++;
            n /= 10;
        }

        nInBase10++;

        string result = string.Empty;
        while (nInBase10 > 0)
        {
            int remainder = nInBase10 % 7;
            result = remainder + result;
            nInBase10 /= 7;
        }
        Console.WriteLine(result);
    }
}
