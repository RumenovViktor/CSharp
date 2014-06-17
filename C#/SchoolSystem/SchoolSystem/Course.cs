namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    
    public class Course
    {
        private string courseName;
        public List<Student> Students { get; set; }

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.Students = new List<Student>();
        }

        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name can not be empty");
                }
                else
                {
                    this.courseName = value;
                }
            }
        }

        // Add student to the student list
        public void AddStudent(Student student) 
        {
            if (doesExists(student))
            {
                throw new ArgumentException("Student already exists in the list!");
            }
            else
            {
                this.Students.Add(student);
            }
        }

        // Remove student from the student list
        public void RemoveStudent(Student student) 
        {
            if (doesExists(student))
            {
                this.Students.Remove(student);
            }
            else
            {
                throw new ArgumentException("Student does not exist!");
            }
        }

        // Check if student exists
        private bool doesExists(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (student.UniqueNumber == Students[i].UniqueNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
