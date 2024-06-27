using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border
            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }

        private void btndoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm d = new DoctorForm();
            d.Show();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm p = new PatientForm();
            p.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm l=new LoginForm();
            l.Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Help h=new Help();
            //h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiagnosisForm d=new DiagnosisForm();
            d.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm p=new PatientForm();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm d=new DoctorForm();
            d.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiagnosisForm d= new DiagnosisForm();
            d.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Help h= new Help();
            //h.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAs h = new LoginAs();
            h.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void logutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAs h = new LoginAs();
            h.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void AddPat_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm p = new PatientForm();
            p.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DiagnosisForm d = new DiagnosisForm();
            d.Show();
        }

        private void AddDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm h = new DoctorForm();
            h.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            DocList h = new DocList();
            h.Show();
        }

        private void PatientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientList h = new PatientList();
            h.Show();
        }
    }
}
