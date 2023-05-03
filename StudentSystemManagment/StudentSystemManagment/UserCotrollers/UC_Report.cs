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
    public partial class UC_Report : UserControl
    {
        
        public UC_Report()
        {
            InitializeComponent();
            buildtable();
        }
        public void buildtable()
        {
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "ID";
            dataGridView1.Columns[3].Name = "Phone Number";
            dataGridView1.Columns[4].Name = "Email";
            dataGridView1.Columns[5].Name = "GPA";

        }
        public DataGridView GetDataGridView() { return dataGridView1; }
        public void SetDataGridView(List<Student> students)
        {
            dataGridView1.Rows.Clear();
            foreach (Student student in students)
            {
                dataGridView1.Rows.Add(student.FirstName, student.LastName, student.ID, student.PhoneNumber, student.Email, student.GetAverageGrade());
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }





    }
}
