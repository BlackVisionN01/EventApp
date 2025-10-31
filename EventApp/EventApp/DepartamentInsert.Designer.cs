namespace EventApp
{
    partial class DepartamentInsert
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
            DepartamentInsertGroup = new GroupBox();
            button1 = new Button();
            DepartamentInsertButton = new Button();
            DepartamentProgram = new TextBox();
            label3 = new Label();
            DepartamentCod = new TextBox();
            label2 = new Label();
            DepartamentNume = new TextBox();
            label1 = new Label();
            DepartamentInsertLabel = new Label();
            DepartamentInsertGroup.SuspendLayout();
            SuspendLayout();
            // 
            // DepartamentInsertGroup
            // 
            DepartamentInsertGroup.Controls.Add(DepartamentInsertLabel);
            DepartamentInsertGroup.Controls.Add(button1);
            DepartamentInsertGroup.Controls.Add(DepartamentInsertButton);
            DepartamentInsertGroup.Controls.Add(DepartamentProgram);
            DepartamentInsertGroup.Controls.Add(label3);
            DepartamentInsertGroup.Controls.Add(DepartamentCod);
            DepartamentInsertGroup.Controls.Add(label2);
            DepartamentInsertGroup.Controls.Add(DepartamentNume);
            DepartamentInsertGroup.Controls.Add(label1);
            DepartamentInsertGroup.Location = new Point(12, 22);
            DepartamentInsertGroup.Name = "DepartamentInsertGroup";
            DepartamentInsertGroup.Size = new Size(280, 281);
            DepartamentInsertGroup.TabIndex = 1;
            DepartamentInsertGroup.TabStop = false;
            DepartamentInsertGroup.Text = "Add Departament";
            // 
            // button1
            // 
            button1.Location = new Point(146, 246);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepartamentInsertButton
            // 
            DepartamentInsertButton.Location = new Point(14, 246);
            DepartamentInsertButton.Name = "DepartamentInsertButton";
            DepartamentInsertButton.Size = new Size(94, 29);
            DepartamentInsertButton.TabIndex = 8;
            DepartamentInsertButton.Text = "Add";
            DepartamentInsertButton.UseVisualStyleBackColor = true;
            DepartamentInsertButton.Click += DepartamentInsertButton_Click;
            // 
            // DepartamentProgram
            // 
            DepartamentProgram.Location = new Point(14, 172);
            DepartamentProgram.Name = "DepartamentProgram";
            DepartamentProgram.Size = new Size(226, 27);
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
            DepartamentCod.Size = new Size(226, 27);
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
            DepartamentNume.Size = new Size(226, 27);
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
            // DepartamentInsertLabel
            // 
            DepartamentInsertLabel.AutoSize = true;
            DepartamentInsertLabel.Location = new Point(14, 214);
            DepartamentInsertLabel.Name = "DepartamentInsertLabel";
            DepartamentInsertLabel.Size = new Size(0, 20);
            DepartamentInsertLabel.TabIndex = 10;
            // 
            // DepartamentInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 315);
            Controls.Add(DepartamentInsertGroup);
            Name = "DepartamentInsert";
            Text = "DepartamentInsert";
            DepartamentInsertGroup.ResumeLayout(false);
            DepartamentInsertGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DepartamentInsertGroup;
        private Button DepartamentInsertButton;
        private TextBox DepartamentProgram;
        private Label label3;
        private TextBox DepartamentCod;
        private Label label2;
        private TextBox DepartamentNume;
        private Label label1;
        private Button button1;
        private Label DepartamentInsertLabel;
    }
}