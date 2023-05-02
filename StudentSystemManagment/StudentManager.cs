using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace StudentSystemManagment
{
    public static class StudentManager
    {

        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        //O(n^2)
//        public static void bubbleSort()
//        {
//            for (int i = 0; i<students.Count - 1; i++)
//            {
//                for (int j = 0; j<students.Count - i - 1; j++)
//                {
//                    if (students[j].GetAverageGrade() > students[j + 1].GetAverageGrade())
//                    {
//                        Student tempS = students[j];
//                        students[j] = students[j + 1];
//                        students[j + 1] = tempS;
//                    }
//}
//            }           
//        }

        //O(nlogn)
        public static void MergeSort(List<Student> arrayStudents)
        {
            if (arrayStudents.Count <= 1) return;

            int mid = arrayStudents.Count / 2;
            List<Student> left = new List<Student>(mid);
            List<Student> right = new List<Student>(arrayStudents.Count - mid);

            for (int i = 0; i < mid; i++)
                left.Add(arrayStudents[i]);

            for (int i = mid; i < arrayStudents.Count; i++)
                right.Add(arrayStudents[i]);

            MergeSort(left);
            MergeSort(right);
            Merge(arrayStudents, left, right);
        }

        public static void Merge(List<Student> arrayStudents, List<Student> left, List<Student> right)
        {
            int leftIndex = 0, rightIndex = 0, index = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].GetAverageGrade() < right[rightIndex].GetAverageGrade())
                {
                    arrayStudents[index] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arrayStudents[index] = right[rightIndex];
                    rightIndex++;
                }
                index++;
            }

            while (leftIndex < left.Count)
            {
                arrayStudents[index] = left[leftIndex];
                leftIndex++;
                index++;
            }

            while (rightIndex < right.Count)
            {
                arrayStudents[index] = right[rightIndex];
                rightIndex++;
                index++;
            }
        }
        
        public static List<Student> Sort (List<Student> students1){
            int startTime =DateTime.Now.Millisecond;
            //bubbleSort();
            MergeSort(students1);
            int finishTime =DateTime.Now.Millisecond;
            Trace.WriteLine("The running time: " + (finishTime - startTime) +"\n");
            return students1;
        }


    }


}
