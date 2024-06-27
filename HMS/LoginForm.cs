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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border
            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "ahmed" && txtpassword.Text == "ahmed")
            {
                this.Hide();
                Home h=new Home();
                h.Show();
            }
            else
            {
                MessageBox.Show("Enter Correct UserName and Password");
                txtpassword.Text = "";
                txtusername.Text = "";
            }
        }
    }
}
