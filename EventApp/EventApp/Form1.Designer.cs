namespace EventApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonTables = new Button();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonTables
            // 
            buttonTables.Location = new Point(12, 222);
            buttonTables.Name = "buttonTables";
            buttonTables.Size = new Size(171, 31);
            buttonTables.TabIndex = 0;
            buttonTables.Text = "Load Table";
            buttonTables.UseVisualStyleBackColor = true;
            buttonTables.Click += buttonTables_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(211, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(622, 204);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Client", "Eveniment", "EvenimentClient", "Locatie", "EvenimentLocatie", "Departament", "Angajat", "Sponsor", "EvenimentSponsor", "Furnizor", "EvenimentFurnizor" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 204);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 265);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(211, 224);
            button2.Name = "button2";
            button2.Size = new Size(308, 29);
            button2.TabIndex = 5;
            button2.Text = "Insert Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(525, 224);
            button3.Name = "button3";
            button3.Size = new Size(308, 29);
            button3.TabIndex = 7;
            button3.Text = "Insert Departament";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Items.AddRange(new object[] { "Lista clientilor si evenimentelor la care participa", "Evenimentele si locatiile unde au avut loc, cu observatii", "Angajatii alocati evenimentelor si departamentelor lor", "Sponsori pentru fiecare eveniment", "Furnizorii alocati fiecarui eveniment", "Evenimentele unde suma furnizata depaseste 10.000" });
            listBox2.Location = new Point(12, 294);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(378, 124);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Items.AddRange(new object[] { "Clienti care participa la cele mai multe evenimente", "Locatiile care au gazduit cele mai multe evenimente", "Suma totala sponsorizata pentru fiecare categorie de sponsori", "Evenimentele cu cel mai mare numar de participanti " });
            listBox3.Location = new Point(396, 292);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(437, 84);
            listBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(396, 382);
            button1.Name = "button1";
            button1.Size = new Size(171, 31);
            button1.TabIndex = 10;
            button1.Text = "Simple Interogation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(662, 382);
            button4.Name = "button4";
            button4.Size = new Size(171, 31);
            button4.TabIndex = 11;
            button4.Text = "Complex Interogation";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonTables);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTables;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button1;
        private Button button4;
    }
}
