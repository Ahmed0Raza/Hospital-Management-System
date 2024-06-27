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
    public partial class DocPatients : Form
    {
        string email;
        public DocPatients()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }
        public DocPatients(string username)
        {
            InitializeComponent();
            email = username;
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }


        private void DocPatients_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = connection.GetConnection();
                string query = $"SELECT * FROM patientTable WHERE doctor_assign = (select d.id from doctortable d join doctorpersonalinfo dp on d.id=dp.id where email= '{email}' )";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView11.DataSource = dataSet.Tables[0];

                // Set the AutoSizeMode of the first column to Fill
                if (dataGridView11.Columns.Count > 0)
                {
                    dataGridView11.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GharKo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorView dv = new DoctorView(email);
            dv.Show();
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ghar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorView dv = new DoctorView(email);
            dv.Show();
        }
    }
}
