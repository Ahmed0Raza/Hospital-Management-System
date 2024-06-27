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
    public partial class DocList : Form
    {
        public DocList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove the default border

            // Set the background color to create a border effect (adjust padding for desired border width)
            this.BackColor = Color.FromArgb(170, 85, 210); // Same purple shade as before
            this.Padding = new Padding(5);
        }

        private void DocList_Load(object sender, EventArgs e)
        {
                SqlConnection connect = connection.GetConnection();
                string query = "SELECT * FROM Doctortable join doctorpersonalinfo on Doctortable.id=doctorpersonalinfo.id";
                SqlDataAdapter ad = new SqlDataAdapter(query, connect);
                SqlCommandBuilder builder = new SqlCommandBuilder(ad);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connect.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home p = new Home();
            p.Show();
        }
    }

}
