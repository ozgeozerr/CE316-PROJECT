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
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            WelcomeText = new Label();
            homeScreenInstructions = new Label();
            homeScreenInstructions2 = new Label();
            listView1 = new ListView();
            AssignmentNameColumn = new ColumnHeader();
            DateColumn = new ColumnHeader();
            backgroundPanelForListView = new Panel();
            labelPastAssignments = new Label();
            createNewAssignmentButton = new Button();
            viewTheAssignmentButton = new Button();
            viewConfigurationsButton = new Button();
            menuStrip1.SuspendLayout();
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
            // listView1
            // 
            listView1.BackColor = Color.WhiteSmoke;
            listView1.Columns.AddRange(new ColumnHeader[] { AssignmentNameColumn, DateColumn });
            listView1.Location = new Point(13, 20);
            listView1.Name = "listView1";
            listView1.Size = new Size(508, 384);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // AssignmentNameColumn
            // 
            AssignmentNameColumn.Text = "Assignment Name";
            AssignmentNameColumn.Width = 120;
            // 
            // DateColumn
            // 
            DateColumn.Text = "Date";
            DateColumn.Width = 120;
            // 
            // backgroundPanelForListView
            // 
            backgroundPanelForListView.BackColor = Color.FromArgb(32, 32, 32);
            backgroundPanelForListView.Controls.Add(listView1);
            backgroundPanelForListView.Location = new Point(609, 103);
            backgroundPanelForListView.Name = "backgroundPanelForListView";
            backgroundPanelForListView.Size = new Size(532, 416);
            backgroundPanelForListView.TabIndex = 5;
            // 
            // labelPastAssignments
            // 
            labelPastAssignments.AutoSize = true;
            labelPastAssignments.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPastAssignments.Location = new Point(784, 93);
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
            // 
            // Form_HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1184, 593);
            Controls.Add(viewConfigurationsButton);
            Controls.Add(labelPastAssignments);
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
            backgroundPanelForListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem helpToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label WelcomeText;
        private Label homeScreenInstructions;
        private Label homeScreenInstructions2;
        private ListView listView1;
        private Panel backgroundPanelForListView;
        private Label labelPastAssignments;
        private Button createNewAssignmentButton;
        private Button viewTheAssignmentButton;
        private Button viewConfigurationsButton;
        private ColumnHeader AssignmentNameColumn;
        private ColumnHeader DateColumn;
    }
}