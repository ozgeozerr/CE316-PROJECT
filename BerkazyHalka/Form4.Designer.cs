namespace BerkazyHalka
{
    partial class Form4
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
            currentText = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            selectAStudent = new Button();
            testAll = new Button();
            dataGridView1 = new DataGridView();
            homePageButton = new Button();
            solText = new RichTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // currentText
            // 
            currentText.Location = new Point(485, 33);
            currentText.Margin = new Padding(3, 2, 3, 2);
            currentText.Name = "currentText";
            currentText.ReadOnly = true;
            currentText.Size = new Size(392, 269);
            currentText.TabIndex = 0;
            currentText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(485, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 2;
            label1.Text = "Student Output";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(48, 10);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 3;
            label2.Text = "Student Result";
            // 
            // selectAStudent
            // 
            selectAStudent.BackColor = Color.Thistle;
            selectAStudent.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectAStudent.Location = new Point(928, 106);
            selectAStudent.Margin = new Padding(3, 2, 3, 2);
            selectAStudent.Name = "selectAStudent";
            selectAStudent.Size = new Size(181, 37);
            selectAStudent.TabIndex = 4;
            selectAStudent.Text = "Choose Students Zip";
            selectAStudent.UseVisualStyleBackColor = false;
            selectAStudent.Click += selectAStudent_Click;
            // 
            // testAll
            // 
            testAll.BackColor = Color.Teal;
            testAll.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testAll.ForeColor = SystemColors.Control;
            testAll.Location = new Point(928, 156);
            testAll.Margin = new Padding(3, 2, 3, 2);
            testAll.Name = "testAll";
            testAll.Size = new Size(181, 35);
            testAll.TabIndex = 6;
            testAll.Text = "Test All The Students\r\n";
            testAll.UseVisualStyleBackColor = false;
            testAll.Click += testAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(485, 334);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(653, 214);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // homePageButton
            // 
            homePageButton.BackColor = Color.BurlyWood;
            homePageButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            homePageButton.Location = new Point(928, 205);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(181, 37);
            homePageButton.TabIndex = 15;
            homePageButton.Text = "Go To Homepage";
            homePageButton.UseVisualStyleBackColor = false;
            homePageButton.Click += homePageButton_Click;
            // 
            // solText
            // 
            solText.Location = new Point(48, 33);
            solText.Name = "solText";
            solText.Size = new Size(414, 515);
            solText.TabIndex = 1;
            solText.Text = "";
            solText.TextChanged += excText_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(928, 268);
            button1.Name = "button1";
            button1.Size = new Size(131, 34);
            button1.TabIndex = 16;
            button1.Text = "Display Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(485, 309);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Location = new Point(786, 10);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 22);
            button2.TabIndex = 18;
            button2.Text = "Save Outputs";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Location = new Point(369, 10);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(93, 22);
            button3.TabIndex = 19;
            button3.Text = "Save Solution";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1164, 593);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(homePageButton);
            Controls.Add(dataGridView1);
            Controls.Add(testAll);
            Controls.Add(selectAStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(solText);
            Controls.Add(currentText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "EasyAssign";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox currentText;
        private Label label1;
        private Label label2;
        public Button selectAStudent;
        private Button testAll;
        private DataGridView dataGridView1;
        private Button homePageButton;
        private TextBox textBox1;
        private RichTextBox solText;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}