namespace BerkazyHalka
{
    partial class Form2
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
            backgroundPanelForListView = new Panel();
            labelPastAssignments = new Label();
            createNewAssignmentButton = new Button();
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
            WelcomeText.Location = new Point(12, 45);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(300, 34);
            WelcomeText.TabIndex = 1;
            WelcomeText.Text = "Welcome to EasyAssign.";
            // 
            // homeScreenInstructions
            // 
            homeScreenInstructions.AutoSize = true;
            homeScreenInstructions.Font = new Font("Cambria", 12F);
            homeScreenInstructions.Location = new Point(12, 103);
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
            homeScreenInstructions2.Location = new Point(12, 142);
            homeScreenInstructions2.Name = "homeScreenInstructions2";
            homeScreenInstructions2.Size = new Size(458, 22);
            homeScreenInstructions2.TabIndex = 3;
            homeScreenInstructions2.Text = "For further help, click on the 'Help' button at the top left.";
            homeScreenInstructions2.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.WhiteSmoke;
            listView1.Location = new Point(18, 18);
            listView1.Name = "listView1";
            listView1.Size = new Size(497, 388);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // backgroundPanelForListView
            // 
            backgroundPanelForListView.BackColor = Color.FromArgb(32, 32, 32);
            backgroundPanelForListView.Controls.Add(listView1);
            backgroundPanelForListView.Location = new Point(595, 103);
            backgroundPanelForListView.Name = "backgroundPanelForListView";
            backgroundPanelForListView.Size = new Size(532, 426);
            backgroundPanelForListView.TabIndex = 5;
            // 
            // labelPastAssignments
            // 
            labelPastAssignments.AutoSize = true;
            labelPastAssignments.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPastAssignments.Location = new Point(773, 91);
            labelPastAssignments.Name = "labelPastAssignments";
            labelPastAssignments.Size = new Size(168, 27);
            labelPastAssignments.TabIndex = 6;
            labelPastAssignments.Text = "Assignment List";
            labelPastAssignments.Click += labelPastAssignments_Click;
            // 
            // createNewAssignmentButton
            // 
            createNewAssignmentButton.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createNewAssignmentButton.ForeColor = SystemColors.ActiveCaptionText;
            createNewAssignmentButton.Location = new Point(12, 217);
            createNewAssignmentButton.Name = "createNewAssignmentButton";
            createNewAssignmentButton.Size = new Size(133, 31);
            createNewAssignmentButton.TabIndex = 7;
            createNewAssignmentButton.Text = "Create New Assignment";
            createNewAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1184, 593);
            Controls.Add(createNewAssignmentButton);
            Controls.Add(labelPastAssignments);
            Controls.Add(backgroundPanelForListView);
            Controls.Add(homeScreenInstructions2);
            Controls.Add(homeScreenInstructions);
            Controls.Add(WelcomeText);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
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
    }
}