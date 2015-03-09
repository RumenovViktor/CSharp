using System;
using System.Collections.Generic;

class GenericMethods
{
     static void Main()
    {
        object minimal = Minimal(12.2, 13, 2123);
        Console.WriteLine("Minimal: {0}", minimal);

        object maximal = Maximal(12.2, 13, 2123);
        Console.WriteLine("Maximal: {0}", maximal);

        object avarage = Avarage(12, 3, 1);
        Console.WriteLine("Avarage: {0}", avarage);

        object product = Avarage(12, -3, 1);
        Console.WriteLine("Product: {0}", product);

        object sum = Avarage(12, -3, 1, 123, 2, 54);
        Console.WriteLine("Product: {0}", sum);
    }

     static T Minimal<T>(params T[] numbers)
     {
         Array.Sort(numbers);

         return numbers[0];
     }

     static T Maximal<T>(params T[] numbers)
     {
         Array.Sort(numbers);

         return numbers[numbers.Length - 1];
     }

     static T Avarage<T>(params T[] numbers)
     {
         dynamic sum = 0;

         for (int i = 0; i < numbers.Length; i++)
         {
            sum += numbers[i];   
         }

         return sum / numbers.Length;
     }

     static T Product<T>(params T[] numbers)
     {
         dynamic multiplicate = 1;

         for (int i = 0; i < numbers.Length; i++)
         {
             multiplicate = multiplicate * numbers[i];
         }

         return multiplicate;
     }

     static T Sum<T>(params T[] numbers)
     {
         dynamic sum = 0;

         for (int i = 0; i < numbers.Length; i++)
         {
             sum += numbers[i];
         }

         return sum;
     }
}