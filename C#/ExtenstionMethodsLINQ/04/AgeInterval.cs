using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class AgeInterval
    {
        static void Main()
        {

        }

        public static void AgeInterval(Student[] arr)
        {
            var ageInterval =
                from student in arr
                where ((student.Age >= 18) && (student.Age <= 24))
                select student;
            foreach (Student c in ageInterval)
                Console.WriteLine(c);
        }
    }
}
