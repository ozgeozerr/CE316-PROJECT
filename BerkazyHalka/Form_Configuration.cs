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

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(programminLanguage)
                || string.IsNullOrEmpty(selectedFilePathForComplierPath) || string.IsNullOrEmpty(selectedFilePathForSourceCode))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }




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

     
        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            programminLanguage = cbo.SelectedItem?.ToString();
            MessageBox.Show(programminLanguage);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = selectedFilePathForComplierPath;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = selectedFilePathForComplierPath;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {

                insertDatabase();
                this.Close();
            }
            
        }
        private void insertDatabase()
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var insertData = new SQLiteCommand($"INSERT INTO configuration(name,language_name,compiler_path,sourcecode) VALUES ('{textBox1.Text}', '{programminLanguage}','{textBox3.Text}','{textBox4.Text}');SELECT last_insert_rowid();", connection))
                {
                    try
                    {
                        connection.Open();
                        Form_HomePage.currentConfigID = Convert.ToInt32(insertData.ExecuteScalar());
                        
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Method to access the saved file path from outside the class

    }
}
