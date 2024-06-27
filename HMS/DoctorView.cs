using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class DoctorView : Form
    {
        private string username;

        // Method to establish a database connection
        private SqlConnection GetConnection()
        {
            // Replace the following line with your actual implementation
            string connectionString = "Data Source=DESKTOP-AR8IVMB;Initial Catalog=Project_HMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }

        private Doctor GetDoctorInformationByUsername(string username)
        {
            Doctor doctor = null;
            string query = "SELECT * FROM doctortable d JOIN doctorpersonalinfo dp ON d.id = dp.id WHERE email = @Username";

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            doctor = new Doctor
                            {
                                ID = reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty,
                                Name = reader["NAME"] != DBNull.Value ? reader["NAME"].ToString() : string.Empty,
                                Salary = reader["SALARY"] != DBNull.Value ? reader["SALARY"].ToString() : string.Empty,
                                Exp = reader["EXPERIENCE"] != DBNull.Value ? reader["EXPERIENCE"].ToString() : string.Empty,
                                Phone = reader["PHONE"] != DBNull.Value ? reader["PHONE"].ToString() : string.Empty,
                                Age = reader["AGE"] != DBNull.Value ? reader["AGE"].ToString() : string.Empty,
                                Address = reader["ADDRESS"] != DBNull.Value ? reader["ADDRESS"].ToString() : string.Empty,
                                Gender = reader["GENDER"] != DBNull.Value ? reader["GENDER"].ToString() : string.Empty,
                                Blood = reader["BLOOD_GROUP"] != DBNull.Value ? reader["BLOOD_GROUP"].ToString() : string.Empty,
                                Email = reader["EMAIL"] != DBNull.Value ? reader["EMAIL"].ToString() : string.Empty,
                                Password = reader["PASSWORD"] != DBNull.Value ? reader["PASSWORD"].ToString() : string.Empty,
                                CNIC = reader["CNIC"] != DBNull.Value ? reader["CNIC"].ToString() : string.Empty
                            };
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while retrieving doctor information: {ex.Message}\nStackTrace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return doctor;
        }


        private void LoadDoctorInformation()
        {
            Doctor doctor = GetDoctorInformationByUsername(username);

            if (doctor != null)
            {
                txtidd.Text = doctor.ID;
                txtnamee.Text = doctor.Name;
                txtsalaryy.Text = doctor.Salary;
                txtdocphonee.Text = doctor.Phone;
                txtdocaddresss.Text = doctor.Address;
                txtdocagee.Text = doctor.Age;
                txtexpp.Text = doctor.Exp;
                eboxx.Text = doctor.Email;
                pboxx.Text = doctor.Password;
                combodocgenderr.Text = doctor.Gender;
                combodocbloodgroupp.Text = doctor.Blood;
                cnicboxx.Text = doctor.CNIC; // Set CNIC text box
            }
        }


        public DoctorView()
        {
           
        }

        public DoctorView(string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
            this.username = username;
            // Load the doctor's information using the username
            LoadDoctorInformation();
        }

        private void DoctorView_Load(object sender, EventArgs e)
        {
            // Implement any additional initialization logic here
        }
        private void txtidd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnamee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsalaryy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdocphonee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdocaddresss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdocagee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtexpp_TextChanged(object sender, EventArgs e)
        {

        }

        private void eboxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pboxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void combodocgenderr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combodocbloodgroupp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backbtnnnnn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAs ap = new LoginAs();
            ap.Show();
        }

        private void YourPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocPatients docPatient = new DocPatients(username);
            docPatient.Show();
        }

        private void cnicboxx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

