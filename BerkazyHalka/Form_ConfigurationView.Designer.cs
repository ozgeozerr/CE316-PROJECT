namespace BerkazyHalka
{
    partial class Form_ConfigurationView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConfigurationView));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ımportButton = new Button();
            selectConfiguration = new Button();
            textBox1 = new TextBox();
            exportButton = new Button();
            label1 = new Label();
            go_back2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(29, 80);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(724, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Cambria", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(152, 413);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(107, 28);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(275, 412);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(107, 28);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(646, 413);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(107, 28);
            button3.TabIndex = 3;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ımportButton
            // 
            ımportButton.BackColor = Color.Thistle;
            ımportButton.Font = new Font("Segoe UI", 12F);
            ımportButton.ForeColor = Color.Black;
            ımportButton.Location = new Point(401, 413);
            ımportButton.Margin = new Padding(3, 2, 3, 2);
            ımportButton.Name = "ımportButton";
            ımportButton.Size = new Size(107, 28);
            ımportButton.TabIndex = 4;
            ımportButton.Text = "Import";
            ımportButton.UseVisualStyleBackColor = false;
            ımportButton.Click += ımportButton_Click;
            // 
            // selectConfiguration
            // 
            selectConfiguration.BackColor = Color.DarkSeaGreen;
            selectConfiguration.Font = new Font("Segoe UI", 12F);
            selectConfiguration.ForeColor = Color.Black;
            selectConfiguration.Location = new Point(29, 412);
            selectConfiguration.Margin = new Padding(3, 2, 3, 2);
            selectConfiguration.Name = "selectConfiguration";
            selectConfiguration.Size = new Size(107, 28);
            selectConfiguration.TabIndex = 5;
            selectConfiguration.Text = "Select";
            selectConfiguration.UseVisualStyleBackColor = false;
            selectConfiguration.Click += selectConfiuration_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 46);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.Thistle;
            exportButton.Font = new Font("Segoe UI", 12F);
            exportButton.ForeColor = Color.Black;
            exportButton.Location = new Point(525, 413);
            exportButton.Margin = new Padding(3, 2, 3, 2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(107, 28);
            exportButton.TabIndex = 7;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(218, 22);
            label1.TabIndex = 17;
            label1.Text = "Search For Configurations";
            label1.Click += label1_Click;
            // 
            // go_back2
            // 
            go_back2.BackColor = Color.Thistle;
            go_back2.Font = new Font("Segoe UI", 12F);
            go_back2.ForeColor = Color.Black;
            go_back2.Location = new Point(646, 40);
            go_back2.Margin = new Padding(3, 2, 3, 2);
            go_back2.Name = "go_back2";
            go_back2.Size = new Size(107, 28);
            go_back2.TabIndex = 18;
            go_back2.Text = "Go Back";
            go_back2.UseVisualStyleBackColor = false;
            go_back2.Click += go_back2_Click;
            // 
            // Form_ConfigurationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(792, 477);
            Controls.Add(go_back2);
            Controls.Add(label1);
            Controls.Add(exportButton);
            Controls.Add(textBox1);
            Controls.Add(selectConfiguration);
            Controls.Add(ımportButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_ConfigurationView";
            Text = "EasyAssign";
            Load += Form_ConfigurationView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button ımportButton;
        private Button selectConfiguration;
        private TextBox textBox1;
        private Button exportButton;
        private Label label1;
        private Button go_back2;
    }
}