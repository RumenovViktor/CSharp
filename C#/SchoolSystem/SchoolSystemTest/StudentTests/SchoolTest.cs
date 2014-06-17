namespace SchoolSystemTest.StudentTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestCourseAdd()
        {
            var school = new School("1OU");
            var course = new Course("Javascript");

            school.AddCourse(course);

            Assert.IsTrue(school.Courses.Count == 1);
        }

        [TestMethod]
        public void TestCourseRemoving()
        {
            var school = new School("1OU");
            var course = new Course("Javascript");

            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolName()
        {
            var school = new School("");
        }
    }
}
