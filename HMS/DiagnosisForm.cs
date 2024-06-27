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
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        public static SqlDataReader getID()
        {
            SqlConnection connect = connection.GetConnection();
            string query = "select ID from Patient;";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader myReader = cmd.ExecuteReader();
            return myReader;
        }
   
        public static SqlDataReader getNameDept(int id)
        {
            SqlConnection connect = connection.GetConnection();
            string query = "select NAME, DISEASE from Patient where ID = " + id + ";";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader myReader = cmd.ExecuteReader();
            return myReader;
        }
        void populate()
        {
            SqlConnection connect = connection.GetConnection();
            string query = "SELECT * FROM Diagnosis";
            SqlDataAdapter ad = new SqlDataAdapter(query, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();

        }
        private void btndochome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h=new Home();
            h.Show();
        }

        private void combo_pat_id_SelectedIndexChanged(object sender, EventArgs e)
        {
           int ID = int.Parse(combo_pat_id.SelectedItem.ToString());
            SqlDataReader myReader =getNameDept(ID);
            while (myReader.Read())
            {
                txtdaig_patname.Text = myReader[0].ToString();
                txtdiag_patdisease.Text = myReader[1].ToString();
            }
        }
       

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populate();
            SqlDataReader myReader = getID();
            while (myReader.Read())
            {
                combo_pat_id.Items.Add(myReader[0].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_diag_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Diagnosis d = new Diagnosis();
            if (txtdiagid.Text == "" || combo_pat_id.Text == "" || txtdaig_patname.Text == "" || txtdiag_patdisease.Text == "" || txtmedicine.Text == "" || txtdiagsymptoms.Text == "") 
            {
                MessageBox.Show("Please Fill All The Fields");

            }
            
            else
            {
                d.DIAG_ID = txtdiagid.Text;
                d.ID = combo_pat_id.Text;
               
                d.MEDICINE= txtmedicine.Text;
                d.SYMPTOMS = txtdiagsymptoms.Text;
                d.PAT_NAME = txtdaig_patname.Text;
                d.PAT_Disease = txtdiag_patdisease.Text;
                d.InsertData();

                MessageBox.Show("Patient Diagnosis Data Added Successfully");
            }
            txtdiagid.Text = "";
                combo_pat_id.Text ="";
            txtmedicine.Text= "";
            txtdiagsymptoms.Text ="";
            txtdaig_patname.Text ="";
            txtdiag_patdisease.Text ="";
            connect.Close();
            populate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void btnupdate_diag_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Diagnosis d = new Diagnosis();
            if (txtdiagid.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                d.DIAG_ID = txtdiagid.Text;
                d.ID = combo_pat_id.Text;

                d.MEDICINE = txtmedicine.Text;
                d.SYMPTOMS = txtdiagsymptoms.Text;
                d.PAT_NAME = txtdaig_patname.Text;
                d.PAT_Disease = txtdiag_patdisease.Text;
                d.Update();

                MessageBox.Show("Patient Diagnosis Data Update Successfully");
            }
            txtdiagid.Text = "";
            combo_pat_id.Text = "";
            txtmedicine.Text = "";
            txtdiagsymptoms.Text = "";
            txtdaig_patname.Text = "";
            txtdiag_patdisease.Text = "";
            connect.Close();
            populate();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection connect = connection.GetConnection();
            Diagnosis d = new Diagnosis();
            if (txtdiagid.Text == "")
            {
                MessageBox.Show("Please enter the ID");
            }
            else
            {
                d.DIAG_ID = txtdiagid.Text;
                d.Delete();
                connect.Close();
                MessageBox.Show("Patient Diagnosis Data Delete Successfully");
            }
            txtdiagid.Text = "";
            populate();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    }

