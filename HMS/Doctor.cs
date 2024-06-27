using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Lifetime;

namespace HMS
{
    class Doctor: Person
    {
        private string exp;
        private string salary;
        private string email;
        private string password;
        private string specialization;
        public Doctor() { }

        public Doctor(string id, string name, string exp, string salary, string email, string password, string specialization)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.exp = exp;
            this.email = email;
            this.password = password;
            this.specialization = specialization;
        }

        public string Exp { get { return exp; } set { exp = value; } }
        public string Salary { get { return salary; } set { salary = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Specialization { get { return specialization; } set { specialization = value; } }

        public override void Add()
        {
            string query = "INSERT INTO DoctorTable (id, name, salary, experience, specialization) VALUES ('" + id + "', '" + name + "', '" + salary + "', '" + exp + "', '" + specialization+ "')";
            SqlCommand cmd = connection.SqlCmd(query);
            cmd.ExecuteNonQuery();
            string query2 = "INSERT INTO DoctorPersonalInfo (cnic, id, phone, age, address, gender, blood_group, email, password) VALUES ('" + cnic + "', '" + id + "', '" + phone + "', '" + age + "', '" + address + "', '" + gender + "', '" + bloodgroup + "', '" + email + "', '" + password + "')";
            SqlCommand cmd2 = connection.SqlCmd(query2);
            cmd2.ExecuteNonQuery();
        }
        public override void Update()
        {
          
            string updateQuery1 = "UPDATE DoctorTable SET name = '" + name + "', salary = '" + salary + "', experience = '" + exp + "', specialization = '" + specialization + "' WHERE id = '" + id + "'";
            SqlCommand cmd1 = connection.SqlCmd(updateQuery1);
            cmd1.ExecuteNonQuery();

            string updateQuery2 = "UPDATE DoctorPersonalInfo SET cnic = '" + cnic + "', phone = '" + phone + "', age = '" + age + "', address = '" + address + "', gender = '" + gender + "', blood_group = '" + bloodgroup + "', email = '" + email + "', password = '" + password + "' WHERE id = '" + id + "'";
            SqlCommand cmd2 = connection.SqlCmd(updateQuery2);
            cmd2.ExecuteNonQuery();

        }

        public override void Delete()
        {

            SqlCommand cmd = connection.SqlCmd("DELETE FROM DoctorTable   WHERE ID='" + id + "' ");
            cmd.ExecuteNonQuery();
        }

    
        }
    }

