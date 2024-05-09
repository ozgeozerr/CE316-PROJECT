using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BerkazyHalka
{
    public partial class Form_Configuration : Form
    {
        public Form_Configuration()
        {
            InitializeComponent();
        }
        static String savedFilePath;

        private String selectedFilePathForComplierPath;
        private String selectedFilePathForSourceCode;
        private String configName;
        private String programminLanguage;



        private void browseFiles_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePathForComplierPath = openFileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePathForComplierPath);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePathForSourceCode = openFileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePathForSourceCode);
            }

        }

        private void Form_Configuration_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form_CreatingNewAssignment form = new Form_CreatingNewAssignment();
            form.Show();
            this.Hide();
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            configName = textBox1.Text;
            MessageBox.Show(configName);
            // Prompt the user to select a file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Variable";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the file name selected by the user
                    string fileName = saveFileDialog.FileName;

                    // Write the variable value to the selected file
                    File.WriteAllText(fileName, "adam");


                    // Save the path of the saved file
                    savedFilePath = fileName;

                    MessageBox.Show("Variable saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving variable: " + ex.Message);
                }
            }
            MessageBox.Show("aha bu çıktı:" + savedFilePath);
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            programminLanguage = cbo.SelectedItem?.ToString();
            MessageBox.Show(programminLanguage);
        }

        // Method to access the saved file path from outside the class

    }
}
