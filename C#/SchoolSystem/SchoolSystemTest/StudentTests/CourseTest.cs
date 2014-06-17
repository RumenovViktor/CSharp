namespace SchoolSystemTest.StudentTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestCourseAddStudentMethod()
        {
            var course = new Course("Javascript");
            var student = new Student("Shagi", 31364);

            course.AddStudent(student);

            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void TestCourseRemoveStudentMethod()
        {
            var course = new Course("Javascript");
            var student = new Student("Shagi", 31364);

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.IsTrue(course.Students.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseName() 
        {
            var course = new Course("");
        }
    }
}
