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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.Location = new Point(33, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(1026, 427);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Cambria", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(319, 549);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
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
            button2.Location = new Point(465, 549);
            button2.Name = "button2";
            button2.Size = new Size(122, 38);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(937, 614);
            button3.Name = "button3";
            button3.Size = new Size(122, 38);
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
            ımportButton.Location = new Point(610, 549);
            ımportButton.Name = "ımportButton";
            ımportButton.Size = new Size(122, 38);
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
            selectConfiguration.Location = new Point(937, 548);
            selectConfiguration.Name = "selectConfiguration";
            selectConfiguration.Size = new Size(122, 38);
            selectConfiguration.TabIndex = 5;
            selectConfiguration.Text = "Select";
            selectConfiguration.UseVisualStyleBackColor = false;
            selectConfiguration.Click += selectConfiuration_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.Thistle;
            exportButton.Font = new Font("Segoe UI", 12F);
            exportButton.ForeColor = Color.Black;
            exportButton.Location = new Point(755, 549);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(122, 38);
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
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(279, 28);
            label1.TabIndex = 17;
            label1.Text = "Search For Configurations";
            label1.Click += label1_Click;
            // 
            // go_back2
            // 
            go_back2.BackColor = Color.WhiteSmoke;
            go_back2.Font = new Font("Segoe UI", 12F);
            go_back2.ForeColor = Color.Black;
            go_back2.Location = new Point(33, 549);
            go_back2.Name = "go_back2";
            go_back2.Size = new Size(122, 38);
            go_back2.TabIndex = 18;
            go_back2.Text = "Go Back";
            go_back2.UseVisualStyleBackColor = false;
            go_back2.Click += go_back2_Click;
            // 
            // Form_ConfigurationView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1092, 679);
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
            Name = "Form_ConfigurationView";
            Text = "EasyAssign";
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