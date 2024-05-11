using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkazyHalka
{

    public partial class Form4 : Form
    {
        public Form4()
        {
            MessageBox.Show("Result assing id:" + Form_HomePage.currentAssignID + "Config id:" + Form_HomePage.currentConfigID);
            InitializeComponent();
            listStudents();
        }
        String selectedFileForZipEx;
        String extractPath;
        private void testAll_Click(object sender, EventArgs e)
        {
            string inputFile = "";
            string outputFile = "";
            string compilerPath = "";
            string language = "";
            int studentCount = 99;

            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var readData = new SQLiteCommand("SELECT input_folder,expected_folder FROM assignment WHERE id = @currentAssignmentID", connection))
                {
                    readData.Parameters.AddWithValue("@currentAssignmentID", Form_HomePage.currentAssignID);

                    try
                    {
                        connection.Open();
                        using (SQLiteDataReader reader = readData.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                inputFile = reader["input_folder"].ToString();
                                outputFile = reader["expected_folder"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No configuration found for the specified ID.");
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var readData = new SQLiteCommand("SELECT compiler_path,language_name FROM configuration WHERE id = @currentConfigurationID", connection))
                {
                    readData.Parameters.AddWithValue("@currentConfigurationID", Form_HomePage.currentConfigID);

                    try
                    {
                        connection.Open();
                        using (SQLiteDataReader reader = readData.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                inputFile = reader["compiler_path"].ToString();
                                outputFile = reader["language_name"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No configuration found for the specified ID.");
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var command = new SQLiteCommand("SELECT COUNT(*) FROM student WHERE assignment_id = @currentAssignID", connection))
                {
                    command.Parameters.AddWithValue("@currentAssignID", Form_HomePage.currentAssignID);

                    try
                    {
                        connection.Open();
                        studentCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            string[] studentFiles = new string[studentCount];
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var command = new SQLiteCommand("SELECT path FROM student WHERE assignment_id = @currentAssignID", connection))
                {
                    command.Parameters.AddWithValue("@currentAssignID", Form_HomePage.currentAssignID);

                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            int i = 0;
                            studentFiles = new string[studentCount]; // Initialize the array with the correct size

                            while (reader.Read() && i < studentCount)
                            {
                                studentFiles[i] = reader["path"].ToString();
                                i++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            for (int i = 0;i<studentCount;i++)
            {
                trueLie.trueFalse(inputFile, outputFile, studentFiles[i], compilerPath, language); // Bu Database Kısmına Kaç Doğru Y da Çalışıyor mu Onu Gönderecek
            }
        }

        private void selectAStudent_Click(object sender, EventArgs e)
        {
            Form_StudentsChoosingWindow form = new Form_StudentsChoosingWindow();
            form.Show();
            this.Hide();

        }

        private void createManual_Click(object sender, EventArgs e)
        {

        }

        private void zipButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileForZipEx = openFileDialog.FileName;
                MessageBox.Show(selectedFileForZipEx);

            }

        }

        private void exButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string extractPath = folderBrowserDialog.SelectedPath;
                MessageBox.Show(extractPath);

                zipExtractor zipper = new zipExtractor();
                zipper.Extract(selectedFileForZipEx, extractPath);
            }
        }

        private Form_StudentsChoosingWindow StudentsChoosingWindow;

        private void button1_Click(object sender, EventArgs e)
        {
            if (StudentsChoosingWindow == null || StudentsChoosingWindow.Visible == false)
            {
                StudentsChoosingWindow = new Form_StudentsChoosingWindow();
                StudentsChoosingWindow.FormClosed += StudentsChoosingWindow_FormClosed;
                this.Enabled = false;
                StudentsChoosingWindow.Show();
            }
        }

        private void StudentsChoosingWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        static DataTable dt;
        public void listStudents()
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var readData = new SQLiteCommand("SELECT * FROM student WHERE assignment_id = @currentAssignID", connection))
                {
                    readData.Parameters.AddWithValue("@currentAssignID", Form_HomePage.currentAssignID);

                    dataGridView1.ReadOnly = true;
                    try
                    {
                        connection.Open();
                        dt = new DataTable();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(readData))
                        {
                            adapter.Fill(dt);
                        }
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the student table.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

    }
}



//oldu mu?