namespace EventApp
{
    partial class ClientUpdate
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
            ClientUpdateGroup = new GroupBox();
            ClientUpdateLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            ClientUpdateButton = new Button();
            ClientTelefon = new TextBox();
            label4 = new Label();
            ClientEmail = new TextBox();
            label3 = new Label();
            ClientPrenume = new TextBox();
            label2 = new Label();
            ClientNume = new TextBox();
            label1 = new Label();
            ClientUpdateGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ClientUpdateGroup
            // 
            ClientUpdateGroup.Controls.Add(ClientUpdateLabel);
            ClientUpdateGroup.Controls.Add(button2);
            ClientUpdateGroup.Controls.Add(button1);
            ClientUpdateGroup.Controls.Add(ClientUpdateButton);
            ClientUpdateGroup.Controls.Add(ClientTelefon);
            ClientUpdateGroup.Controls.Add(label4);
            ClientUpdateGroup.Controls.Add(ClientEmail);
            ClientUpdateGroup.Controls.Add(label3);
            ClientUpdateGroup.Controls.Add(ClientPrenume);
            ClientUpdateGroup.Controls.Add(label2);
            ClientUpdateGroup.Controls.Add(ClientNume);
            ClientUpdateGroup.Controls.Add(label1);
            ClientUpdateGroup.Location = new Point(12, 12);
            ClientUpdateGroup.Name = "ClientUpdateGroup";
            ClientUpdateGroup.Size = new Size(326, 348);
            ClientUpdateGroup.TabIndex = 1;
            ClientUpdateGroup.TabStop = false;
            ClientUpdateGroup.Text = "Update Client";
            // 
            // ClientUpdateLabel
            // 
            ClientUpdateLabel.AutoSize = true;
            ClientUpdateLabel.Location = new Point(14, 275);
            ClientUpdateLabel.Name = "ClientUpdateLabel";
            ClientUpdateLabel.Size = new Size(0, 20);
            ClientUpdateLabel.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(114, 313);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(217, 313);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientUpdateButton
            // 
            ClientUpdateButton.Location = new Point(14, 313);
            ClientUpdateButton.Name = "ClientUpdateButton";
            ClientUpdateButton.Size = new Size(94, 29);
            ClientUpdateButton.TabIndex = 8;
            ClientUpdateButton.Text = "Update";
            ClientUpdateButton.UseVisualStyleBackColor = true;
            ClientUpdateButton.Click += ClientUpdateButton_Click;
            // 
            // ClientTelefon
            // 
            ClientTelefon.Location = new Point(14, 235);
            ClientTelefon.Name = "ClientTelefon";
            ClientTelefon.Size = new Size(297, 27);
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
            ClientEmail.Size = new Size(297, 27);
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
            ClientPrenume.Size = new Size(297, 27);
            ClientPrenume.TabIndex = 3;
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
            ClientNume.Size = new Size(297, 27);
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
            // ClientUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 372);
            Controls.Add(ClientUpdateGroup);
            Name = "ClientUpdate";
            Text = "ClientUpdate";
            Load += ClientUpdate_Load;
            ClientUpdateGroup.ResumeLayout(false);
            ClientUpdateGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ClientUpdateGroup;
        private Button ClientUpdateButton;
        private TextBox ClientTelefon;
        private Label label4;
        private TextBox ClientEmail;
        private Label label3;
        private TextBox ClientPrenume;
        private Label label2;
        private TextBox ClientNume;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label ClientUpdateLabel;
    }
}