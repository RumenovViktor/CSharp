using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MenuWithFunctionalities
{
    static void Main()
    {
        Console.WriteLine("Enter number 1 to 3:\n\t- 1 - For Reversing the digits of a number");
        Console.WriteLine("\t- 2 - To calculate the avarage value between numbers");
        Console.WriteLine("\t- 3 - To solve a linear equasion");
        byte choice = byte.Parse(Console.ReadLine());

        // Analises the choice
        switch (choice)
        {
            case 1:
                Console.WriteLine("The number should be positive integer, minuses will be deletet.");
                string number = Console.ReadLine();
                number = number.Trim('-');

                ReverseNumber(number);
                break;
            case 2:
                Console.Write("How many numbers: ");
                int length = 0;

                while (length == 0)
                {
                    length = int.Parse(Console.ReadLine());
                }

                double[] numbers = new double [length];

                numbers = InitialiseArray(numbers);

                double avarageValue = CalculateAvarageOfIntegers(numbers, length);

                Console.WriteLine(avarageValue);
                break;
            case 3:
                Console.Write("Enter value for a: ");
                double a = int.Parse(Console.ReadLine());

                while (a == 0)
                {
                    Console.WriteLine("The coeficient a must not be zero.");
                    a = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter calue for b: ");
                double b = int.Parse(Console.ReadLine());

                double result = SolveLinearEquesion(a, b);

                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("Wrong input.");
                break;
        }
    }

    static void ReverseNumber(string number)
    { 
        // TODO: Reverse the digits in a number 
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }

        Console.WriteLine();
    }

    static double CalculateAvarageOfIntegers(double[] numbers, int length)
    {
        // TODO: Calculate the avarege of a set of numbers
        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum / length;
    }

    static double SolveLinearEquesion(double a, double b)
    {
        // TODO: Solves a mathematical linear equasion
        double result = -b / a;

        return result;
    }

    static double[] InitialiseArray(double[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]: ", i);
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        return numbers;
    }
}