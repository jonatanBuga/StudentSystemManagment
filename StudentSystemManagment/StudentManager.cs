using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemManagment
{
    public static class StudentManager
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);  
        }
        public static List <Student> GetStudents() { return students; }
        public static void bubbleSort()
        {
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = 0; j < students.Count - i - 1; j++)
                {
                    if (students[j].GetAverageGrade() > students[j + 1].GetAverageGrade())
                    {
                        Student tempS = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = tempS;
                    }
                }
            }           
        }
    } 
}
