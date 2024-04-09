
namespace BerkazyHalka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            myText = new RichTextBox();
            button111 = new Button();
            button11 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(23, 12);
            button3.Name = "button3";
            button3.Size = new Size(162, 29);
            button3.TabIndex = 5;
            button3.Text = "Print The File For Java";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // myText
            // 
            myText.Location = new Point(12, 47);
            myText.Name = "myText";
            myText.Size = new Size(1233, 527);
            myText.TabIndex = 6;
            myText.Text = "";
            // 
            // button111
            // 
            button111.Location = new Point(567, 12);
            button111.Name = "button111";
            button111.Size = new Size(225, 29);
            button111.TabIndex = 9;
            button111.Text = "Run The File";
            button111.UseVisualStyleBackColor = true;
            button111.Click += button111_Click;
            // 
            // button11
            // 
            button11.Location = new Point(422, 12);
            button11.Name = "button11";
            button11.Size = new Size(139, 29);
            button11.TabIndex = 8;
            button11.Text = "Print The file For C";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button2
            // 
            button2.Location = new Point(200, 12);
            button2.Name = "button2";
            button2.Size = new Size(201, 29);
            button2.TabIndex = 10;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 586);
            Controls.Add(button2);
            Controls.Add(button11);
            Controls.Add(button111);
            Controls.Add(myText);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Login Form";
            ResumeLayout(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

#endregion
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private RichTextBox myText;
        private Button button111;
        private Button button11;
        private Button button1111;
        private Button button2;
    }
}
