using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }


        //Ahmet deneme
        //Mete deneme
        //Berkay deneme
        //Özge deneme
        //Barça deneme
        //Bir daha deniyorum
        //trekrar deniyorum
        // Ahmet Deneme
        //Berkay Deneme2
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

                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string javaProjectFilePath = openFileDialog.FileName;
                        string[] lines = File.ReadAllLines(javaProjectFilePath);

                        myText.Text = string.Join(Environment.NewLine, lines);
                        button2.Enabled = true;
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
            string cFilePath = button111.Tag as string;
            compilerClass.cProject(cFilePath);
        }



        private void button2_Click_2(object sender, EventArgs e)
        {
            string javaFilePath = button2.Tag as string;
            compilerClass.javaProject(javaFilePath);
                       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void myText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
