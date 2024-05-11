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
            helpToolStripMenuItem.Size = new Size(57, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "helpMenuStrip";
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.BackColor = Color.FromArgb(36, 36, 36);
            WelcomeText.Font = new Font("Cambria", 16.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeText.ForeColor = Color.White;
            WelcomeText.Location = new Point(22, 73);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(300, 34);
            WelcomeText.TabIndex = 1;
            WelcomeText.Text = "Welcome to EasyAssign.";
            // 
            // homeScreenInstructions
            // 
            homeScreenInstructions.AutoSize = true;
            homeScreenInstructions.Font = new Font("Cambria", 12F);
            homeScreenInstructions.Location = new Point(12, 193);
            homeScreenInstructions.Name = "homeScreenInstructions";
            homeScreenInstructions.Size = new Size(333, 23);
            homeScreenInstructions.TabIndex = 2;
            homeScreenInstructions.Text = "Here are some operations you can do.";
            homeScreenInstructions.Click += homeScreenInstructions_Click;
            // 
            // homeScreenInstructions2
            // 
            homeScreenInstructions2.AutoSize = true;
            homeScreenInstructions2.Font = new Font("Cambria", 11F);
            homeScreenInstructions2.Location = new Point(12, 233);
            homeScreenInstructions2.Name = "homeScreenInstructions2";
            homeScreenInstructions2.Size = new Size(458, 22);
            homeScreenInstructions2.TabIndex = 3;
            homeScreenInstructions2.Text = "For further help, click on the 'Help' button at the top left.";
            homeScreenInstructions2.Click += label1_Click;
            // 
            // labelPastAssignments
            // 
            labelPastAssignments.AutoSize = true;
            labelPastAssignments.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPastAssignments.Location = new Point(186, 7);
            labelPastAssignments.Name = "labelPastAssignments";
            labelPastAssignments.Size = new Size(168, 27);
            labelPastAssignments.TabIndex = 6;
            labelPastAssignments.Text = "Assignment List";
            labelPastAssignments.Click += labelPastAssignments_Click;
            // 
            // createNewAssignmentButton
            // 
            createNewAssignmentButton.BackColor = Color.Thistle;
            createNewAssignmentButton.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createNewAssignmentButton.ForeColor = SystemColors.ActiveCaptionText;
            createNewAssignmentButton.Location = new Point(12, 299);
            createNewAssignmentButton.Name = "createNewAssignmentButton";
            createNewAssignmentButton.Size = new Size(216, 49);
            createNewAssignmentButton.TabIndex = 7;
            createNewAssignmentButton.Text = "Create New Assignment";
            createNewAssignmentButton.UseVisualStyleBackColor = false;
            createNewAssignmentButton.Click += createNewAssignmentButton_Click;
            // 
            // viewTheAssignmentButton
            // 
            viewTheAssignmentButton.BackColor = Color.Thistle;
            viewTheAssignmentButton.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            viewTheAssignmentButton.ForeColor = SystemColors.ActiveCaptionText;
            viewTheAssignmentButton.Location = new Point(747, 535);
            viewTheAssignmentButton.Name = "viewTheAssignmentButton";
            viewTheAssignmentButton.Size = new Size(240, 37);
            viewTheAssignmentButton.TabIndex = 9;
            viewTheAssignmentButton.Text = "View The Assignment";
            viewTheAssignmentButton.UseVisualStyleBackColor = false;
            // 
            // viewConfigurationsButton
            // 
            viewConfigurationsButton.BackColor = Color.Thistle;
            viewConfigurationsButton.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            viewConfigurationsButton.ForeColor = SystemColors.ActiveCaptionText;
            viewConfigurationsButton.Location = new Point(12, 373);
            viewConfigurationsButton.Name = "viewConfigurationsButton";
            viewConfigurationsButton.Size = new Size(216, 48);
            viewConfigurationsButton.TabIndex = 10;
            viewConfigurationsButton.Text = "View Configurations";
            viewConfigurationsButton.UseVisualStyleBackColor = false;
            viewConfigurationsButton.Click += viewConfigurationsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(12, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(529, 371);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // backgroundPanelForListView
            // 
            backgroundPanelForListView.BackColor = Color.FromArgb(32, 32, 32);
            backgroundPanelForListView.Controls.Add(textBox1);
            backgroundPanelForListView.Controls.Add(dataGridView1);
            backgroundPanelForListView.Controls.Add(labelPastAssignments);
            backgroundPanelForListView.Location = new Point(597, 31);
            backgroundPanelForListView.Name = "backgroundPanelForListView";
            backgroundPanelForListView.Size = new Size(544, 488);
            backgroundPanelForListView.TabIndex = 5;
            backgroundPanelForListView.Paint += backgroundPanelForListView_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form_HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1184, 593);
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
    }
}