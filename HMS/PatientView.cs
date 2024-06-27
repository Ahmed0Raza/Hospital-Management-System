using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class PatientView : Form
    {
        private string email;

        // Method to establish a database connection
        private SqlConnection GetConnection()
        {
            // Replace the following line with your actual implementation
            string connectionString = "Data Source=DESKTOP-AR8IVMB;Initial Catalog=Project_HMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }

        private Patient GetPatientInformationByEmail(string email)
        {
            Patient patient = null;
            string query = "SELECT * FROM patienttable p join patientpersonalinfo pp on p.id=pp.id  WHERE email = @Email";

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            patient = new Patient
                            {
                                ID = reader["ID"] != DBNull.Value ? reader["ID"].ToString() : string.Empty,
                                Name = reader["NAME"] != DBNull.Value ? reader["NAME"].ToString() : string.Empty,
                                Disease = reader["DISEASE"] != DBNull.Value ? reader["DISEASE"].ToString() : string.Empty,
                                Doc = reader["DOCTOR_ASSIGN"] != DBNull.Value ? reader["DOCTOR_ASSIGN"].ToString() : string.Empty,
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
                        MessageBox.Show($"An error occurred while retrieving patient information: {ex.Message}\nStackTrace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return patient;
        }

        private void LoadPatientInformation(string email)
        {
            Patient patient = GetPatientInformationByEmail(email);

            if (patient != null)
            {
                txtpatidd.Text = patient.ID;
                txtpatnamee.Text = patient.Name;
                txtpatdiseasee.Text = patient.Disease;
                txtpatdoctorassignn.Text = patient.Doc;
                txtpatphonee.Text = patient.Phone;
                txtpatagee.Text = patient.Age;
                txtpataddresss.Text = patient.Address;
                combopatgenderr.Text = patient.Gender;
                combopatbloodgroupp.Text = patient.Blood;
                ebox22.Text = patient.Email;
                pbox22.Text = patient.Password;
                cnicboxxx.Text = patient.CNIC;
            }
        }

        public PatientView(string e)
        {
            email = e;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);

            // Load the patient's information using the email
            LoadPatientInformation(email);
        }

        private void PatientView_Load(object sender, EventArgs e)
        {
            // Implement any additional initialization logic here
        }

        private void txtpatidd_TextChanged(object sender, EventArgs e) { }
        private void txtpatnamee_TextChanged(object sender, EventArgs e) { }
        private void txtpatdiseasee_TextChanged(object sender, EventArgs e) { }
        private void ebox22_TextChanged(object sender, EventArgs e) { }
        private void pbox22_TextChanged(object sender, EventArgs e) { }
        private void txtpatphonee_TextChanged(object sender, EventArgs e) { }
        private void txtpatdoctorassignn_TextChanged(object sender, EventArgs e) { }
        private void txtpatagee_TextChanged(object sender, EventArgs e) { }
        private void combopatgenderr_SelectedIndexChanged(object sender, EventArgs e) { }
        private void combopatbloodgroupp_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtpataddresss_TextChanged(object sender, EventArgs e) { }

        private void backbtnnnn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAs loginAs = new LoginAs();
            loginAs.Show();
        }

        private void appointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointmentForm = new AppointmentForm(email);
            appointmentForm.Show();
        }

        private void cnicboxxx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
