using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }
        //void populate()
        //{
        //    SqlConnection connect = connection.GetConnection();
        //    string query = "SELECT * FROM Patient";
        //    SqlDataAdapter ad = new SqlDataAdapter(query, connect);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(ad);
        //    DataSet ds = new DataSet();
        //    ad.Fill(ds);
        //   // dataGridView1.DataSource = ds.Tables[0];
        //    connect.Close();
        //}


            private void btnupdate_pat_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Patient p = new Patient();
            if (txtpatid.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                p.CNIC = cnicboxx.Text;
                p.ID = txtpatid.Text;
                p.Name = txtpatname.Text;
                p.Disease = txtpatdisease.Text;
                p.Doc = txtpatdoctorassign.Text;
                p.Phone = txtpatphone.Text;
                p.Age = txtpatage.Text;
                p.Address = txtpataddress.Text;
                p.Gender = combopatgender.Text;
                p.Blood = combopatbloodgroup.Text;
                p.Email = ebox2.Text;
                p.Password = pbox2.Text;
                p.Update();
                connect.Close();
                MessageBox.Show("Patient Data Update Successfully");

            }
            ebox2.Text = "";
            pbox2.Text  = "";
            cnicboxx.Text = "";
            txtpatid.Text = "";
            txtpatname.Text = "";
            txtpatdisease.Text = "";
            txtpatdoctorassign.Text = "";
            txtpatphone.Text = "";
            txtpatage.Text = "";
            txtpataddress.Text = "";
            combopatgender.Text = "";
            combopatbloodgroup.Text = "";
           // populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //populate();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
          //  populate();
        }

        private void btnadd_pat_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();

            Patient p = new Patient();
            if (txtpatid.Text == "" || txtpatname.Text == "" || txtpatdisease.Text == "" || txtpatdoctorassign.Text == "" || txtpatphone.Text == "" || txtpatage.Text == "" || txtpataddress.Text == "" || combopatgender.Text == "" || combopatbloodgroup.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                p.CNIC = cnicboxx.Text;
                p.ID = txtpatid.Text;
                p.Name = txtpatname.Text;
                p.Disease = txtpatdisease.Text;
                p.Doc = txtpatdoctorassign.Text;
                p.Phone = txtpatphone.Text;
                p.Age = txtpatage.Text;
                p.Address = txtpataddress.Text;
                p.Gender = combopatgender.Text;
                p.Blood = combopatbloodgroup.Text;
                p.Email = ebox2.Text;
                p.Password = pbox2.Text;
                p.Add();
                MessageBox.Show("Patient Data Added Successfully");
            }
            ebox2.Text = "";
            pbox2.Text = "";
            cnicboxx.Text = "";
            txtpatid.Text = "";
            txtpatname.Text = "";
            txtpatdisease.Text = "";
            txtpatdoctorassign.Text = "";
            txtpatphone.Text = "";
            txtpatage.Text = "";
            txtpataddress.Text = "";
            combopatgender.Text = "";
            combopatbloodgroup.Text = "";



            connect.Close();
           // populate();
        }

        private void btndelete_pat_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Patient p=new Patient();
            if (txtpatid.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                p.ID = txtpatid.Text;
                p.Delete();
                connect.Close();
                MessageBox.Show("Patient Data Delete Successfully");
            }
            txtpatid.Text = "";
          //  populate();

        }

        private void btndochome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h=new Home();
            h.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnicbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
