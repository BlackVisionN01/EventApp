namespace EventApp
{
    partial class ClientInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClientInsertGroup = new GroupBox();
            button1 = new Button();
            ClientInsertButton = new Button();
            ClientTelefon = new TextBox();
            label4 = new Label();
            ClientEmail = new TextBox();
            label3 = new Label();
            ClientPrenume = new TextBox();
            label2 = new Label();
            ClientNume = new TextBox();
            label1 = new Label();
            ClientInsertLabel = new Label();
            ClientInsertGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ClientInsertGroup
            // 
            ClientInsertGroup.Controls.Add(ClientInsertLabel);
            ClientInsertGroup.Controls.Add(button1);
            ClientInsertGroup.Controls.Add(ClientInsertButton);
            ClientInsertGroup.Controls.Add(ClientTelefon);
            ClientInsertGroup.Controls.Add(label4);
            ClientInsertGroup.Controls.Add(ClientEmail);
            ClientInsertGroup.Controls.Add(label3);
            ClientInsertGroup.Controls.Add(ClientPrenume);
            ClientInsertGroup.Controls.Add(label2);
            ClientInsertGroup.Controls.Add(ClientNume);
            ClientInsertGroup.Controls.Add(label1);
            ClientInsertGroup.Location = new Point(12, 14);
            ClientInsertGroup.Name = "ClientInsertGroup";
            ClientInsertGroup.Size = new Size(280, 345);
            ClientInsertGroup.TabIndex = 0;
            ClientInsertGroup.TabStop = false;
            ClientInsertGroup.Text = "Add Client";
            ClientInsertGroup.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(146, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientInsertButton
            // 
            ClientInsertButton.Location = new Point(14, 310);
            ClientInsertButton.Name = "ClientInsertButton";
            ClientInsertButton.Size = new Size(94, 29);
            ClientInsertButton.TabIndex = 8;
            ClientInsertButton.Text = "Add";
            ClientInsertButton.UseVisualStyleBackColor = true;
            ClientInsertButton.Click += ClientInsertButton_Click;
            // 
            // ClientTelefon
            // 
            ClientTelefon.Location = new Point(14, 235);
            ClientTelefon.Name = "ClientTelefon";
            ClientTelefon.Size = new Size(226, 27);
            ClientTelefon.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 212);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefon";
            // 
            // ClientEmail
            // 
            ClientEmail.Location = new Point(14, 172);
            ClientEmail.Name = "ClientEmail";
            ClientEmail.Size = new Size(226, 27);
            ClientEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // ClientPrenume
            // 
            ClientPrenume.Location = new Point(14, 110);
            ClientPrenume.Name = "ClientPrenume";
            ClientPrenume.Size = new Size(226, 27);
            ClientPrenume.TabIndex = 3;
            ClientPrenume.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Prenume";
            // 
            // ClientNume
            // 
            ClientNume.Location = new Point(14, 48);
            ClientNume.Name = "ClientNume";
            ClientNume.Size = new Size(226, 27);
            ClientNume.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // ClientInsertLabel
            // 
            ClientInsertLabel.AutoSize = true;
            ClientInsertLabel.Location = new Point(14, 275);
            ClientInsertLabel.Name = "ClientInsertLabel";
            ClientInsertLabel.Size = new Size(0, 20);
            ClientInsertLabel.TabIndex = 10;
            // 
            // ClientInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 371);
            Controls.Add(ClientInsertGroup);
            Name = "ClientInsert";
            Text = "ClientInsert";
            ClientInsertGroup.ResumeLayout(false);
            ClientInsertGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ClientInsertGroup;
        private Label label1;
        private TextBox ClientTelefon;
        private Label label4;
        private TextBox ClientEmail;
        private Label label3;
        private TextBox ClientPrenume;
        private Label label2;
        private TextBox ClientNume;
        private Button ClientInsertButton;
        private Button button1;
        private Label ClientInsertLabel;
    }
}