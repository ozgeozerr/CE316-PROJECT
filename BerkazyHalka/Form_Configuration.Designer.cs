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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Configuration));
            label2 = new Label();
            label3 = new Label();
            saveConfig = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            browseFiles_button = new Button();
            openFileDialog2 = new OpenFileDialog();
            bindingSource1 = new BindingSource(components);
            cbo = new ComboBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            browseButtonnn = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 117);
            label2.Name = "label2";
            label2.Size = new Size(223, 19);
            label2.TabIndex = 1;
            label2.Text = "Select Programming Language:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(20, 166);
            label3.Name = "label3";
            label3.Size = new Size(155, 19);
            label3.TabIndex = 2;
            label3.Text = "Select Compiler Path:";
            // 
            // saveConfig
            // 
            saveConfig.Location = new Point(0, 0);
            saveConfig.Margin = new Padding(3, 2, 3, 2);
            saveConfig.Name = "saveConfig";
            saveConfig.Size = new Size(66, 17);
            saveConfig.TabIndex = 26;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(760, 24);
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
            helpToolStripMenuItem.Size = new Size(48, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(20, 77);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 14;
            label1.Text = "Configuration Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.GhostWhite;
            textBox1.Location = new Point(292, 74);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // browseFiles_button
            // 
            browseFiles_button.BackColor = Color.Thistle;
            browseFiles_button.Font = new Font("Microsoft Sans Serif", 10F);
            browseFiles_button.Location = new Point(526, 161);
            browseFiles_button.Margin = new Padding(3, 2, 3, 2);
            browseFiles_button.Name = "browseFiles_button";
            browseFiles_button.Size = new Size(123, 22);
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
            // cbo
            // 
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.ForeColor = SystemColors.WindowFrame;
            cbo.FormattingEnabled = true;
            cbo.Items.AddRange(new object[] { "C", "C++", "Java", "Python" });
            cbo.Location = new Point(292, 113);
            cbo.Margin = new Padding(3, 2, 3, 2);
            cbo.Name = "cbo";
            cbo.Size = new Size(215, 23);
            cbo.TabIndex = 20;
            cbo.SelectedIndexChanged += cbo_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 163);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(654, 161);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(526, 263);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(211, 27);
            button3.TabIndex = 25;
            button3.Text = "Add Configuration";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 212);
            label4.Name = "label4";
            label4.Size = new Size(232, 19);
            label4.TabIndex = 3;
            label4.Text = "Confirm Selected Complier Path:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 209);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 23);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // browseButtonnn
            // 
            browseButtonnn.BackColor = Color.Thistle;
            browseButtonnn.Font = new Font("Microsoft Sans Serif", 10F);
            browseButtonnn.Location = new Point(526, 209);
            browseButtonnn.Margin = new Padding(3, 2, 3, 2);
            browseButtonnn.Name = "browseButtonnn";
            browseButtonnn.Size = new Size(123, 22);
            browseButtonnn.TabIndex = 17;
            browseButtonnn.Text = "Browse Files";
            browseButtonnn.TextAlign = ContentAlignment.MiddleLeft;
            browseButtonnn.UseVisualStyleBackColor = false;
            browseButtonnn.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(654, 209);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 24;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form_Configuration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(760, 333);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(cbo);
            Controls.Add(browseButtonnn);
            Controls.Add(browseFiles_button);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(saveConfig);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private BindingSource bindingSource1;
        private ComboBox cbo;
        private TextBox textBox3;
        private Button button1;
        private Button button3;
        private Label label4;
        private TextBox textBox4;
        private Button browseButtonnn;
        private Button button2;
    }
}