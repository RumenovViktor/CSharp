using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckNeighbors
{
    static void Main()
    {
        Console.WriteLine("Enter length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        Console.Write("Enter position of the element: ");
        int position = int.Parse(Console.ReadLine());

        numbers = InitialiseArray(numbers);

        CheckNeghbors(position, numbers);
    }

    static int[] InitialiseArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }

    static void CheckNeghbors(int position, int[] numbers)
    {
        if (position - 1 >= 0 && position + 1 < numbers.Length)
        {
            if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
            {
                Console.WriteLine("Yes, the number on this position is bigger then it's neighbors.\n");
                return;
            }
            else if (numbers[position] > numbers[position - 1] || numbers[position] > numbers[position + 1])
            {
                Console.WriteLine("The number is bigger than one of it's neighbors.\n");
                return;
            }
            else
            {
                Console.WriteLine("No, it's not bigger then it's neighbors.\n");
                return;
            }
        }
        else
        {
            Console.WriteLine("Only one neighbor.\n");

            if (position + 1 >= numbers.Length)
            {
                if (numbers[position] > numbers[position - 1])
                {
                    Console.WriteLine("Bigger then left neighbor. ");
                    return;
                }
                else
                {
                    Console.WriteLine("Not bigger then left neighbor. ");
                    return;
                }
            }
            else if (position - 1 < 0)
            {
                if (numbers[position] > numbers[position + 1])
                {
                    Console.WriteLine("Bigger then right neighbor. ");
                    return;
                }
                else
                {
                    Console.WriteLine("Not bigger then right neighbor. ");
                    return;
                }
            }
        }
    }

    // Съжалявам, доста дълъг стана методът...
}
