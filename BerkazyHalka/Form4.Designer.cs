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
            excText = new RichTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // currentText
            // 
            currentText.Location = new Point(554, 44);
            currentText.Name = "currentText";
            currentText.ReadOnly = true;
            currentText.Size = new Size(447, 357);
            currentText.TabIndex = 0;
            currentText.Text = "";
            currentText.TextChanged += currentText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(554, 12);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 2;
            label1.Text = "Student Output";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(55, 13);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 3;
            label2.Text = "Student Result";
            // 
            // selectAStudent
            // 
            selectAStudent.BackColor = Color.Thistle;
            selectAStudent.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectAStudent.Location = new Point(1061, 141);
            selectAStudent.Name = "selectAStudent";
            selectAStudent.Size = new Size(207, 49);
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
            testAll.Location = new Point(1061, 208);
            testAll.Name = "testAll";
            testAll.Size = new Size(207, 47);
            testAll.TabIndex = 6;
            testAll.Text = "Test All The Students\r\n";
            testAll.UseVisualStyleBackColor = false;
            testAll.Click += testAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(554, 445);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(746, 286);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // homePageButton
            // 
            homePageButton.BackColor = Color.BurlyWood;
            homePageButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            homePageButton.Location = new Point(1061, 273);
            homePageButton.Margin = new Padding(3, 4, 3, 4);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(207, 49);
            homePageButton.TabIndex = 15;
            homePageButton.Text = "Go To Homepage";
            homePageButton.UseVisualStyleBackColor = false;
            homePageButton.Click += homePageButton_Click;
            // 
            // excText
            // 
            excText.Location = new Point(55, 44);
            excText.Margin = new Padding(3, 4, 3, 4);
            excText.Name = "excText";
            excText.ReadOnly = true;
            excText.Size = new Size(473, 685);
            excText.TabIndex = 1;
            excText.Text = "";
            excText.TextChanged += excText_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1061, 357);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 16;
            button1.Text = "Display Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(554, 412);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 27);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(907, 13);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1330, 791);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(homePageButton);
            Controls.Add(dataGridView1);
            Controls.Add(testAll);
            Controls.Add(selectAStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(excText);
            Controls.Add(currentText);
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
        private RichTextBox excText;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
    }
}