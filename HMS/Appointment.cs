using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    internal class Appointment
    {
        private string patientId;
        private string doctorId;

        public string PatientId { get { return patientId; } set { patientId = value; } }
        public string DoctorId { get { return doctorId; } set { doctorId = value; } }

        public void Add()
        {
            string query = "INSERT INTO Appointment (patient_id, doctor_id) VALUES (@PatientId, @DoctorId)";

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    command.Parameters.AddWithValue("@DoctorId", doctorId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while adding appointment: " + ex.Message);
                    }
                }
            }
        }

        // Method to establish a database connection
        private SqlConnection GetConnection()
        {
            // Replace the following line with your actual implementation
            string connectionString = "Data Source=DESKTOP-AR8IVMB;Initial Catalog=Project_HMS;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }
    }
}
