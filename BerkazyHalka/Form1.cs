using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Java Projects (*.java)|*.java|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                //Baþlangýç directory
                openFileDialog.InitialDirectory = @"Your\Java\Projects\Directory";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // pathi oku aktar
                        string javaProjectFilePath = openFileDialog.FileName;
                        string[] lines = File.ReadAllLines(javaProjectFilePath);

                        // text boxa yazdýr
                        myText.Text = string.Join(Environment.NewLine, lines);

                        // run butonunu çalýþýr vaziyete sok
                        button2.Enabled = true;
                        // path ismini tage storeladým
                        button2.Tag = javaProjectFilePath;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the file: " + ex.Message);
                    }
                }
            }
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



        private void button11_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "C Projects (*.c)|*.c|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                //Baþlangýç directory
                openFileDialog.InitialDirectory = @"C:\BerkazyHalka\CProjects";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // pathi oku aktar
                        string CProjectFilePath = openFileDialog.FileName;
                        string[] lines = File.ReadAllLines(CProjectFilePath);

                        // text boxa yazdýr
                        myText.Text = string.Join(Environment.NewLine, lines);

                        // run butonunu çalýþýr vaziyete sok
                        button111.Enabled = true;
                        // path ismini tage storeladým
                        button111.Tag = CProjectFilePath;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the file: " + ex.Message);
                    }
                }

            }

        }

        private void button111_Click(object sender, EventArgs e)
        {
            // Get the folder path from the button's tag
            string cProjectFolderPath = Path.GetDirectoryName(button111.Tag as string);

            if (!string.IsNullOrEmpty(cProjectFolderPath) && Directory.Exists(cProjectFolderPath))
            {
                try
                {
                    // Get all .c files in the folder
                    string[] cFiles = Directory.GetFiles(cProjectFolderPath, "*.c");

                    if (cFiles.Length > 0)
                    {
                        // Compile C files
                        string gccCommand = $"gcc \"{string.Join("\" \"", cFiles)}\" -o \"{cProjectFolderPath}\\output.exe\"";
                        System.Diagnostics.Process.Start("cmd.exe", $"/k {gccCommand} & pause");
                    }
                    else
                    {
                        MessageBox.Show("No C files found in the project folder.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error running the project: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("C project folder not found.");
            }
        }



        private void button2_Click_2(object sender, EventArgs e)
        {
            // depoladýðým pathi bu sefer rýunlamak için
            string javaProjectFolderPath = Path.GetDirectoryName(button2.Tag as string);

            if (!string.IsNullOrEmpty(javaProjectFolderPath) && Directory.Exists(javaProjectFolderPath))
            {
                try
                {
                    // Compile 
                    string javacCommand = $"javac -d \"{javaProjectFolderPath}\" \"{javaProjectFolderPath}\\*.java\"";
                    System.Diagnostics.Process.Start("cmd.exe", $"/c {javacCommand} & pause").WaitForExit();

                    //run   
                    string javaMainClassName = button2.Tag as string;
                    string javaCommand = $"java -cp \"{javaProjectFolderPath}\" {javaMainClassName}";
                    System.Diagnostics.Process.Start("cmd.exe", $"/c {javaCommand} & pause");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error running the project: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Java project folder not found.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
