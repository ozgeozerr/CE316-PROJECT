namespace BerkazyHalka
{
    partial class Form_Configuration
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            saveConfig = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            browseFiles_button = new Button();
            openFileDialog2 = new OpenFileDialog();
            browseButtonnn = new Button();
            bindingSource1 = new BindingSource(components);
            nextButton = new Button();
            backButton = new Button();
            cbo = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(52, 156);
            label2.Name = "label2";
            label2.Size = new Size(276, 23);
            label2.TabIndex = 1;
            label2.Text = "Select Programming Language:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 221);
            label3.Name = "label3";
            label3.Size = new Size(192, 23);
            label3.TabIndex = 2;
            label3.Text = "Select Compiler Path:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(52, 285);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 3;
            label4.Text = "Select Source Code:";
            // 
            // saveConfig
            // 
            saveConfig.BackColor = Color.Thistle;
            saveConfig.Font = new Font("Cambria", 9F, FontStyle.Bold);
            saveConfig.ForeColor = Color.Black;
            saveConfig.Location = new Point(425, 351);
            saveConfig.Name = "saveConfig";
            saveConfig.Size = new Size(176, 36);
            saveConfig.TabIndex = 8;
            saveConfig.Text = "Export Configuration";
            saveConfig.UseVisualStyleBackColor = false;
            saveConfig.Click += saveConfig_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(868, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "helpMenuStrip";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = Color.Transparent;
            helpToolStripMenuItem.Font = new Font("Cambria", 10F);
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.ShowShortcutKeys = false;
            helpToolStripMenuItem.Size = new Size(57, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(52, 99);
            label1.Name = "label1";
            label1.Size = new Size(189, 23);
            label1.TabIndex = 14;
            label1.Text = "Configuration Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.Location = new Point(334, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 15;
            // 
            // browseFiles_button
            // 
            browseFiles_button.BackColor = Color.Thistle;
            browseFiles_button.Font = new Font("Calisto MT", 10F);
            browseFiles_button.Location = new Point(584, 215);
            browseFiles_button.Name = "browseFiles_button";
            browseFiles_button.Size = new Size(141, 29);
            browseFiles_button.TabIndex = 16;
            browseFiles_button.Text = "Browse Files";
            browseFiles_button.TextAlign = ContentAlignment.MiddleLeft;
            browseFiles_button.UseVisualStyleBackColor = false;
            browseFiles_button.Click += browseFiles_button_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // browseButtonnn
            // 
            browseButtonnn.BackColor = Color.Thistle;
            browseButtonnn.Font = new Font("Calisto MT", 10F);
            browseButtonnn.Location = new Point(584, 279);
            browseButtonnn.Name = "browseButtonnn";
            browseButtonnn.Size = new Size(141, 29);
            browseButtonnn.TabIndex = 17;
            browseButtonnn.Text = "Browse Files";
            browseButtonnn.TextAlign = ContentAlignment.MiddleLeft;
            browseButtonnn.UseVisualStyleBackColor = false;
            browseButtonnn.Click += button1_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(249, 373);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 18;
            nextButton.Text = "next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(79, 373);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 19;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // cbo
            // 
            cbo.FormattingEnabled = true;
            cbo.Items.AddRange(new object[] { "C", "Java" });
            cbo.Location = new Point(334, 156);
            cbo.Name = "cbo";
            cbo.Size = new Size(245, 28);
            cbo.TabIndex = 20;
            cbo.SelectedIndexChanged += cbo_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(334, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(334, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(748, 215);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(748, 279);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(607, 351);
            button3.Name = "button3";
            button3.Size = new Size(165, 36);
            button3.TabIndex = 25;
            button3.Text = "add configuration";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form_Configuration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(868, 444);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(cbo);
            Controls.Add(backButton);
            Controls.Add(nextButton);
            Controls.Add(browseButtonnn);
            Controls.Add(browseFiles_button);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(saveConfig);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form_Configuration";
            Text = "EasyAssign";
            Load += Form_Configuration_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button saveConfig;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ComboBox selectProgrammingLanguage_combobox;
        private Label label1;
        private TextBox textBox1;
        private OpenFileDialog browseFiles_openFileDialog;
        private Button browseFiles_button;
        private OpenFileDialog openFileDialog2;
        private Button browseButtonnn;
        private BindingSource bindingSource1;
        private Button nextButton;
        private Button backButton;
        private ComboBox cbo;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}