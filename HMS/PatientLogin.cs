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
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }

        private void PatientLogin_Load(object sender, EventArgs e)
        {

        }

        private void plogbtn_Click(object sender, EventArgs e)
        {
            
                string email = puser.Text;
                string password = ppass.Text;

                // Get the SqlConnection object using your custom method
                SqlConnection connect = connection.GetConnection();

                // SQL query to check if the email and password match
                string query = "SELECT COUNT(*) FROM Patienttable p join patientpersonalinfo pp on p.id=pp.id WHERE email = @Email AND password = @Password";

                try
                {

                    // Create command object
                    SqlCommand command = new SqlCommand(query, connect);

                    // Add parameters
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute scalar query to get the count of matching records
                    int count = (int)command.ExecuteScalar();

                    // Check if count is greater than 0, indicating a matching record
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        PatientView p= new PatientView(email);
                        p.Show();   
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);

                    // Log the stack trace for debugging
                    MessageBox.Show("Stack Trace: " + ex.StackTrace);
                }
                finally
                {
                    // Close connection if it's still open
                    if (connect.State == ConnectionState.Open)
                    {
                        try
                        {
                            connect.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error closing connection: " + ex.Message);
                        }
                    }
                }
            

        }

        private void puser_TextChanged(object sender, EventArgs e)
        {

        }

        private void ppass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
