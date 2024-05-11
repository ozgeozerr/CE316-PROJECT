using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form_StudentsChoosingWindow : Form
    {
        private List<string> unzippedFiles = new List<string>();
        private List<string> extractedFolders = new List<string>();
        private List<string> extractedFoldersPath = new List<string>();

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

                extractedFolders.Add(extractPath);
               
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

            if (unzippedFiles.Any())
            {
                foreach (string filePath in unzippedFiles)
                {
                    string fileName2 = Path.GetFileName(filePath);
                    
                    listBox1.Items.Add(fileName2);
                    
                }
                foreach(String filePath in extractedFolders)

                {
                    string fileFolder = Path.GetDirectoryName(filePath);
                    fileName.Items.Add(fileFolder);

                }
            }
            else
            {
                MessageBox.Show("No files to display.");
            }

            DisplayFolderNames();
        }

        private void DisplayFolderNames()
        {
            foreach (string folderPath in extractedFolders)
            {
                string folderName = Path.GetFileName(folderPath);
                MessageBox.Show($"Extracted folder name: {folderName}");
            }
        }

        private void fileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
