using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BerkazyHalka
{
    public partial class Form_StudentsChoosingWindow : Form
    {
        private List<string> unzippedFiles = new List<string>();
        private List<string> extractedFoldersPath = new List<string>();
        private List<string> extractedFoldersName = new List<string>();


        public Form_StudentsChoosingWindow()
        {
            InitializeComponent();
        }

        private void chooseAllStudents_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip Files (*.zip)|*.zip";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    ExtractFilesFromZip(file);
                   
                }

                MessageBox.Show("Contents of selected zip files added to the list.");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        String folder_nameDb;
        private void ExtractFilesFromZip(string zipFilePath)
        {
            try
            {
                string extractPath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(zipFilePath));
                string folderName = Path.GetFileNameWithoutExtension(zipFilePath);
              

                ZipFile.ExtractToDirectory(zipFilePath, extractPath);

                foreach (string extractedFile in Directory.GetFiles(extractPath))
                {
                    unzippedFiles.Add(extractedFile);
                }
                extractedFoldersName.Add(folderName);
                extractedFoldersPath.Add(extractPath);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error extracting files from {zipFilePath}: {ex.Message}");
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            fileName.Items.Clear();
            path.Items.Clear();

            if (unzippedFiles.Any())
            {
                for (int i = 0; i < unzippedFiles.Count; i++)
                {
                    string filePath = unzippedFiles[i];
                    string folderName = extractedFoldersName[i];

                    string fileName2 = Path.GetFileName(filePath);
                    string fileName3 = Path.GetFullPath(filePath);

                    listBox1.Items.Add(fileName2);
                    path.Items.Add(fileName3);
                    insertDatabase(folderName, fileName2, fileName3, "no result", Form_HomePage.currentAssignID);
                }

                foreach (string fileName2 in extractedFoldersName)
                {
                    fileName.Items.Add(fileName2);
                }
            }
            else
            {
                MessageBox.Show("No files to display.");
            }
        }

        private void insertDatabase(string name, string source_code, string path, string result, int assignment_id)
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var insertData = new SQLiteCommand($"INSERT INTO student(name,source_code,path,result,assignment_id) VALUES (@name, @source_code, @path, @result, @assignment_id)", connection))
                {
                    insertData.Parameters.AddWithValue("@name", name);
                    insertData.Parameters.AddWithValue("@source_code", source_code);
                    insertData.Parameters.AddWithValue("@path", path);
                    insertData.Parameters.AddWithValue("@result", result);
                    insertData.Parameters.AddWithValue("@assignment_id", Form_HomePage.currentAssignID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = insertData.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Added to SQL successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error inserting data into the database: " + err.Message);
                    }
                }
            }
        }



        private void DisplayFolderNames()
        {
            foreach (string folderPath in extractedFoldersPath)
            {
                string folderName = Path.GetFileName(folderPath);
                folder_nameDb = folderName;
                MessageBox.Show($"Extracted folder name: {folderName}");
            }
        }

        private void fileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void path_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
