
using Microsoft.Data.SqlClient;

namespace EventApp
{
    internal class ClientADO
    {
        internal int Insert(Client client)
        {
            string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
                " Integrated Security=True; TrustServerCertificate=True;";

            string SQLQuery = "INSERT INTO Client (Nume, Prenume, Email, Telefon) VALUES (" +
                "@clientNume, @clientPrenume, @clientEmail, @clientTelefon);";

            SqlConnection con = new SqlConnection(connectstring);
            con.Open();
            SqlCommand sc = new SqlCommand(SQLQuery, con);

            sc.Parameters.AddWithValue("@clientNume", client.Nume);
            sc.Parameters.AddWithValue("@clientPrenume", client.Prenume);
            sc.Parameters.AddWithValue("@clientEmail", client.Telefon);
            sc.Parameters.AddWithValue("@clientTelefon", client.Email);

            int newRows = sc.ExecuteNonQuery();
            con.Close();

            return newRows;
        }
    }
}