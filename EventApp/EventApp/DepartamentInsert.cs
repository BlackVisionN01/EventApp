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
    public partial class DepartamentInsert : Form
    {
        public DepartamentInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartamentInsertButton_Click(object sender, EventArgs e)
        {
            Departament departament = new Departament
            {
                NumeDepartament = DepartamentNume.Text,
                Cod = Int32.Parse(DepartamentCod.Text),
                Program = DepartamentProgram.Text
            };
            DepartamentADO departamentADO = new DepartamentADO();
            int result = departamentADO.Insert(departament);
            DepartamentInsertLabel.Text = "The data has been added";
        }

    }
}
