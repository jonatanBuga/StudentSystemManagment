using StudentSystemManagment.UserCotrollers;

namespace StudentSystemManagment
{
    public partial class Form1 : Form
    {
        UC_Report ucR = new UC_Report();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ButtonPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            
            addusercontrol(ucR);
            
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            UC_AutoAddition uc = new UC_AutoAddition(ucR);
            addusercontrol(uc);
        }
        private void addusercontrol(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            UC_AddStudent ucS = new UC_AddStudent(ucR);
            addusercontrol(ucS);
        } 

    }
}