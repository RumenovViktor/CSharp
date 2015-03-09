using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FindNamesWithLINQ
{
    public class Student
    {
        private string firstName;
        private string secondName;

        public Student()
        {
        }

        public Student(string firstName)
        {
            this.firstName = firstName;
        }

        public Student(string firstName, string secondName) : this (firstName)
        {
            this.secondName = secondName;        
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }

        public List<Student> FirstNameBeforeLastName(List<Student> students)
        { 
            List<Student> renderedStudents = new List<Student>();
            renderedStudents = students.FindAll(x => FirstName[0] < SecondName[0]);
            
            return renderedStudents;
        }
    }
}
