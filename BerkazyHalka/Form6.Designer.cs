namespace BerkazyHalka
{
    partial class Form6
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
            okButton = new Button();
            language = new CheckBox();
            compileBox = new CheckBox();
            syntaxBox = new CheckBox();
            excOne = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(374, 239);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 0;
            okButton.Text = "Okay";
            okButton.UseVisualStyleBackColor = true;
            // 
            // language
            // 
            language.AutoSize = true;
            language.ForeColor = Color.White;
            language.Location = new Point(42, 96);
            language.Name = "language";
            language.Size = new Size(96, 24);
            language.TabIndex = 1;
            language.Text = "Language";
            language.UseVisualStyleBackColor = true;
            // 
            // compileBox
            // 
            compileBox.AutoSize = true;
            compileBox.ForeColor = Color.White;
            compileBox.Location = new Point(144, 96);
            compileBox.Name = "compileBox";
            compileBox.Size = new Size(87, 24);
            compileBox.TabIndex = 2;
            compileBox.Text = "Compile";
            compileBox.UseVisualStyleBackColor = true;
            compileBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // syntaxBox
            // 
            syntaxBox.AutoSize = true;
            syntaxBox.ForeColor = Color.White;
            syntaxBox.Location = new Point(237, 96);
            syntaxBox.Name = "syntaxBox";
            syntaxBox.Size = new Size(74, 24);
            syntaxBox.TabIndex = 3;
            syntaxBox.Text = "Syntax";
            syntaxBox.UseVisualStyleBackColor = true;
            // 
            // excOne
            // 
            excOne.AutoSize = true;
            excOne.ForeColor = Color.White;
            excOne.Location = new Point(593, 56);
            excOne.Name = "excOne";
            excOne.Size = new Size(101, 24);
            excOne.TabIndex = 4;
            excOne.Text = "checkBox4";
            excOne.UseVisualStyleBackColor = true;
            excOne.CheckedChanged += excOne_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = Color.White;
            checkBox5.Location = new Point(593, 86);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(101, 24);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = Color.White;
            checkBox6.Location = new Point(593, 116);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(101, 24);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(851, 280);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(excOne);
            Controls.Add(syntaxBox);
            Controls.Add(compileBox);
            Controls.Add(language);
            Controls.Add(okButton);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private CheckBox language;
        private CheckBox compileBox;
        private CheckBox syntaxBox;
        private CheckBox excOne;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}