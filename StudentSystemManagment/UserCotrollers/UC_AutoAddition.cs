using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemManagment.UserCotrollers
{
    public partial class UC_AutoAddition : UserControl
    {
        UC_Report table = new UC_Report();
        string[] names = new string[30]
        {
        "Alice",
        "Bob",
        "Charlie",
        "David",
        "Emily",
        "Frank",
        "Grace",
        "Henry",
        "Isabella",
        "Jack",
        "Kate",
        "Liam",
        "Mia",
        "Noah",
        "Olivia",
        "Penelope",
        "Quinn",
        "Ryan",
        "Samantha",
        "Tyler",
        "Ursula",
        "Victoria",
        "William",
        "Xander",
        "Yasmine",
        "Zachary",
        "Ava",
        "Benjamin",
        "Chloe",
        "Daniel"
        };

        public UC_AutoAddition(UC_Report reportTable)
        {
            InitializeComponent();
            table = reportTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 10000;
            // Create a new instance of the Random class
            Random random = new Random();

            // Get a random index between 0 and 29 (inclusive)
            while (n > 0)
            {
                int index1 = random.Next(0, 30);
                int index2 = random.Next(0, 30);
                string id = "" + random.Next(100000000,999999999);
                string phone = "" + random.Next(10000000,99999999);

                Student student = new Student(names[index1], names[index2], id, names[index1]+"@gmail.com", "05"+phone);
                student.AddGrade("course1",""+random.Next(0,100));
                student.AddGrade("course2", "" + random.Next(0, 100));
                student.AddGrade("course3", "" + random.Next(0, 100));
                student.AddGrade("course4", "" + random.Next(0, 100));
                student.AddGrade("course5", "" + random.Next(0, 100));
                StudentManager.AddStudent(student);
                n--;
            }
            successAuto.Text = "" + StudentManager.students.Count+",add seccsesfuly! ";
            table.SetDataGridView(StudentManager.GetStudents());
            
        }
    }
}
