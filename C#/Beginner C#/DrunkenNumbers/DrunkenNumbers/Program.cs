using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rightSum = 0;
        int leftSum = 0;

        for (int index = 0; index < n; index++)
        {
            long absNumber = long.Parse(Console.ReadLine());
            absNumber = Math.Abs(absNumber);
            string input = absNumber.ToString(); // parse to int then to string to remove the zeroes
            // input = input.TrimStart(new char [] { '0', '-' }); - друг начин 

            for (int i = 0; i < (input.Length + 1) / 2; i++)
            {
                int digit = input[i] - '0';
                leftSum += digit;
            }

            for (int i = input.Length / 2; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                rightSum += digit;
            }
        }

        if (leftSum < rightSum)
        {
            Console.WriteLine("V " + (rightSum - leftSum));
        }
        else if (leftSum > rightSum)
        {
            Console.WriteLine("M " + (leftSum - rightSum));
        }
        else
        {
            Console.WriteLine("No " + (leftSum + rightSum));
        }
    }
}
