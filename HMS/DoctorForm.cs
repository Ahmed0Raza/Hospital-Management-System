using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }
       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_doc_Click(object sender, EventArgs e)
        {

             SqlConnection connect= connection.GetConnection();
             Doctor d = new Doctor();
            if (txtid.Text == "" || txtname.Text == "" || txtsalary.Text == "" || txtexp.Text == "" || txtdocphone.Text == "" || txtdocage.Text == "" || txtdocaddress.Text == "" || combodocgender.Text == "" || combodocbloodgroup.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                d.ID = txtid.Text;
                d.Name = txtname.Text;
                d.Salary = txtsalary.Text;
                d.Exp = txtexp.Text;
                d.Phone = txtdocphone.Text;
                d.Age = txtdocage.Text;
                d.Address = txtdocaddress.Text;
                d.Gender = combodocgender.Text;
                d.Blood = combodocbloodgroup.Text;
                d.Email = ebox.Text;
                d.Password = pbox.Text;
                d.CNIC=cnicbox.Text;
                d.Specialization=specializationbox.Text;
                d.Add();

                MessageBox.Show("Doctor Data Added Successfully");
            }
            cnicbox.Text = "";
            ebox.Text = "";
            pbox.Text = "";
            txtid.Text = "";
            txtname.Text = "";
            txtsalary.Text = "";
            txtexp.Text = "";
            txtdocphone.Text = "";
            txtdocage.Text = "";
            txtdocaddress.Text = "";
            combodocgender.Text = "";
            combodocbloodgroup.Text = "";
            specializationbox.Text = "";
            connect.Close();
            populate();
        }

        private void btnupdate_doc_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Doctor d = new Doctor();
            if (txtid.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                d.ID = txtid.Text;
                d.Name = txtname.Text;
                d.Salary = txtsalary.Text;
                d.Exp = txtexp.Text;
                d.Phone = txtdocphone.Text;
                d.Age = txtdocage.Text;
                d.Address = txtdocaddress.Text;
                d.Gender = combodocgender.Text;
                d.Blood = combodocbloodgroup.Text;
                d.Email = ebox.Text;
                d.Password = pbox.Text;
                d.CNIC = cnicbox.Text;
                d.Specialization = specializationbox.Text;
                d.Update();
                connect.Close();
                MessageBox.Show("Doctor Data Update Successfully");
            }

            specializationbox.Text = "";
            cnicbox.Text = "";
            ebox.Text = "";
            pbox.Text = "";
            txtid.Text = "";
            txtname.Text = "";
            txtsalary.Text = "";
            txtexp.Text = "";
            txtdocphone.Text = "";
            txtdocage.Text = "";
            txtdocaddress.Text = "";
            combodocgender.Text = "";
            combodocbloodgroup.Text = "";
            populate();
        }
        void populate()
        {
            SqlConnection connect = connection.GetConnection();
            string query = "SELECT * FROM DoctorTable";
            SqlDataAdapter ad = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();

        }
        private void btndelete_doc_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Doctor d = new Doctor();
            if (txtid.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                d.ID = txtid.Text;
                d.Delete();
                connect.Close();
                MessageBox.Show("Doctor Data Delete Successfully");
            }
                txtid.Text = "";
            populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate(); 
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btndochome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h=new Home();
            h.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtnnn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void non_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtdocage_TextChanged(object sender, EventArgs e)
        {

        }

        private void combodocbloodgroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void combodocgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtdocaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdocphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtexp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void specializationbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

