using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class OrderNames
    {
        static void Main()
        {
        }

        public static void OrderByNames(Student[] arr)
        {
            var ordered =
                from student in arr
                orderby student.FirstName, student.LastName
                select student;
            foreach (var c in ordered)
                Console.WriteLine(c);
        }
    }
}
