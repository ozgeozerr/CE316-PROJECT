using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BerkazyHalka
{
    public partial class Form1 : Form
    {
        



        public static Form1 instance;
        public Form1()
        {
            connectSql();
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
            string selectedPath = GetCompilerPathById(Form_HomePage.currentConfigID);
            // this is selected path
            //MessageBox.Show(selectedPath);
            compilerClass.javaProject(javaFilePath);

        }
        private string GetCompilerPathById(int configurationId)
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                string query = "SELECT compiler_path FROM configuration WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", configurationId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return result != null ? result.ToString() : null; // Return the compiler_path or null if not found
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error querying database: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void GoToMain_Click(object sender, EventArgs e)
        {
            Form_HomePage form2 = new Form_HomePage();
            form2.Show();
            this.Hide();
        }

        private void myText_TextChanged(object sender, EventArgs e)
        {

        }

        public static void connectSql()
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Sucess");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Connection Error" + err.Message);
                }
            }

        }

        private void denemeForBerkay_Click(object sender, EventArgs e)
        {
            Form_StudentsChoosingWindow form2=new Form_StudentsChoosingWindow();
            form2.Show();
            this.Hide();
        }
    }
}
