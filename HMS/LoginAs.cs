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
    public partial class LoginAs : Form
    {
        public LoginAs()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }

        private void LoginAs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm h = new LoginForm();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientLogin h = new PatientLogin();
            h.Show();
        }

        private void DocAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorLogin h = new DoctorLogin();
            h.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
