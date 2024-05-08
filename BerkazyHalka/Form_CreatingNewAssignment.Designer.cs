namespace BerkazyHalka
{
    partial class Form_CreatingNewAssignment
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
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(869, 28);
            menuStrip1.TabIndex = 13;
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
            // Form_CreatingNewAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(869, 572);
            Controls.Add(menuStrip1);
            Name = "Form_CreatingNewAssignment";
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}