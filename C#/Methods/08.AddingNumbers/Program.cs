using System;
using System.Collections.Generic;

class AddingNumbers
{
    static void Main()
    {
        int wantedLengthForFirstNumber = int.Parse(Console.ReadLine());
        int wantedLengthForSecondNumber = int.Parse(Console.ReadLine());
        
        int length = Math.Max(wantedLengthForFirstNumber, wantedLengthForSecondNumber); // Get the common length 
        
        int[] firstNumber = new int[length];       
        int[] secondNumber = new int[length];

        InitializeArrays(firstNumber, wantedLengthForFirstNumber); // Initialising the first array of digits
        InitializeArrays(secondNumber, wantedLengthForSecondNumber); // Initialising the second array of digits

        CalculateTwoIntegers(firstNumber, secondNumber, length);
    }

    static void CalculateTwoIntegers(int[] firstNumber, int[] secondNumber, int length)
    {
        List<int> calculated = new List<int>(); // The array that will keep the calculated digits

        for (int i = length - 1; i >= 0; i--)
        {
            if (firstNumber[i] + secondNumber[i] >= 10 && i - 1 >= 0) // Checks if the sum is bigger then 9 and if next element exists
            {
                calculated.Add((firstNumber[i] + secondNumber[i]) - 10);
                firstNumber[i - 1]++;
                continue;
            }
            else if (firstNumber[i] + secondNumber[i] >= 10 && i - 1 < 0)
            {
                calculated.Add((firstNumber[i] + secondNumber[i]) - 10); // Gets the right digit of the sum 
                calculated.Add(1);
                continue;
            }

            int sum = firstNumber[i] + secondNumber[i];
            calculated.Add(sum);
        }

        PrintList(calculated);
    }

    /* In the main method I take the wanted length for the array and the real length (which is always bigger then the wanted).
     * The reason for that is - for example if we have two arrays {4, 3, 2} and {3, 2} and the idea is
     * to add an element 0, so the length of the arrays to be equal. This way we make the adding possible. This is what it happens:
     *
     *          432
     *          032
     *          ---
     *          464
     *          
     * So we don't get out of the boundries of the array.
     * If we didn't have the 0 digit we wouldn't be abble to add a number to the digit 4, because such digit doesn't exist.
     */

    static void InitializeArrays(int[] digits, int lengthToFill)
    {
        for (int i = 0; i < lengthToFill; i++)
        {
            Console.Write("digits[{0}]: ", i);
            digits[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
    }

    // Prints the result of the additioning of the digits 
    static void PrintList (List<int> digits)
    {
        for (int i = digits.Count - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }

        Console.WriteLine();
    }
}