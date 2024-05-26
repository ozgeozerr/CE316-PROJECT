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
            excText = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            selectAStudent = new Button();
            testAll = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // currentText
            // 
            currentText.Location = new Point(500, 44);
            currentText.Name = "currentText";
            currentText.Size = new Size(447, 514);
            currentText.TabIndex = 0;
            currentText.Text = "";
            // 
            // excText
            // 
            excText.Location = new Point(55, 43);
            excText.Name = "excText";
            excText.Size = new Size(414, 515);
            excText.TabIndex = 1;
            excText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(500, 6);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "Expected Output";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(55, 5);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 3;
            label2.Text = "Student Result";
            // 
            // selectAStudent
            // 
            selectAStudent.BackColor = Color.Thistle;
            selectAStudent.Font = new Font("Segoe UI", 12F);
            selectAStudent.Location = new Point(978, 44);
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
            testAll.Font = new Font("Segoe UI", 12F);
            testAll.ForeColor = SystemColors.Control;
            testAll.Location = new Point(978, 99);
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
            dataGridView1.Location = new Point(977, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(837, 306);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1926, 585);
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
        private RichTextBox excText;
        private Label label1;
        private Label label2;
        private Button selectAStudent;
        private Button testAll;
        private DataGridView dataGridView1;
    }
}