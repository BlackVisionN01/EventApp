namespace EventApp
{
    partial class DepartamentUpdate
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
            DepartamentUpdateGroup = new GroupBox();
            DepartamentUpdateLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            DepartamentUpdateButton = new Button();
            DepartamentProgram = new TextBox();
            label3 = new Label();
            DepartamentCod = new TextBox();
            label2 = new Label();
            DepartamentNume = new TextBox();
            label1 = new Label();
            DepartamentUpdateGroup.SuspendLayout();
            SuspendLayout();
            // 
            // DepartamentUpdateGroup
            // 
            DepartamentUpdateGroup.Controls.Add(DepartamentUpdateLabel);
            DepartamentUpdateGroup.Controls.Add(button2);
            DepartamentUpdateGroup.Controls.Add(button1);
            DepartamentUpdateGroup.Controls.Add(DepartamentUpdateButton);
            DepartamentUpdateGroup.Controls.Add(DepartamentProgram);
            DepartamentUpdateGroup.Controls.Add(label3);
            DepartamentUpdateGroup.Controls.Add(DepartamentCod);
            DepartamentUpdateGroup.Controls.Add(label2);
            DepartamentUpdateGroup.Controls.Add(DepartamentNume);
            DepartamentUpdateGroup.Controls.Add(label1);
            DepartamentUpdateGroup.Location = new Point(12, 12);
            DepartamentUpdateGroup.Name = "DepartamentUpdateGroup";
            DepartamentUpdateGroup.Size = new Size(314, 293);
            DepartamentUpdateGroup.TabIndex = 2;
            DepartamentUpdateGroup.TabStop = false;
            DepartamentUpdateGroup.Text = "Update Departament";
            // 
            // DepartamentUpdateLabel
            // 
            DepartamentUpdateLabel.AutoSize = true;
            DepartamentUpdateLabel.Location = new Point(14, 218);
            DepartamentUpdateLabel.Name = "DepartamentUpdateLabel";
            DepartamentUpdateLabel.Size = new Size(0, 20);
            DepartamentUpdateLabel.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(114, 258);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(214, 258);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepartamentUpdateButton
            // 
            DepartamentUpdateButton.Location = new Point(14, 258);
            DepartamentUpdateButton.Name = "DepartamentUpdateButton";
            DepartamentUpdateButton.Size = new Size(94, 29);
            DepartamentUpdateButton.TabIndex = 8;
            DepartamentUpdateButton.Text = "Update";
            DepartamentUpdateButton.UseVisualStyleBackColor = true;
            DepartamentUpdateButton.Click += DepartamentUpdateButton_Click;
            // 
            // DepartamentProgram
            // 
            DepartamentProgram.Location = new Point(14, 172);
            DepartamentProgram.Name = "DepartamentProgram";
            DepartamentProgram.Size = new Size(294, 27);
            DepartamentProgram.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 149);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Program";
            // 
            // DepartamentCod
            // 
            DepartamentCod.Location = new Point(14, 110);
            DepartamentCod.Name = "DepartamentCod";
            DepartamentCod.Size = new Size(294, 27);
            DepartamentCod.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Cod";
            // 
            // DepartamentNume
            // 
            DepartamentNume.Location = new Point(14, 48);
            DepartamentNume.Name = "DepartamentNume";
            DepartamentNume.Size = new Size(294, 27);
            DepartamentNume.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Nume Departament";
            // 
            // DepartamentUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 317);
            Controls.Add(DepartamentUpdateGroup);
            Name = "DepartamentUpdate";
            Text = "DepartamentUpdate";
            Load += DepartamentUpdate_Load;
            DepartamentUpdateGroup.ResumeLayout(false);
            DepartamentUpdateGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DepartamentUpdateGroup;
        private Button DepartamentUpdateButton;
        private TextBox DepartamentProgram;
        private Label label3;
        private TextBox DepartamentCod;
        private Label label2;
        private TextBox DepartamentNume;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label DepartamentUpdateLabel;
    }
}