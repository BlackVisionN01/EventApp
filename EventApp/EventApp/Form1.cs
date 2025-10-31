using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EventApp
{
    public partial class Form1 : Form
    {
        BindingSource DataBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            string selectedTable;

            if (listBox1.SelectedItem == null)
            {
                selectedTable = null;
            }
            else
            {
                selectedTable = listBox1.SelectedItem.ToString();
                label1.Text = "";
            }

            string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
                " Integrated Security=True; TrustServerCertificate=True;";

            SqlConnection con = new SqlConnection(connectstring);
            con.Open();

            switch (selectedTable)
            {
                case "Client":
                    string SQLQuery1 = "SELECT * FROM Client;";
                    SqlCommand sc1 = new SqlCommand(SQLQuery1, con);
                    List<Client> ex1 = new List<Client>();
                    using (SqlDataReader reader = sc1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client c = new Client
                            {
                                ClientID = reader.GetInt32(0),
                                Nume = reader.GetString(1),
                                Prenume = reader.GetString(2),
                                Email = reader.GetString(3),
                                Telefon = reader.GetString(4)
                            };
                            ex1.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex1;
                    dataGridView1.DataSource = ex1;
                    break;

                case "Eveniment":
                    string SQLQuery2 = "SELECT Categorie, Durata, Tematica FROM Eveniment;";
                    SqlCommand sc2 = new SqlCommand(SQLQuery2, con);
                    List<Eveniment> ex2 = new List<Eveniment>();
                    using (SqlDataReader reader = sc2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Eveniment c = new Eveniment
                            {
                                Categorie = reader.GetString(0),
                                Durata = reader.GetInt32(1),
                                Tematica = reader.GetString(2)
                            };
                            ex2.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex2;
                    dataGridView1.DataSource = ex2;
                    break;

                case "EvenimentClient":
                    string SQLQuery3 = "SELECT Data, Observatii FROM EvenimentClient;";
                    SqlCommand sc3 = new SqlCommand(SQLQuery3, con);
                    List<EvenimentClient> ex3 = new List<EvenimentClient>();
                    using (SqlDataReader reader = sc3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EvenimentClient c = new EvenimentClient
                            {
                                Data = reader.GetDateTime(0),
                                Observatii = reader.IsDBNull(1) ? null : reader.GetString(1)
                            };
                            ex3.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex3;
                    dataGridView1.DataSource = ex3;
                    break;

                case "Locatie":
                    string SQLQuery4 = "SELECT Adresa, Capacitate, Pret, Review FROM Locatie;";
                    SqlCommand sc4 = new SqlCommand(SQLQuery4, con);
                    List<Locatie> ex4 = new List<Locatie>();
                    using (SqlDataReader reader = sc4.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Locatie c = new Locatie
                            {
                                Adresa = reader.GetString(0),
                                Capacitate = reader.GetInt32(1),
                                Pret = reader.GetSqlDecimal(2).ToDouble(),
                                Review = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                            ex4.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex4;
                    dataGridView1.DataSource = ex4;
                    break;

                case "EvenimentLocatie":
                    string SQLQuery5 = "SELECT Data, Observatii FROM EvenimentLocatie;";
                    SqlCommand sc5 = new SqlCommand(SQLQuery5, con);
                    List<EvenimentLocatie> ex5 = new List<EvenimentLocatie>();
                    using (SqlDataReader reader = sc5.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EvenimentLocatie c = new EvenimentLocatie
                            {
                                Data = reader.GetDateTime(0),
                                Observatii = reader.IsDBNull(1) ? null : reader.GetString(1),
                            };
                            ex5.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex5;
                    dataGridView1.DataSource = ex5;
                    break;

                case "Departament":
                    string SQLQuery6 = "SELECT * FROM Departament;";
                    SqlCommand sc6 = new SqlCommand(SQLQuery6, con);
                    List<Departament> ex6 = new List<Departament>();
                    using (SqlDataReader reader = sc6.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Departament c = new Departament
                            {
                                DepartamentID = reader.GetInt32(0),
                                NumeDepartament = reader.GetString(1),
                                Cod = reader.GetInt32(2),
                                Program = reader.GetString(3)
                            };
                            ex6.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex6;
                    dataGridView1.DataSource = ex6;
                    break;

                case "Angajat":
                    string SQLQuery7 = "SELECT NumeAngajat, PrenumeAngajat, EmailAngajat, TelefonAngajat, Sex FROM Angajat;";
                    SqlCommand sc7 = new SqlCommand(SQLQuery7, con);
                    List<Angajat> ex7 = new List<Angajat>();
                    using (SqlDataReader reader = sc7.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Angajat c = new Angajat
                            {
                                NumeAngajat = reader.GetString(0),
                                PrenumeAngajat = reader.GetString(1),
                                EmailAngajat = reader.GetString(2),
                                TelefonAngajat = reader.GetString(3),
                                Sex = reader.GetString(4)
                            };
                            ex7.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex7;
                    dataGridView1.DataSource = ex7;
                    break;

                case "Sponsor":
                    string SQLQuery8 = "SELECT NumeSponsor, Categorie, Suma FROM Sponsor;";
                    SqlCommand sc8 = new SqlCommand(SQLQuery8, con);
                    List<Sponsor> ex8 = new List<Sponsor>();
                    using (SqlDataReader reader = sc8.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sponsor c = new Sponsor
                            {
                                NumeSponsor = reader.GetString(0),
                                Categorie = reader.GetString(1),
                                Suma = reader.GetSqlDecimal(2).ToDouble()
                            };
                            ex8.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex8;
                    dataGridView1.DataSource = ex8;
                    break;

                case "EvenimentSponsor":
                    string SQLQuery9 = "SELECT Data, Observatii FROM EvenimentSponsor;";
                    SqlCommand sc9 = new SqlCommand(SQLQuery9, con);
                    List<EvenimentSponsor> ex9 = new List<EvenimentSponsor>();
                    using (SqlDataReader reader = sc9.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EvenimentSponsor c = new EvenimentSponsor
                            {
                                Data = reader.GetDateTime(0),
                                Observatii = reader.IsDBNull(1) ? null : reader.GetString(1)
                            };
                            ex9.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex9;
                    dataGridView1.DataSource = ex9;
                    break;

                case "Furnizor":
                    string SQLQuery10 = "SELECT Tip, CantitateFurnizor, PretFurnizor FROM Furnizor;";
                    SqlCommand sc10 = new SqlCommand(SQLQuery10, con);
                    List<Furnizor> ex10 = new List<Furnizor>();
                    using (SqlDataReader reader = sc10.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furnizor c = new Furnizor
                            {
                                Tip = reader.GetString(0),
                                CantitateFurnizor = reader.GetInt32(1),
                                PretFurnizor = reader.GetSqlDecimal(2).ToDouble(),
                            };
                            ex10.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex10;
                    dataGridView1.DataSource = ex10;
                    break;

                case "EvenimentFurnizor":
                    string SQLQuery11 = "SELECT Data, Observatii FROM EvenimentFurnizor;";
                    SqlCommand sc11 = new SqlCommand(SQLQuery11, con);
                    List<EvenimentFurnizor> ex11 = new List<EvenimentFurnizor>();
                    using (SqlDataReader reader = sc11.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EvenimentFurnizor c = new EvenimentFurnizor
                            {
                                Data = reader.GetDateTime(0),
                                Observatii = reader.IsDBNull(1) ? null : reader.GetString(1)
                            };
                            ex11.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex11;
                    dataGridView1.DataSource = ex11;
                    break;

                default:
                    label1.Text = "Alegeti una din optiunile din lista";
                    break;

            }
            con.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ClientInsert clientInsert = new ClientInsert();
            clientInsert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartamentInsert departamentInsert = new DepartamentInsert();
            departamentInsert.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            string selectedTable;

            if (listBox1.SelectedItem == null)
            {
                selectedTable = null;
            }
            else
            {
                selectedTable = listBox1.SelectedItem.ToString();
                label1.Text = "";
            }

            switch (selectedTable)
            {
                case "Client":
                    int clientID = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["ClientID"].Value);
                    ClientUpdate clientUpdate = new ClientUpdate();
                    clientUpdate.ClientID = clientID;
                    clientUpdate.IsUpdated = true;
                    clientUpdate.Show();
                    break;

                case "Departament":
                    int departamentID = Convert.ToInt16(dataGridView1.Rows[selectedRow].Cells["DepartamentID"].Value);
                    DepartamentUpdate departamentUpdate = new DepartamentUpdate();
                    departamentUpdate.DepartamentID = departamentID;
                    departamentUpdate.IsUpdated = true;
                    departamentUpdate.Show();
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTable;

            if (listBox2.SelectedItem == null)
            {
                selectedTable = null;
            }
            else
            {
                selectedTable = listBox2.SelectedItem.ToString();
                label1.Text = "";
            }

            string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
                " Integrated Security=True; TrustServerCertificate=True;";

            SqlConnection con = new SqlConnection(connectstring);
            con.Open();
            //string SQLQuery = "SELECT * FROM " + selectedTable;

            switch (selectedTable)
            {
                case "Lista clientilor si evenimentelor la care participa":
                    List<interog1> ex1 = new List<interog1>();

                    string query1 = "SELECT C.Nume AS NumeClient, C.Prenume AS PrenumeClient, E.Tematica AS Eveniment, EC.Data AS DataParticipare " +
                        "FROM Client C JOIN EvenimentClient EC ON C.ClientID = EC.ClientID JOIN Eveniment E ON EC.EvenimentID = E.EvenimentID ";
                    SqlCommand sc1 = new SqlCommand(query1, con);
                    using (SqlDataReader reader = sc1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            interog1 c = new interog1
                            {
                                NumeClient = reader.GetString(0),
                                PrenumeClient = reader.GetString(1),
                                Eveniment = reader.GetString(2),
                                Data = reader.GetDateTime(3)
                            };
                            ex1.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex1;
                    dataGridView1.DataSource = ex1;
                    break;

                case "Evenimentele si locatiile unde au avut loc, cu observatii":
                    List<interog2> ex2 = new List<interog2>();

                    string query2 = "SELECT E.Tematica, L.Adresa, EL.Data, EL.Observatii FROM Eveniment E " +
                        "JOIN EvenimentLocatie EL ON E.EvenimentID = EL.EvenimentID JOIN Locatie L ON EL.LocatieID = L.LocatieID;";
                    SqlCommand sc2 = new SqlCommand(query2, con);
                    using (SqlDataReader reader = sc2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            interog2 c = new interog2
                            {
                                Eveniment = reader.GetString(0),
                                Locatie = reader.GetString(1),
                                Data = reader.GetDateTime(2),
                                Observatii = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                            ex2.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex2;
                    dataGridView1.DataSource = ex2;
                    break;

                case "Angajatii alocati evenimentelor si departamentelor lor":
                    List<interog3> ex3 = new List<interog3>();

                    string query3 = "SELECT A.NumeAngajat, A.PrenumeAngajat, D.NumeDepartament, E.Tematica FROM Angajat A " +
                        "JOIN Departament D ON A.DepartamentID = D.DepartamentID JOIN Eveniment E ON A.EvenimentID = E.EvenimentID;";
                    SqlCommand sc3 = new SqlCommand(query3, con);
                    using (SqlDataReader reader = sc3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            interog3 c = new interog3
                            {
                                Nume = reader.GetString(0),
                                Prenume = reader.GetString(1),
                                NumeDepartament = reader.GetString(2),
                                Eveniment = reader.GetString(3)
                            };
                            ex3.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex3;
                    dataGridView1.DataSource = ex3;
                    break;

                case "Sponsori pentru fiecare eveniment":
                    List<interog4> ex4 = new List<interog4>();

                    string query4 = "SELECT E.Tematica, S.NumeSponsor, ES.Data, ES.Observatii FROM EvenimentSponsor ES " +
                        "JOIN Eveniment E ON ES.EvenimentID = E.EvenimentID JOIN Sponsor S ON ES.SponsorID = S.SponsorID;";
                    SqlCommand sc4 = new SqlCommand(query4, con);
                    using (SqlDataReader reader = sc4.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            interog4 c = new interog4
                            {
                                Eveniment = reader.GetString(0),
                                Sponsor = reader.GetString(1),
                                Data = reader.GetDateTime(2),
                                Observatii = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                            ex4.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex4;
                    dataGridView1.DataSource = ex4;
                    break;

                case "Furnizorii alocati fiecarui eveniment":
                    List<interog5> ex5 = new List<interog5>();

                    string query5 = "SELECT E.Tematica, F.Tip, EF.Data, EF.Observatii FROM EvenimentFurnizor EF " +
                        "JOIN Eveniment E ON EF.EvenimentID = E.EvenimentID JOIN Furnizor F ON EF.FurnizorID = F.FurnizorID;";
                    SqlCommand sc5 = new SqlCommand(query5, con);
                    using (SqlDataReader reader = sc5.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            interog5 c = new interog5
                            {
                                Eveniment = reader.GetString(0),
                                Tip = reader.GetString(1),
                                Data = reader.GetDateTime(2),
                                Observatii = reader.IsDBNull(3) ? null : reader.GetString(3)
                            };
                            ex5.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex5;
                    dataGridView1.DataSource = ex5;
                    break;

                case "Evenimente unde suma furnizorilor depaseste 10.000":
                    List<interog6> ex6 = new List<interog6>();

                    string query6 = "SELECT E.Tematica AS Eveniment, SUM(F.PretFurnizor) AS TotalFurnizori " +
                        "FROM Eveniment E JOIN EvenimentFurnizor EF ON E.EvenimentID = EF.EvenimentID " +
                        "JOIN Furnizor F ON EF.FurnizorID = F.FurnizorID GROUP BY E.Tematica HAVING SUM(F.PretFurnizor) > 10000;";
                    SqlCommand sc6 = new SqlCommand(query6, con);
                    using (SqlDataReader reader = sc6.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            interog6 c = new interog6
                            {
                                Eveniment = reader.GetString(0),
                                TotalFurnizor = reader.GetDecimal(1),
                            };
                            ex6.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex6;
                    dataGridView1.DataSource = ex6;
                    break;
            }
            con.Close();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            string selectedTable;

            if (listBox3.SelectedItem == null)
            {
                selectedTable = null;
            }
            else
            {
                selectedTable = listBox3.SelectedItem.ToString();
                label1.Text = "";
            }

            string connectstring = "Data Source=DESKTOP-042BJD5\\SQLEXPRESS; Initial Catalog=Aplicatie;" +
                " Integrated Security=True; TrustServerCertificate=True;";

            SqlConnection con = new SqlConnection(connectstring);
            con.Open();
            //string SQLQuery = "SELECT * FROM " + selectedTable;

            switch (selectedTable)
            {
                case "Clienti care participa la cele mai multe evenimente":
                    List<complex1> ex1 = new List<complex1>();

                    string query1 = "SELECT C.Nume, C.Prenume, COUNT(EC.EvenimentID) AS NumarEvenimente " +
                        "FROM Client C JOIN EvenimentClient EC ON C.ClientID = EC.ClientID " +
                        "GROUP BY C.ClientID, C.Nume, C.Prenume HAVING COUNT(EC.EvenimentID) = " +
                        "(SELECT MAX(Numar) FROM (SELECT COUNT(EvenimentID) AS Numar FROM EvenimentClient GROUP BY ClientID) AS SubQuery);";
                    SqlCommand sc1 = new SqlCommand(query1, con);
                    using (SqlDataReader reader = sc1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            complex1 c = new complex1
                            {
                                Nume = reader.GetString(0),
                                Prenume = reader.GetString(1),
                                NumarEvenimente = reader.GetInt32(2)
                            };
                            ex1.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex1;
                    dataGridView1.DataSource = ex1;
                    break;

                case "Locatiile care au gazduit cele mai multe evenimente":
                    List<complex2> ex2 = new List<complex2>();

                    string query2 = "SELECT L.Adresa, COUNT(EL.EvenimentID) AS NumarEvenimente FROM Locatie L " +
                        "JOIN EvenimentLocatie EL ON L.LocatieID = EL.LocatieID GROUP BY L.Adresa HAVING COUNT(EL.EvenimentID) = " +
                        "(SELECT MAX(Numar) FROM " +
                        "(SELECT COUNT(EvenimentID) AS Numar FROM EvenimentLocatie GROUP BY LocatieID) AS SubQuery);";
                    SqlCommand sc2 = new SqlCommand(query2, con);
                    using (SqlDataReader reader = sc2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            complex2 c = new complex2
                            {
                                Adresa = reader.GetString(0),
                                NumarEvenimente = reader.GetInt32(1),
                            };
                            ex2.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex2;
                    dataGridView1.DataSource = ex2;
                    break;

                case "Suma totala sponsorizata pentru fiecare categorie de sponsori":
                    List<complex3> ex3 = new List<complex3>();

                    string query3 = "SELECT S.Categorie, SUM(S.Suma) AS SumaTotala FROM Sponsor S " +
                        "WHERE S.SponsorID IN (SELECT SponsorID FROM EvenimentSponsor) GROUP BY S.Categorie; ";
                    SqlCommand sc3 = new SqlCommand(query3, con);
                    using (SqlDataReader reader = sc3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            complex3 c = new complex3
                            {
                                Categorie = reader.GetString(0),
                                SumaTotala = reader.GetDecimal(1)
                            };
                            ex3.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex3;
                    dataGridView1.DataSource = ex3;
                    break;

                case "Evenimentele cu cel mai mare numar de participanti ":
                    List<complex4> ex4 = new List<complex4>();

                    string query4 = "SELECT TOP 1 E.Tematica, E.Categorie, P.NumarParticipanti FROM Eveniment E " +
                        "JOIN(SELECT EC.EvenimentID, COUNT(EC.ClientID) AS NumarParticipanti FROM EvenimentClient EC GROUP BY EC.EvenimentID)" +
                        " P ON E.EvenimentID = P.EvenimentID ORDER BY P.NumarParticipanti DESC; ";
                    SqlCommand sc4 = new SqlCommand(query4, con);
                    using (SqlDataReader reader = sc4.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            complex4 c = new complex4
                            {
                                Tematica = reader.GetString(0),
                                Categorie = reader.GetString(1),
                                NumarParticipanti = reader.GetInt32(2)
                            };
                            ex4.Add(c);
                        }
                    }
                    DataBindingSource.DataSource = ex4;
                    dataGridView1.DataSource = ex4;
                    break;

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
