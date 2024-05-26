namespace BerkazyHalka
{
    partial class Form_StudentsChoosingWindow
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
            chooseAllStudents = new Button();
            applyButton = new Button();
            okayButton = new Button();
            listBox1 = new ListBox();
            fileName = new ListBox();
            path = new ListBox();
            SuspendLayout();
            // 
            // chooseAllStudents
            // 
            chooseAllStudents.BackColor = Color.Thistle;
            chooseAllStudents.Location = new Point(61, 386);
            chooseAllStudents.Name = "chooseAllStudents";
            chooseAllStudents.Size = new Size(188, 29);
            chooseAllStudents.TabIndex = 0;
            chooseAllStudents.Text = "Choose All Students";
            chooseAllStudents.UseVisualStyleBackColor = false;
            chooseAllStudents.Click += chooseAllStudents_Click;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.Thistle;
            applyButton.Location = new Point(255, 386);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(94, 29);
            applyButton.TabIndex = 1;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // okayButton
            // 
            okayButton.BackColor = Color.WhiteSmoke;
            okayButton.Font = new Font("Segoe UI", 10F);
            okayButton.ForeColor = Color.Black;
            okayButton.Location = new Point(1545, 379);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(94, 41);
            okayButton.TabIndex = 2;
            okayButton.Text = "Done";
            okayButton.UseVisualStyleBackColor = false;
            okayButton.Click += okayButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(326, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 344);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // fileName
            // 
            fileName.FormattingEnabled = true;
            fileName.Location = new Point(61, 29);
            fileName.Name = "fileName";
            fileName.Size = new Size(259, 344);
            fileName.TabIndex = 4;
            fileName.SelectedIndexChanged += fileName_SelectedIndexChanged;
            // 
            // path
            // 
            path.FormattingEnabled = true;
            path.Location = new Point(647, 29);
            path.Name = "path";
            path.Size = new Size(992, 344);
            path.TabIndex = 5;
            path.SelectedIndexChanged += path_SelectedIndexChanged;
            // 
            // Form_StudentsChoosingWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1673, 450);
            Controls.Add(path);
            Controls.Add(fileName);
            Controls.Add(listBox1);
            Controls.Add(okayButton);
            Controls.Add(applyButton);
            Controls.Add(chooseAllStudents);
            Name = "Form_StudentsChoosingWindow";
            Text = "Form_StudentsChoosingWindow";
            Load += Form_StudentsChoosingWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button chooseAllStudents;
        private Button applyButton;
        private Button okayButton;
        private ListBox listBox1;
        private ListBox fileName;
        private ListBox path;
    }
}