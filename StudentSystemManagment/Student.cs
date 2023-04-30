using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentSystemManagment
{
    public class Student
    {
        private object validId;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Dictionary<string, float> Grades { get; set; }
        public object InfoLable { get; private set; }

        public Student(string firstName, string lastName, string id, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Email = email;
            PhoneNumber = phoneNumber;
            Grades = new Dictionary<string, float>();
        }

        public float GetAverageGrade()
        {
            float sum = 0;
            if (Grades.Count == 0)
            {
                return 0;
            }
            foreach (var v in Grades.Values)
            {
                if (v == 777)
                {
                    continue;
                }
                sum += v;
            }
            return sum / Grades.Count;
        }

        public void AddGrade(string course, string grade)
        {
            if (grade == "" || grade == null)
            {
                Grades[course] = 777;
            }
            else
            {
                Grades[course] = float.Parse(grade);
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone number: " + PhoneNumber);
            Console.WriteLine("Grades:");
            foreach (KeyValuePair<string, float> grade in Grades)
            {
                Console.WriteLine(grade.Key + ": " + grade.Value);
            }
            Console.WriteLine("Average grade: " + GetAverageGrade());
        }

        public String ShowDetails()
        {
            return "Name: " + FirstName + " " + LastName + "\n" + "ID: " + ID + "\n" + "Email: " + Email + "\n"
                + "Phone number: " + PhoneNumber;
        }
        public bool IsValidId(string ID)
        {
            if (ID.Length != 9)
            {
                return false;
            }

            foreach (char c in ID)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsValidEmail()
        {
            if (string.IsNullOrEmpty(Email))
            {
                return false;
            }

            try
            {
                // Use a regular expression to check if the email is valid
                var regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                return regex.IsMatch(Email);
            }
            catch
            {
                return false;
            }
        }

    }
}
