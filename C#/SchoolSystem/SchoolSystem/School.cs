namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        public List<Course> Courses { get; set; }
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
        }

        public string Name 
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddCourse(Course course) 
        {
            if (doesCourseExist(course))
            {
                throw new ArgumentException("Course already exists in the school!");
            }
            else
            {
                Courses.Add(course);
            }
        }

        public void RemoveCourse(Course course)
        {
            if (doesCourseExist(course))
            {
                Courses.Remove(course);
            }
            else
            {
                throw new ArgumentException("Course doesn't exist in the school!");
            }
        }

        // Check if a course is already added to the school
        private bool doesCourseExist(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseName == course.CourseName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
