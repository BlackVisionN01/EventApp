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
    public partial class ClientInsert : Form
    {
        public ClientInsert()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientInsertButton_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                Nume = ClientNume.Text,
                Prenume = ClientPrenume.Text,
                Telefon = ClientTelefon.Text,
                Email = ClientEmail.Text
            };

            ClientADO clientADO = new ClientADO();
            int result = clientADO.Insert(client);
            ClientInsertLabel.Text = "The data has been added";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
