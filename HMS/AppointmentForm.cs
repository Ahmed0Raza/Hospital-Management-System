using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class AppointmentForm : Form
    {
        string email;
        string docid;
        string patid;
        public AppointmentForm(string e)
        {
            email = e;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            // Fill dataGridView100 with data from the doctor table
            SqlConnection connect = connection.GetConnection();
            string query = "SELECT id, name, specialization FROM doctortable"; // Selecting id and name from the doctor table
            SqlDataAdapter ad = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView100.DataSource = ds.Tables[0];

            // Set the AutoSizeMode property of the column to Fill
            dataGridView100.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            connect.Close();
        }


        private void gharko_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientView doctorView = new PatientView(email);
            doctorView.Show();
        }

        private void dataGridView100_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            docid = Doc_Id.Text;
            patid = Pat_Id.Text;

            Appointment appointment = new Appointment();

            appointment.DoctorId = docid;
            appointment.PatientId = patid;
            appointment.Add();
            MessageBox.Show("Appointment added successfully!");
        }

    }
}
