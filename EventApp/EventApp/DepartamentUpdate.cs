using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class DepartamentUpdate : Form
    {
        public DepartamentUpdate()
        {
            InitializeComponent();
        }

        string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
               " Integrated Security=True; TrustServerCertificate=True;";

        private int _departamentID = 0;
        private bool _isUpdated = false;

        public int DepartamentID
        {
            get; set;
        }

        public bool IsUpdated
        {
            get; set;
        }

        private void DepartamentUpdate_Load(object sender, EventArgs e)
        {
            if (this.IsUpdated)
            {
                DataTable departamentRecord = LoadDataUpdate();
                DataRow row = departamentRecord.Rows[0];
                DepartamentNume.Text = row["NumeDepartament"].ToString();
                DepartamentCod.Text = row["Cod"].ToString();
                DepartamentProgram.Text = row["Program"].ToString();

            }
            DepartamentUpdateLabel.Text = "";

        }

        private DataTable LoadDataUpdate()
        {
            DataTable departamentRecord = new DataTable();
            string queryString = "SELECT DepartamentID, NumeDepartament, Cod, Program FROM Departament WHERE DepartamentID = @departamentID;";
            using (SqlConnection sqlConnection = new SqlConnection(connectstring))
            {
                using (SqlCommand command = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    command.Parameters.AddWithValue("@departamentID", DepartamentID);
                    SqlDataReader reader = command.ExecuteReader();
                    departamentRecord.Load(reader);

                }
            }
            return departamentRecord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartamentUpdateButton_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE Departament SET NumeDepartament = @departamentNume, Cod = @departamentCod, Program = @departamentProgram WHERE DepartamentID = " + DepartamentID + ";";
            using (SqlConnection sqlConnection = new SqlConnection(connectstring))
            {
                using (SqlCommand command = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    command.Parameters.AddWithValue("@departamentNume", DepartamentNume.Text.ToString());
                    command.Parameters.AddWithValue("@departamentCod", DepartamentCod.Text.ToString());
                    command.Parameters.AddWithValue("@departamentProgram", DepartamentProgram.Text.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
            DepartamentUpdateLabel.Text = "The data has been updated";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryString = "DELETE FROM Departament WHERE DepartamentID = @departamentID;";
            using (SqlConnection sqlConnection = new SqlConnection(connectstring))
            {
                using (SqlCommand command = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    command.Parameters.AddWithValue("@departamentID", DepartamentID);
                    SqlDataReader reader = command.ExecuteReader();

                }
            }
            DepartamentUpdateLabel.Text = "The data has been deleted";
        }

    }
}
