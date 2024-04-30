
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
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            button2 = new Button();
            button11 = new Button();
            button111 = new Button();
            myText = new RichTextBox();
            GoToMain = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
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
            // myText
            // 
            myText.Location = new Point(56, 375);
            myText.Name = "myText";
            myText.Size = new Size(1233, 148);
            myText.TabIndex = 6;
            myText.Text = "Arkadaşlar bu formu şimdilik silmicem diğer formdan Tuşa tıklayınca bizim formlardan başlıyor. Bu formu başlangıç ekranı yapabilriiz";
            myText.TextChanged += myText_TextChanged;
            // 
            // GoToMain
            // 
            GoToMain.Location = new Point(469, 181);
            GoToMain.Name = "GoToMain";
            GoToMain.Size = new Size(365, 188);
            GoToMain.TabIndex = 11;
            GoToMain.Text = "Diğer sekmeye git";
            GoToMain.UseVisualStyleBackColor = true;
            GoToMain.Click += GoToMain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 659);
            Controls.Add(GoToMain);
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
        private OpenFileDialog openFileDialog1;
        private Button button1111;
        private Button button3;
        private Button button2;
        private Button button11;
        private Button button111;
        private RichTextBox myText;
        private Button GoToMain;
    }
}
