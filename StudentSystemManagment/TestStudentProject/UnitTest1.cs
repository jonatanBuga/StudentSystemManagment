using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSystemManagment;

namespace TestStudentProject
{
    [TestClass]
    public class GetAverageGradeTest
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
            Assert.AreEqual(55, average4, "Expected average to be 55 when there is a missing grade.");

            // Test case where there is an invalid grade
            var student5 = new Student("David", "Lee", "579246813", "david.lee@example.com", "555-2468");
            student5.AddGrade("Math", "85");
            student5.AddGrade("Science", "90");
            var average5 = student5.GetAverageGrade();
            Assert.AreEqual(87.5, average5, "Expected average to be 87.5 when there is an invalid grade.");
        }

    }
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            // Arrange
            List<Student> students = new List<Student>();
            Student s1 = new Student("John", "Doe", "123456789", "john.doe@example.com", "05251334561");
            s1.AddGrade("Math", "80");
            s1.AddGrade("English", "70");
            students.Add(s1);

            Student s2 = new Student("Jane", "Doe", "987654321", "jane.doe@example.com", "0525112341");
            s2.AddGrade("Math", "90");
            s2.AddGrade("English", "85");
            students.Add(s2);

            Student s3 = new Student("Alice", "Smith", "111222333", "alice.smith@example.com", "0525189741");
            s3.AddGrade("Math", "95");
            s3.AddGrade("English", "75");
            students.Add(s3);

            // Act
            StudentManager.students = students;
            StudentManager.bubbleSort();

            // Assert
            Assert.AreEqual(s1, StudentManager.students[0]);
            Assert.AreEqual(s3, StudentManager.students[1]);
            Assert.AreEqual(s2, StudentManager.students[2]);
        }
    }


    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void GoodSort()
        {
            List<Student> students = new List<Student>()
            {
                new Student("John", "Doe", "123456789", "johndoe@example.com", "555-1234"),
                new Student("Jane", "Doe", "987654321", "janedoe@example.com", "555-5678"),
                new Student("Bob", "Smith", "456789123", "bobsmith@example.com", "555-2468")
            };

            // Arrange
            students[0].AddGrade("Math", "90");
            students[0].AddGrade("English", "85");
            students[1].AddGrade("Math", "80");
            students[1].AddGrade("English", "95");
            students[2].AddGrade("Math", "75");
            students[2].AddGrade("English", "90");

            // Act
            var sortedStudents = StudentManager.Sort(students); 

            // Assert
            Assert.AreEqual(students.Count, sortedStudents.Count);

            for (int i = 1; i < sortedStudents.Count; i++)
            {
                Assert.IsTrue(sortedStudents[i].GetAverageGrade() >= sortedStudents[i - 1].GetAverageGrade());
            }
        }
    }

    [TestClass]
    public class StudentTests
    {
        private Student student;

        [TestInitialize]
        public void TestInitialize()
        {
            student = new Student("John", "Doe", "123456789", "johndoe@example.com", "1234567890");
        }

        [TestMethod]
        public void TestAddGrade()
        {
            student.AddGrade("Math", "90");
            student.AddGrade("Science", "80");
            student.AddGrade("English", "70");
            Assert.AreEqual(3, student.Grades.Count);
            Assert.AreEqual(90, student.Grades["Math"]);
            Assert.AreEqual(80, student.Grades["Science"]);
            Assert.AreEqual(70, student.Grades["English"]);
        }

        [TestMethod]
        public void TestAddGradeWithEmptyGrade()
        {
            student.AddGrade("Math", "");
            Assert.AreEqual(1, student.Grades.Count);
            Assert.AreEqual(777, student.Grades["Math"]);
        }

        [TestMethod]
        public void TestGetAverageGradeWithNoGrades()
        {
            Assert.AreEqual(0, student.GetAverageGrade());
        }

        [TestMethod]
        public void TestGetAverageGradeWithOneGrade()
        {
            student.AddGrade("Math", "90");
            Assert.AreEqual(90, student.GetAverageGrade());
        }

        [TestMethod]
        public void TestGetAverageGradeWithMultipleGrades()
        {
            student.AddGrade("Math", "90");
            student.AddGrade("Science", "80");
            student.AddGrade("English", "70");
            Assert.AreEqual(80, student.GetAverageGrade());
        }

        [TestMethod]
        public void TestIsValidIdWithValidId()
        {
            Assert.IsTrue(student.IsValidId("123456789"));
        }

        [TestMethod]
        public void TestIsValidIdWithInvalidId()
        {
            Assert.IsFalse(student.IsValidId("1234"));
        }

        [TestMethod]
        public void TestIsValidEmailWithValidEmail()
        {
            Assert.IsTrue(student.IsValidEmail());
        }

        [TestMethod]
        public void TestIsValidEmailWithInvalidEmail()
        {
            student = new Student("John", "Doe", "123456789", "", "1234567890");
            Assert.IsFalse(student.IsValidEmail());
        }
    }
}