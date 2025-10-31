
using Microsoft.Data.SqlClient;

namespace EventApp
{
    internal class DepartamentADO
    {
        internal int Insert(Departament departament)
        {
            string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
                " Integrated Security=True; TrustServerCertificate=True;";

            string SQLQuery = "INSERT INTO Departament (NumeDepartament, Cod, Program) VALUES (" +
                "@departamentNume, @departamentCod, @departamentProgram);";

            SqlConnection con = new SqlConnection(connectstring);
            con.Open();
            SqlCommand sc = new SqlCommand(SQLQuery, con);

            sc.Parameters.AddWithValue("@departamentNume", departament.NumeDepartament);
            sc.Parameters.AddWithValue("@departamentCod", departament.Cod);
            sc.Parameters.AddWithValue("@departamentProgram", departament.Program);

            int newRows = sc.ExecuteNonQuery();
            con.Close();

            return newRows;
        }
    }
}