using System;

class AstrologicalDitits
{
    static void Main()
    {
        string s = Console.ReadLine();
        double sum = 0;
        s = s.Trim('-');

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '.')
            {
                continue;
            }

            int digit = s[i] - '0';
            sum += digit;
        }   

        s = sum.ToString();

        while (sum > 9)
        {
            sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    continue;
                }

                int digit = s[i] - '0';
                sum += digit;
            }
            s = sum.ToString();
        }

        Console.WriteLine(sum);
    }   
}