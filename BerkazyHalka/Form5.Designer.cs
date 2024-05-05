namespace BerkazyHalka
{
    partial class Form5
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
            backButton = new Button();
            listBox1 = new ListBox();
            selectTestStudent = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(32, 269);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(32, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(328, 224);
            listBox1.TabIndex = 1;
            // 
            // selectTestStudent
            // 
            selectTestStudent.Location = new Point(366, 223);
            selectTestStudent.Name = "selectTestStudent";
            selectTestStudent.Size = new Size(94, 29);
            selectTestStudent.TabIndex = 2;
            selectTestStudent.Text = "select";
            selectTestStudent.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 317);
            Controls.Add(selectTestStudent);
            Controls.Add(listBox1);
            Controls.Add(backButton);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private ListBox listBox1;
        private Button selectTestStudent;
    }
}