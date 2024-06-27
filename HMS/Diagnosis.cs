using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HMS
{
    internal class Diagnosis:Patient
    {
        private string diag_id;
        private string medicine;
      
        private string symptoms;
        private string id;
        private string pat_name;
        private string disease;
        public Diagnosis()
        {
           
        }
        public string DIAG_ID { get { return diag_id; }set { diag_id = value; } }
        public string MEDICINE { get { return medicine; }set {medicine = value; } }
     
        public string ID { get { return id; }set { id = value; } }
        public string SYMPTOMS {get { return symptoms; }set {symptoms = value; } }
        public string PAT_NAME { get { return pat_name; }set { pat_name = value; } }
        public string PAT_Disease { get { return disease; } set { disease = value; } }

        public void InsertData()
        {
            SqlCommand cmd = connection.SqlCmd("INSERT INTO Diagnosis VALUES('"+diag_id+ "', '" + id + "','" + medicine + "','" + symptoms + "', ,'" + pat_name + "','" + disease + "'          )");
            cmd.ExecuteNonQuery();
        }
        public void Update()
        {
            SqlCommand cmd = connection.SqlCmd("UPDATE Diagnosis SET DIAGNOSIS_ID= '"+diag_id+"',PATIENT_ID='"+id+ "',MEDICINE='" + medicine + "' ,SYMPTOMS='" + symptoms + "' ,PATIENT_NAME='" + pat_name + "',PATIENT_DISEASE='" + disease + "'");                                     
            cmd.ExecuteNonQuery();
        }
        public void Delete()
        {
            SqlCommand cmd = connection.SqlCmd("DELETE FROM Diagnosis   WHERE DIAGNOSIS_ID = '" + diag_id + "' ");
            cmd.ExecuteNonQuery();
        }

    }
}
