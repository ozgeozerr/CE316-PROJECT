namespace BerkazyHalka
{
    partial class Form_CreatingNewAssignment
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
            nextButton = new Button();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            browseFile1 = new Button();
            browseFile = new Button();
            createNewConfig = new Button();
            saveAssignment = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Location = new Point(148, 436);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 14;
            nextButton.Text = "next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(28, 436);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 15;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 67);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 16;
            label1.Text = "Assigment Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 286);
            label2.Name = "label2";
            label2.Size = new Size(271, 21);
            label2.TabIndex = 17;
            label2.Text = "Choose an Existing Configuration:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 212);
            label3.Name = "label3";
            label3.Size = new Size(287, 21);
            label3.TabIndex = 18;
            label3.Text = "Select a Folder for Expected Output:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 139);
            label4.Name = "label4";
            label4.Size = new Size(208, 21);
            label4.TabIndex = 19;
            label4.Text = "Select a Folder for Inputs:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.Location = new Point(332, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 20;
            // 
            // browseFile1
            // 
            browseFile1.BackColor = Color.Thistle;
            browseFile1.Location = new Point(332, 136);
            browseFile1.Name = "browseFile1";
            browseFile1.Size = new Size(204, 29);
            browseFile1.TabIndex = 21;
            browseFile1.Text = "Browse Files";
            browseFile1.UseVisualStyleBackColor = false;
            // 
            // browseFile
            // 
            browseFile.BackColor = Color.Thistle;
            browseFile.Location = new Point(332, 209);
            browseFile.Name = "browseFile";
            browseFile.Size = new Size(204, 29);
            browseFile.TabIndex = 22;
            browseFile.Text = "Browse Files";
            browseFile.UseVisualStyleBackColor = false;
            // 
            // createNewConfig
            // 
            createNewConfig.BackColor = Color.Thistle;
            createNewConfig.Location = new Point(332, 347);
            createNewConfig.Name = "createNewConfig";
            createNewConfig.Size = new Size(204, 29);
            createNewConfig.TabIndex = 23;
            createNewConfig.Text = "Create New Configuration";
            createNewConfig.TextAlign = ContentAlignment.MiddleLeft;
            createNewConfig.UseVisualStyleBackColor = false;
            // 
            // saveAssignment
            // 
            saveAssignment.BackColor = Color.Thistle;
            saveAssignment.Location = new Point(551, 436);
            saveAssignment.Name = "saveAssignment";
            saveAssignment.Size = new Size(255, 29);
            saveAssignment.TabIndex = 24;
            saveAssignment.Text = "Save and Create the Assignment";
            saveAssignment.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 350);
            label5.Name = "label5";
            label5.Size = new Size(214, 21);
            label5.TabIndex = 26;
            label5.Text = "Create New Configuration:";
            // 
            // Form_CreatingNewAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(833, 493);
            Controls.Add(label5);
            Controls.Add(saveAssignment);
            Controls.Add(createNewConfig);
            Controls.Add(browseFile);
            Controls.Add(browseFile1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(nextButton);
            Name = "Form_CreatingNewAssignment";
            Text = " EasyAssign";
            Load += Form_CreatingNewAssignment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button nextButton;
        private Button backButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button browseFile1;
        private Button browseFile;
        private Button createNewConfig;
        private Button saveAssignment;
        private Label label5;
    }
}