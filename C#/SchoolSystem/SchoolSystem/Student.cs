using System;
namespace SchoolSystem
{
    public class Student
    {
        private string name;
        private int uniqueNumber;
        private const int startPointForUniqueNumber = 10000;
        private const int endPointForUniqueNumber = 99999;

        public Student(string name, int uniqueNumber) 
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (value != "") 
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name must be filled!");
                }
            }
        }

        public int UniqueNumber 
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                if (value > startPointForUniqueNumber && value < endPointForUniqueNumber)
                {
                    this.uniqueNumber = value;
                }
                else
                {
                    throw new ArgumentException("Number is too big or too low!");
                }
            }
        }
    }
}
