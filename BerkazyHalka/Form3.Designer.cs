namespace BerkazyHalka
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            saveConfig = new Button();
            createAssign = new Button();
            browseComp = new Button();
            browseSource = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(60, 105);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Assignment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(60, 135);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 1;
            label2.Text = "Programming Languages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(60, 168);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Complier Path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(60, 201);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Source Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(241, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 27);
            textBox4.TabIndex = 7;
            // 
            // saveConfig
            // 
            saveConfig.ForeColor = Color.Black;
            saveConfig.Location = new Point(52, 265);
            saveConfig.Name = "saveConfig";
            saveConfig.Size = new Size(183, 29);
            saveConfig.TabIndex = 8;
            saveConfig.Text = "Save Configuration";
            saveConfig.UseVisualStyleBackColor = true;
            // 
            // createAssign
            // 
            createAssign.ForeColor = Color.Black;
            createAssign.Location = new Point(52, 300);
            createAssign.Name = "createAssign";
            createAssign.Size = new Size(183, 29);
            createAssign.TabIndex = 9;
            createAssign.Text = "Create Assignment";
            createAssign.UseVisualStyleBackColor = true;
            // 
            // browseComp
            // 
            browseComp.Location = new Point(480, 165);
            browseComp.Name = "browseComp";
            browseComp.Size = new Size(94, 29);
            browseComp.TabIndex = 10;
            browseComp.Text = "Browse";
            browseComp.UseVisualStyleBackColor = true;
            browseComp.Click += browseComp_Click;
            // 
            // browseSource
            // 
            browseSource.Location = new Point(480, 196);
            browseSource.Name = "browseSource";
            browseSource.Size = new Size(94, 29);
            browseSource.TabIndex = 11;
            browseSource.Text = "Browse";
            browseSource.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(598, 390);
            Controls.Add(browseSource);
            Controls.Add(browseComp);
            Controls.Add(createAssign);
            Controls.Add(saveConfig);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button saveConfig;
        private Button createAssign;
        private Button browseComp;
        private Button browseSource;
    }
}