namespace BerkazyHalka
{
    partial class Form_HomePage
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            WelcomeText = new Label();
            homeScreenInstructions = new Label();
            homeScreenInstructions2 = new Label();
            labelPastAssignments = new Label();
            createNewAssignmentButton = new Button();
            viewTheAssignmentButton = new Button();
            viewConfigurationsButton = new Button();
            dataGridView1 = new DataGridView();
            backgroundPanelForListView = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            backgroundPanelForListView.SuspendLayout();
            SuspendLayout();
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
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1221, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "helpMenuStrip";
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.BackColor = Color.FromArgb(36, 36, 36);
            WelcomeText.Font = new Font("Cambria", 16.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeText.ForeColor = Color.White;
            WelcomeText.Location = new Point(10, 47);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(242, 27);
            WelcomeText.TabIndex = 1;
            WelcomeText.Text = "Welcome to EasyAssign.";
            // 
            // homeScreenInstructions
            // 
            homeScreenInstructions.AutoSize = true;
            homeScreenInstructions.Font = new Font("Cambria", 12F);
            homeScreenInstructions.Location = new Point(10, 156);
            homeScreenInstructions.Name = "homeScreenInstructions";
            homeScreenInstructions.Size = new Size(273, 19);
            homeScreenInstructions.TabIndex = 2;
            homeScreenInstructions.Text = "Here are some operations you can do.";
            homeScreenInstructions.Click += homeScreenInstructions_Click;
            // 
            // homeScreenInstructions2
            // 
            homeScreenInstructions2.AutoSize = true;
            homeScreenInstructions2.Font = new Font("Cambria", 11F);
            homeScreenInstructions2.Location = new Point(10, 88);
            homeScreenInstructions2.Name = "homeScreenInstructions2";
            homeScreenInstructions2.Size = new Size(359, 17);
            homeScreenInstructions2.TabIndex = 3;
            homeScreenInstructions2.Text = "For further help, click on the 'Help' button at the top left.";
            homeScreenInstructions2.Click += label1_Click;
            // 
            // labelPastAssignments
            // 
            labelPastAssignments.AutoSize = true;
            labelPastAssignments.Font = new Font("Cambria", 15F);
            labelPastAssignments.Location = new Point(10, 27);
            labelPastAssignments.Name = "labelPastAssignments";
            labelPastAssignments.Size = new Size(149, 23);
            labelPastAssignments.TabIndex = 6;
            labelPastAssignments.Text = "Assignment List";
            labelPastAssignments.Click += labelPastAssignments_Click;
            // 
            // createNewAssignmentButton
            // 
            createNewAssignmentButton.BackColor = Color.FromArgb(192, 192, 255);
            createNewAssignmentButton.Font = new Font("Cambria", 12F, FontStyle.Bold);
            createNewAssignmentButton.ForeColor = SystemColors.ActiveCaptionText;
            createNewAssignmentButton.Location = new Point(10, 194);
            createNewAssignmentButton.Margin = new Padding(3, 2, 3, 2);
            createNewAssignmentButton.Name = "createNewAssignmentButton";
            createNewAssignmentButton.Size = new Size(223, 37);
            createNewAssignmentButton.TabIndex = 7;
            createNewAssignmentButton.Text = "Create New Assignment";
            createNewAssignmentButton.UseVisualStyleBackColor = false;
            createNewAssignmentButton.Click += createNewAssignmentButton_Click;
            // 
            // viewTheAssignmentButton
            // 
            viewTheAssignmentButton.BackColor = Color.WhiteSmoke;
            viewTheAssignmentButton.Font = new Font("Cambria", 12F, FontStyle.Bold);
            viewTheAssignmentButton.ForeColor = Color.Black;
            viewTheAssignmentButton.Location = new Point(718, 393);
            viewTheAssignmentButton.Margin = new Padding(3, 2, 3, 2);
            viewTheAssignmentButton.Name = "viewTheAssignmentButton";
            viewTheAssignmentButton.Size = new Size(210, 28);
            viewTheAssignmentButton.TabIndex = 9;
            viewTheAssignmentButton.Text = "View The Assignment";
            viewTheAssignmentButton.UseVisualStyleBackColor = false;
            viewTheAssignmentButton.Click += viewTheAssignmentButton_Click;
            // 
            // viewConfigurationsButton
            // 
            viewConfigurationsButton.BackColor = Color.Thistle;
            viewConfigurationsButton.Font = new Font("Cambria", 12F, FontStyle.Bold);
            viewConfigurationsButton.ForeColor = SystemColors.ActiveCaptionText;
            viewConfigurationsButton.Location = new Point(10, 260);
            viewConfigurationsButton.Margin = new Padding(3, 2, 3, 2);
            viewConfigurationsButton.Name = "viewConfigurationsButton";
            viewConfigurationsButton.Size = new Size(223, 36);
            viewConfigurationsButton.TabIndex = 10;
            viewConfigurationsButton.Text = "View Configurations";
            viewConfigurationsButton.UseVisualStyleBackColor = false;
            viewConfigurationsButton.Click += viewConfigurationsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(38, 38, 38);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = SystemColors.ControlDarkDark;
            dataGridView1.Location = new Point(10, 81);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(737, 276);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // backgroundPanelForListView
            // 
            backgroundPanelForListView.BackColor = Color.FromArgb(32, 32, 32);
            backgroundPanelForListView.Controls.Add(label1);
            backgroundPanelForListView.Controls.Add(textBox1);
            backgroundPanelForListView.Controls.Add(dataGridView1);
            backgroundPanelForListView.Controls.Add(labelPastAssignments);
            backgroundPanelForListView.Location = new Point(447, 23);
            backgroundPanelForListView.Margin = new Padding(3, 2, 3, 2);
            backgroundPanelForListView.Name = "backgroundPanelForListView";
            backgroundPanelForListView.Size = new Size(758, 366);
            backgroundPanelForListView.TabIndex = 5;
            backgroundPanelForListView.Paint += backgroundPanelForListView_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(288, 31);
            label1.Name = "label1";
            label1.Size = new Size(168, 19);
            label1.TabIndex = 8;
            label1.Text = "Search For Assignment";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 52);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form_HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1221, 446);
            Controls.Add(viewConfigurationsButton);
            Controls.Add(viewTheAssignmentButton);
            Controls.Add(createNewAssignmentButton);
            Controls.Add(backgroundPanelForListView);
            Controls.Add(homeScreenInstructions2);
            Controls.Add(homeScreenInstructions);
            Controls.Add(WelcomeText);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_HomePage";
            Text = "EasyAssign";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            backgroundPanelForListView.ResumeLayout(false);
            backgroundPanelForListView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem helpToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label WelcomeText;
        private Label homeScreenInstructions;
        private Label homeScreenInstructions2;
        private Label labelPastAssignments;
        private Button createNewAssignmentButton;
        private Button viewTheAssignmentButton;
        private Button viewConfigurationsButton;
        private DataGridView dataGridView1;
        private Panel backgroundPanelForListView;
        private TextBox textBox1;
        private Label label1;
    }
}