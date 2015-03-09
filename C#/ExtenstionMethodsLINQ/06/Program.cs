using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 20, 21, 42, 3, 5 };
            //lambda
            int[] result = myArray.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            //ling
            int[] result2 = (from num in myArray where num % 7 == 0 && num % 3 == 0 select num).ToArray();
            foreach (int item in result2)
            {
                Console.WriteLine(item);
            } 
        }
    }
}
