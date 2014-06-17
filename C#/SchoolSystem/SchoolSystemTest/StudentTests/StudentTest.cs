namespace SchoolSystemTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestNameShouldNotBeEmpty()
        {
            var student = new Student("Viktor", 31364);

            Assert.AreNotEqual(student.Name, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestUniqueNumberShouldBeBetween10000And99999()
        {
            int startPoint = 10000;
            int endPoint = 99999;
            var student = new Student("Viktor", 1);

            Assert.IsTrue(student.UniqueNumber > startPoint && student.UniqueNumber < endPoint);
        }
    }
}
