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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textb_assignName = new TextBox();
            browseFile1 = new Button();
            browseFile = new Button();
            createNewConfig = new Button();
            saveAssignment = new Button();
            textb_inputFolder = new TextBox();
            textb_expectedFolder = new TextBox();
            saveInput = new Button();
            saveOutput = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 16;
            label1.Text = "Assigment Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 214);
            label2.Name = "label2";
            label2.Size = new Size(173, 19);
            label2.TabIndex = 17;
            label2.Text = "Manage Configurations:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 159);
            label3.Name = "label3";
            label3.Size = new Size(257, 19);
            label3.TabIndex = 18;
            label3.Text = "Select a Folder for Expected Output:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 104);
            label4.Name = "label4";
            label4.Size = new Size(187, 19);
            label4.TabIndex = 19;
            label4.Text = "Select a Folder for Inputs:";
            // 
            // textb_assignName
            // 
            textb_assignName.BackColor = Color.GhostWhite;
            textb_assignName.Location = new Point(327, 47);
            textb_assignName.Margin = new Padding(3, 2, 3, 2);
            textb_assignName.Name = "textb_assignName";
            textb_assignName.Size = new Size(179, 23);
            textb_assignName.TabIndex = 20;
            textb_assignName.TextChanged += textBox1_TextChanged;
            // 
            // browseFile1
            // 
            browseFile1.BackColor = Color.Thistle;
            browseFile1.Location = new Point(511, 104);
            browseFile1.Margin = new Padding(3, 2, 3, 2);
            browseFile1.Name = "browseFile1";
            browseFile1.Size = new Size(178, 22);
            browseFile1.TabIndex = 21;
            browseFile1.Text = "Browse Files";
            browseFile1.UseVisualStyleBackColor = false;
            browseFile1.Click += browseFile1_Click;
            // 
            // browseFile
            // 
            browseFile.BackColor = Color.Thistle;
            browseFile.Location = new Point(511, 159);
            browseFile.Margin = new Padding(3, 2, 3, 2);
            browseFile.Name = "browseFile";
            browseFile.Size = new Size(178, 22);
            browseFile.TabIndex = 22;
            browseFile.Text = "Browse Files";
            browseFile.UseVisualStyleBackColor = false;
            browseFile.Click += browseFile_Click;
            // 
            // createNewConfig
            // 
            createNewConfig.BackColor = Color.FromArgb(192, 192, 255);
            createNewConfig.Font = new Font("Cambria", 10.8F);
            createNewConfig.ForeColor = Color.Black;
            createNewConfig.Location = new Point(327, 210);
            createNewConfig.Margin = new Padding(3, 2, 3, 2);
            createNewConfig.Name = "createNewConfig";
            createNewConfig.Size = new Size(178, 22);
            createNewConfig.TabIndex = 23;
            createNewConfig.Text = "  Go to Configurations";
            createNewConfig.TextAlign = ContentAlignment.MiddleLeft;
            createNewConfig.UseVisualStyleBackColor = false;
            createNewConfig.Click += createNewConfig_Click;
            // 
            // saveAssignment
            // 
            saveAssignment.BackColor = Color.WhiteSmoke;
            saveAssignment.Font = new Font("Cambria", 12F);
            saveAssignment.ForeColor = Color.Black;
            saveAssignment.Location = new Point(634, 272);
            saveAssignment.Margin = new Padding(3, 2, 3, 2);
            saveAssignment.Name = "saveAssignment";
            saveAssignment.Size = new Size(143, 34);
            saveAssignment.TabIndex = 24;
            saveAssignment.Text = "Save and Create ";
            saveAssignment.UseVisualStyleBackColor = false;
            saveAssignment.Click += saveAssignment_Click;
            // 
            // textb_inputFolder
            // 
            textb_inputFolder.Location = new Point(327, 104);
            textb_inputFolder.Margin = new Padding(3, 2, 3, 2);
            textb_inputFolder.Name = "textb_inputFolder";
            textb_inputFolder.Size = new Size(179, 23);
            textb_inputFolder.TabIndex = 27;
            textb_inputFolder.TextChanged += textb_inputFolder_TextChanged;
            // 
            // textb_expectedFolder
            // 
            textb_expectedFolder.Location = new Point(327, 160);
            textb_expectedFolder.Margin = new Padding(3, 2, 3, 2);
            textb_expectedFolder.Name = "textb_expectedFolder";
            textb_expectedFolder.Size = new Size(179, 23);
            textb_expectedFolder.TabIndex = 28;
            textb_expectedFolder.TextChanged += textb_expectedFolder_TextChanged;
            // 
            // saveInput
            // 
            saveInput.BackColor = Color.WhiteSmoke;
            saveInput.Location = new Point(695, 104);
            saveInput.Margin = new Padding(3, 2, 3, 2);
            saveInput.Name = "saveInput";
            saveInput.Size = new Size(82, 22);
            saveInput.TabIndex = 29;
            saveInput.Text = "Save";
            saveInput.UseVisualStyleBackColor = false;
            saveInput.Click += saveInput_Click;
            // 
            // saveOutput
            // 
            saveOutput.BackColor = Color.WhiteSmoke;
            saveOutput.Location = new Point(695, 159);
            saveOutput.Margin = new Padding(3, 2, 3, 2);
            saveOutput.Name = "saveOutput";
            saveOutput.Size = new Size(82, 22);
            saveOutput.TabIndex = 30;
            saveOutput.Text = "Save";
            saveOutput.UseVisualStyleBackColor = false;
            saveOutput.Click += saveOutput_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.WhiteSmoke;
            backButton.Font = new Font("Segoe UI", 10F);
            backButton.ForeColor = Color.Black;
            backButton.Location = new Point(24, 272);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(108, 34);
            backButton.TabIndex = 15;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // Form_CreatingNewAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(801, 348);
            Controls.Add(saveOutput);
            Controls.Add(saveInput);
            Controls.Add(textb_expectedFolder);
            Controls.Add(textb_inputFolder);
            Controls.Add(saveAssignment);
            Controls.Add(createNewConfig);
            Controls.Add(browseFile);
            Controls.Add(browseFile1);
            Controls.Add(textb_assignName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_CreatingNewAssignment";
            Text = " EasyAssign";
            Load += Form_CreatingNewAssignment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textb_assignName;
        private Button browseFile1;
        private Button browseFile;
        private Button createNewConfig;
        private Button saveAssignment;
        private Label label5;
        private TextBox textb_inputFolder;
        private TextBox textb_expectedFolder;
        private Button saveInput;
        private Button saveOutput;
        private Button backButton;
    }
}