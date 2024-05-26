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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StudentsChoosingWindow));
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
            chooseAllStudents.Location = new Point(53, 290);
            chooseAllStudents.Margin = new Padding(3, 2, 3, 2);
            chooseAllStudents.Name = "chooseAllStudents";
            chooseAllStudents.Size = new Size(164, 22);
            chooseAllStudents.TabIndex = 0;
            chooseAllStudents.Text = "Choose All Students";
            chooseAllStudents.UseVisualStyleBackColor = false;
            chooseAllStudents.Click += chooseAllStudents_Click;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.Thistle;
            applyButton.Location = new Point(223, 290);
            applyButton.Margin = new Padding(3, 2, 3, 2);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(82, 22);
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
            okayButton.Location = new Point(1352, 284);
            okayButton.Margin = new Padding(3, 2, 3, 2);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(82, 31);
            okayButton.TabIndex = 2;
            okayButton.Text = "Done";
            okayButton.UseVisualStyleBackColor = false;
            okayButton.Click += okayButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(285, 22);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(268, 259);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // fileName
            // 
            fileName.FormattingEnabled = true;
            fileName.ItemHeight = 15;
            fileName.Location = new Point(53, 22);
            fileName.Margin = new Padding(3, 2, 3, 2);
            fileName.Name = "fileName";
            fileName.Size = new Size(227, 259);
            fileName.TabIndex = 4;
            fileName.SelectedIndexChanged += fileName_SelectedIndexChanged;
            // 
            // path
            // 
            path.FormattingEnabled = true;
            path.ItemHeight = 15;
            path.Location = new Point(566, 22);
            path.Margin = new Padding(3, 2, 3, 2);
            path.Name = "path";
            path.Size = new Size(868, 259);
            path.TabIndex = 5;
            path.SelectedIndexChanged += path_SelectedIndexChanged;
            // 
            // Form_StudentsChoosingWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1464, 338);
            Controls.Add(path);
            Controls.Add(fileName);
            Controls.Add(listBox1);
            Controls.Add(okayButton);
            Controls.Add(applyButton);
            Controls.Add(chooseAllStudents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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