using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSystemManagment;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAverageGrade()
        {
            // Arrange
            Student student = new Student("John", "Doe", "123456789", "johndoe@example.com", "1234567890");
            student.AddGrade("Math", "85");
            student.AddGrade("Science", "90");
            student.AddGrade("English", "80");

            // Act
            float actual = student.GetAverageGrade();

            // Assert
            float expected = (85 + 90 + 80) / 3f;
            Assert.AreEqual(expected, actual, "The average grade is not calculated correctly.");
            
            // Test case where there are no grades
            var student1 = new Student("John", "Doe", "123456789", "john.doe@example.com", "555-1234");
            var average1 = student1.GetAverageGrade();
            Assert.AreEqual(0, average1, "Expected average to be 0 when there are no grades.");

            // Test case where there is only one grade
            var student2 = new Student("Jane", "Doe", "987654321", "jane.doe@example.com", "555-5678");
            student2.AddGrade("Math", "85");
            var average2 = student2.GetAverageGrade();
            Assert.AreEqual(85, average2, "Expected average to be 85 when there is one grade.");

            // Test case where there are multiple grades
            var student3 = new Student("Bob", "Smith", "246813579", "bob.smith@example.com", "555-4321");
            student3.AddGrade("Math", "85");
            student3.AddGrade("Science", "90");
            student3.AddGrade("English", "80");
            var average3 = student3.GetAverageGrade();
            Assert.AreEqual(85, average3, "Expected average to be 85 when there are multiple grades.");

            // Test case where there is a missing grade
            var student4 = new Student("Alice", "Jones", "135792468", "alice.jones@example.com", "555-8765");
            student4.AddGrade("Math", "85");
            student4.AddGrade("Science", "");
            student4.AddGrade("English", "80");
            var average4 = student4.GetAverageGrade();
            Assert.AreEqual(82.5, average4, "Expected average to be 82.5 when there is a missing grade.");

            // Test case where there is an invalid grade
            var student5 = new Student("David", "Lee", "579246813", "david.lee@example.com", "555-2468");
            student5.AddGrade("Math", "85");
            student5.AddGrade("Science", "90");
            student5.AddGrade("English", "A");
            var average5 = student5.GetAverageGrade();
            Assert.AreEqual(87.5, average5, "Expected average to be 87.5 when there is an invalid grade.");
        }



    }
}