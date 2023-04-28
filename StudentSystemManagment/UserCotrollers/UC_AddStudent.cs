using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemManagment.UserCotrollers
{
    public partial class UC_AddStudent : UserControl
    {
        public UC_AddStudent()
        {
            InitializeComponent();
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
