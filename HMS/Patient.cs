using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HMS
{
    class Patient: Person
    {
        private string disease;
        private string doctor;
        private string email;
        private string password;

        public string Doc { get { return doctor; } set { doctor = value; } }
        public string Disease { get { return disease; } set { disease = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }

        public override void Add()
        {
            //SqlCommand cmd = connection.SqlCmd("INSERT INTO Patient VALUES('" + id + "', '" + name + "', '" + disease + "', '" + doctor + "', '" + phone + "', '" + age + "', '" + address + "', '" + gender + "', '" + bloodgroup + "', '" + email + "', '" + password + "');");
            string query = "INSERT INTO PatientTable (id, name, doctor_assign, disease) VALUES ('" + id + "', '" + name + "', '" + doctor + "', '" + disease + "')";
            SqlCommand cmd = connection.SqlCmd(query);
            cmd.ExecuteNonQuery();
            string query2 = "INSERT INTO PatientPersonalInfo (cnic, id, phone, age, address, gender, blood_group, email, password) VALUES ('" + cnic + "', '" + id + "', '" + phone + "', '" + age + "', '" + address + "', '" + gender + "', '" + bloodgroup + "', '" + email + "', '" + password + "')";
            SqlCommand cmd2 = connection.SqlCmd(query2);
            cmd2.ExecuteNonQuery();

        }

        public override void Update()
        {
            // Update PatientTable
            string updateQuery1 = "UPDATE PatientTable SET name = '" + name + "', doctor_assign = '" + doctor + "', disease = '" + disease + "' WHERE id = '" + id + "'";
            SqlCommand cmd1 = connection.SqlCmd(updateQuery1);
            cmd1.ExecuteNonQuery();

            // Update PatientPersonalInfo
            string updateQuery2 = "UPDATE PatientPersonalInfo SET cnic = '" + cnic + "', phone = '" + phone + "', age = '" + age + "', address = '" + address + "', gender = '" + gender + "', blood_group = '" + bloodgroup + "', email = '" + email + "', password = '" + password + "' WHERE id = '" + id + "'";
            SqlCommand cmd2 = connection.SqlCmd(updateQuery2);
            cmd2.ExecuteNonQuery();

        }

        public override void Delete()
        {
            SqlCommand cmd = connection.SqlCmd("DELETE FROM PatientTable   WHERE ID='" + id + "' ");
            cmd.ExecuteNonQuery();

        }

       
        }

    }

