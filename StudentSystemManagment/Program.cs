using System.Security.Cryptography.X509Certificates;

namespace StudentSystemManagment
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        //static void Main()
        //{
        //    Student student1 = new Student("matan", "n", "316612977", "ma@gmail.com", "0502420440");
        //    student1.AddGrade("course1", "70");
        //    student1.AddGrade("course2", "50");
        //    Student student2 = new Student("os", "n", "316612977", "ma@gmail.com", "0502420440");
        //    student2.AddGrade("course1", "100");
        //    student2.AddGrade("course2", "45");
        //    Student student3 = new Student("buga", "n", "316612977", "ma@gmail.com", "0502420440");
        //    student3.AddGrade("course1", "85");
        //    student3.AddGrade("course2", "77");
        //    Student student4 = new Student("man", "n", "316612977", "ma@gmail.com", "0502420440");
        //    student4.AddGrade("course1", "60");
        //    student4.AddGrade("course2", "95");
        //    StudentManager.AddStudent(student1);
        //    StudentManager.AddStudent(student2);
        //    StudentManager.AddStudent(student3);
        //    StudentManager.AddStudent(student4);
        //    foreach (var i in StudentManager.students)
        //    {
        //        Console.WriteLine(i.FirstName + "Average:" + i.GetAverageGrade());
        //    }
        //    StudentManager.MergeSort(StudentManager.students);
        //    foreach (var i in StudentManager.students)
        //    {
        //        Console.WriteLine(i.FirstName + "Average:" + i.GetAverageGrade());
        //    }
        //}
    }
}