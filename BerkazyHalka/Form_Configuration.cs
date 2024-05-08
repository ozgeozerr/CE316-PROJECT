using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form_Configuration : Form
    {
        public Form_Configuration()
        {
            InitializeComponent();
        }
        static String savedFilePath;

        private void browseComp_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void browseFiles_button_Click(object sender, EventArgs e)
        {


            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog2.FileName);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog2.FileName);
            }

        }

        private void Form_Configuration_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form_CreatingNewAssignment form_CreatingNewAssignment = new Form_CreatingNewAssignment();
            form_CreatingNewAssignment.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form_HomePage form = new Form_HomePage();
            form.Show();
            this.Hide();
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
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

        // Method to access the saved file path from outside the class

    }
}
