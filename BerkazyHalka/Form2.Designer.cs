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
            newAssignmentButton = new Button();
            OpenAssignmentButton = new Button();
            label1 = new Label();
            treeView1 = new TreeView();
            openSelected = new Button();
            SuspendLayout();
            // 
            // newAssignmentButton
            // 
            newAssignmentButton.Location = new Point(1020, 37);
            newAssignmentButton.Name = "newAssignmentButton";
            newAssignmentButton.Size = new Size(237, 29);
            newAssignmentButton.TabIndex = 0;
            newAssignmentButton.Text = "New Assignment";
            newAssignmentButton.UseVisualStyleBackColor = true;
            newAssignmentButton.Click += newAssignmentButton_Click;
            // 
            // OpenAssignmentButton
            // 
            OpenAssignmentButton.Location = new Point(1263, 37);
            OpenAssignmentButton.Name = "OpenAssignmentButton";
            OpenAssignmentButton.Size = new Size(237, 29);
            OpenAssignmentButton.TabIndex = 1;
            OpenAssignmentButton.Text = "Open Assignment";
            OpenAssignmentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 37);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 2;
            label1.Text = "IAE";
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.MenuHighlight;
            treeView1.Location = new Point(652, 116);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(356, 490);
            treeView1.TabIndex = 3;
            // 
            // openSelected
            // 
            openSelected.Location = new Point(1355, 612);
            openSelected.Name = "openSelected";
            openSelected.Size = new Size(145, 29);
            openSelected.TabIndex = 4;
            openSelected.Text = "open Selected Assignment";
            openSelected.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 768);
            Controls.Add(openSelected);
            Controls.Add(treeView1);
            Controls.Add(label1);
            Controls.Add(OpenAssignmentButton);
            Controls.Add(newAssignmentButton);
            Name = "Form2";
            Text = "IAE";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newAssignmentButton;
        private Button OpenAssignmentButton;
        private Label label1;
        private TreeView treeView1;
        private Button openSelected;
    }
}