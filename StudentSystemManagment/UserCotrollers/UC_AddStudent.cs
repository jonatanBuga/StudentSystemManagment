using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentSystemManagment.UserCotrollers
{
    public partial class UC_AddStudent : UserControl
    {

        UC_Report table = new UC_Report();
        public UC_AddStudent(UC_Report reportTable)
        {
            InitializeComponent();
            table = reportTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validEmail.Text = "";
            validID.Text = "";
            validPhone.Text = "";
            validCourse.Text = "";

            if (!string.IsNullOrEmpty(IDText.Text) && !string.IsNullOrEmpty(EmailText.Text) && !string.IsNullOrEmpty(PhoneNumberText.Text)
                && !string.IsNullOrEmpty(FirstNameText.Text) && !string.IsNullOrEmpty(LastNameText.Text))
            {
                if (IsValidId(IDText.Text) && IsValidEmail(EmailText.Text) && IsValidPhone(PhoneNumberText.Text))
                {
                    Student student = new Student(FirstNameText.Text, LastNameText.Text, IDText.Text, EmailText.Text, PhoneNumberText.Text);
                    if (IsValidGrade(Course1Text.Text, "Course 1", student) && IsValidGrade(Course2Text.Text, "Course 2", student) && IsValidGrade(Course3Text.Text, "Course 3", student) && IsValidGrade(Course4Text.Text, "Course 4", student) && IsValidGrade(Course5Text.Text, "Course 5", student))
                    {
                        StudentManager.AddStudent(student);
                        table.SetDataGridView(StudentManager.GetStudents());
                        FirstNameText.Text = "";
                        LastNameText.Text = "";
                        IDText.Text = "";
                        PhoneNumberText.Text = "";
                        EmailText.Text = "";
                        Course1Text.Text = "";
                        Course2Text.Text = "";
                        Course3Text.Text = "";
                        Course4Text.Text = "";
                        Course5Text.Text = "";
                    }


                }
            }

        }

        public bool IsValidId(string id)
        {
            if (id.Length != 9)
            {
                validID.Text = "Invalid ID";
                IDText.Text = "";
                return false;
            }

            foreach (char c in id)
            {
                if (!Char.IsDigit(c))
                {
                    validID.Text = "Invalid ID";
                    IDText.Text = "";
                    return false;
                }
            }
            return true;
        }
        public bool IsValidEmail(string Email)
        {
            // Use a regular expression to check if the email is valid
            var regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!regex.IsMatch(Email))
            {
                validEmail.Text = "Invalid Email";
                EmailText.Text = "";
                return false;
            }
            return true;

        }
        public bool IsValidPhone(string phone)
        {
            if (!(phone.Length == 10 && phone[0] == '0' && phone[1] == '5'))
            {
                validPhone.Text = "Invalid Phone";
                PhoneNumberText.Text = "";
                return false;
            }
            return true;
        }

        public bool IsValidGrade(string grade, string course, Student student)
        {
            if (grade == "" || grade == null)
            {
                student.AddGrade(course, "");
                return true;
            }
            float floatValue;

            // Using float.TryParse()
            if (float.TryParse(grade, out floatValue))
            {
                if (floatValue >= 0 && floatValue <= 100)
                {
                    student.AddGrade(course, grade);
                    return true;
                }
                validCourse.Text = "Invalid grade in " + course;
                return false;
            }
            validCourse.Text = "Invalid grade in " + course;
            return false;
        }

    }
}
