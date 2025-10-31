using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class ClientUpdate : Form
    {
        public ClientUpdate()
        {
            InitializeComponent();
        }

        string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
                " Integrated Security=True; TrustServerCertificate=True;";

        private int _clientID = 0;
        private bool _isUpdated = false;

        public int ClientID
        {
            get; set;
        }

        public bool IsUpdated
        {
            get; set;
        }

        private void ClientUpdate_Load(object sender, EventArgs e)
        {
            if (this.IsUpdated)
            {
                DataTable studentRecord = LoadDataUpdate();
                DataRow row = studentRecord.Rows[0];
                ClientNume.Text = row["Nume"].ToString();
                ClientPrenume.Text = row["Prenume"].ToString();
                ClientTelefon.Text = row["Telefon"].ToString();
                ClientEmail.Text = row["Email"].ToString();

            }
            ClientUpdateLabel.Text = "";
        }

        private DataTable LoadDataUpdate()
        {
            DataTable clientRecord = new DataTable();
            string queryString = "SELECT ClientID, Nume, Prenume, Email, Telefon FROM Client WHERE ClientID = " + ClientID + ";";
            using (SqlConnection sqlConnection = new SqlConnection(connectstring))
            {
                using (SqlCommand command = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    clientRecord.Load(reader);
                }
            }
            return clientRecord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientUpdateButton_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE Client SET Nume = @clientNume, Prenume = @clientPrenume, Email = @clientEmail, Telefon = @clientTelefon WHERE ClientID = @clientID;";
            using (SqlConnection sqlConnection = new SqlConnection(connectstring))
            {
                using (SqlCommand command = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    command.Parameters.AddWithValue("@clientNume", ClientNume.Text.ToString());
                    command.Parameters.AddWithValue("@clientPrenume", ClientPrenume.Text.ToString());
                    command.Parameters.AddWithValue("@clientEmail", ClientEmail.Text.ToString());
                    command.Parameters.AddWithValue("@clientTelefon", ClientTelefon.Text.ToString());
                    command.Parameters.AddWithValue("@clientID", ClientID.ToString());
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
            ClientUpdateLabel.Text = "The data has been updated";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable clientRecord = new DataTable();
            string queryString = "DELETE FROM Client WHERE ClientID = @clientID;";
            using (SqlConnection sqlConnection = new SqlConnection(connectstring))
            {
                using (SqlCommand command = new SqlCommand(queryString, sqlConnection))
                {
                    sqlConnection.Open();
                    command.Parameters.AddWithValue("@clientID", ClientID);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
            ClientUpdateLabel.Text = "The data has been deleted";
        }

    }
}
