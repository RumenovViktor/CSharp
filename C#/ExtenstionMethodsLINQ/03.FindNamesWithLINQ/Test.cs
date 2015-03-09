using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.FindNamesWithLINQ;

class Test
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        const int numberOfStudents = 2;

        for (int i = 0; i < numberOfStudents; i++)
        {
            Student student = new Student();
            student.FirstName = Console.ReadLine();
            student.SecondName = Console.ReadLine();

            students.Add(student);
        }

        Console.WriteLine();
    }
}