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

                extractedFoldersPath.Add(extractPath);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error extracting files from {zipFilePath}: {ex.Message}");
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DisplayFolderNames();
            listBox1.Items.Clear();
            fileName.Items.Clear();

            if (unzippedFiles.Any())
            {
                foreach (string filePath in unzippedFiles)
                {
                    string fileName2 = Path.GetFileName(filePath);
                    string fileName3=Path.GetFullPath(filePath);

                    listBox1.Items.Add(fileName2);
                    path.Items.Add(fileName3);

                }
                foreach (String fileName2 in extractedFoldersName)

                {

                    fileName.Items.Add(fileName2);

                }
            }
            else
            {
                MessageBox.Show("No files to display.");
            }


        }

        private void DisplayFolderNames()
        {
            foreach (string folderPath in extractedFoldersPath)
            {
                string folderName = Path.GetFileName(folderPath);
                extractedFoldersName.Add(folderName);
                MessageBox.Show($"Extracted folder name: {folderName}");
            }
        }

        private void fileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void path_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
