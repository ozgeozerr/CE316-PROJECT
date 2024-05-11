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
            openTheResults = new Button();
            testAll = new Button();
            saveInpuıt = new Button();
            createManual = new Button();
            saveInputText = new TextBox();
            label3 = new Label();
            zipButton = new Button();
            exButton = new Button();
            button1 = new Button();
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
            label1.Location = new Point(55, 9);
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
            label2.Location = new Point(500, 7);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 3;
            label2.Text = "Student Result";
            // 
            // selectAStudent
            // 
            selectAStudent.Location = new Point(1037, 148);
            selectAStudent.Name = "selectAStudent";
            selectAStudent.Size = new Size(172, 29);
            selectAStudent.TabIndex = 4;
            selectAStudent.Text = "Choose Students";
            selectAStudent.UseVisualStyleBackColor = true;
            selectAStudent.Click += selectAStudent_Click;
            // 
            // openTheResults
            // 
            openTheResults.Location = new Point(1037, 183);
            openTheResults.Name = "openTheResults";
            openTheResults.Size = new Size(172, 29);
            openTheResults.TabIndex = 5;
            openTheResults.Text = "Open The Result";
            openTheResults.UseVisualStyleBackColor = true;
            // 
            // testAll
            // 
            testAll.Location = new Point(1037, 218);
            testAll.Name = "testAll";
            testAll.Size = new Size(172, 29);
            testAll.TabIndex = 6;
            testAll.Text = "Test All The Students\r\n";
            testAll.UseVisualStyleBackColor = true;
            testAll.Click += button3_Click;
            // 
            // saveInpuıt
            // 
            saveInpuıt.Location = new Point(351, 564);
            saveInpuıt.Name = "saveInpuıt";
            saveInpuıt.Size = new Size(94, 29);
            saveInpuıt.TabIndex = 7;
            saveInpuıt.Text = "Save Input";
            saveInpuıt.UseVisualStyleBackColor = true;
            // 
            // createManual
            // 
            createManual.Location = new Point(120, 599);
            createManual.Name = "createManual";
            createManual.Size = new Size(225, 29);
            createManual.TabIndex = 8;
            createManual.Text = "Or Create Manual Input";
            createManual.UseVisualStyleBackColor = true;
            createManual.Click += createManual_Click;
            // 
            // saveInputText
            // 
            saveInputText.Location = new Point(120, 564);
            saveInputText.Name = "saveInputText";
            saveInputText.Size = new Size(225, 27);
            saveInputText.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 567);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 10;
            label3.Text = "Input:";
            // 
            // zipButton
            // 
            zipButton.Location = new Point(1037, 78);
            zipButton.Name = "zipButton";
            zipButton.Size = new Size(94, 29);
            zipButton.TabIndex = 11;
            zipButton.Text = "Zip Butonu";
            zipButton.UseVisualStyleBackColor = true;
            zipButton.Click += zipButton_Click;
            // 
            // exButton
            // 
            exButton.Location = new Point(1037, 113);
            exButton.Name = "exButton";
            exButton.Size = new Size(94, 29);
            exButton.TabIndex = 12;
            exButton.Text = "Extreact Button";
            exButton.UseVisualStyleBackColor = true;
            exButton.Click += exButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1037, 43);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 13;
            button1.Text = "Berkaybutton";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(962, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(384, 278);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1381, 674);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(exButton);
            Controls.Add(zipButton);
            Controls.Add(label3);
            Controls.Add(saveInputText);
            Controls.Add(createManual);
            Controls.Add(saveInpuıt);
            Controls.Add(testAll);
            Controls.Add(openTheResults);
            Controls.Add(selectAStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(excText);
            Controls.Add(currentText);
            Name = "Form4";
            Text = "EasyAssign";
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
        private Button openTheResults;
        private Button testAll;
        private Button saveInpuıt;
        private Button createManual;
        private TextBox saveInputText;
        private Label label3;
        private Button zipButton;
        private Button exButton;
        private Button button1;
        private DataGridView dataGridView1;
    }
}