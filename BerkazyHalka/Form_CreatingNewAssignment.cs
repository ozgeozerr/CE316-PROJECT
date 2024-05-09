using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BerkazyHalka
{
    public partial class Form_CreatingNewAssignment : Form
    {
        public Form_CreatingNewAssignment()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form_Configuration form = new Form_Configuration();
            form.Show();
            this.Hide();
        }

        private void Form_CreatingNewAssignment_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void insertDatabase()
        {
            using (var connection = new SQLiteConnection(Form1.connectionPath))
            {
                using (var insertData = new SQLiteCommand($"INSERT INTO assignment(name, input_folder, expected_folder) VALUES ('{textb_assignName.Text}', '{textb_inputFolder.Text}','{textb_expectedFolder.Text}')", connection))
                {
                    try
                    {
                        connection.Open();
                        insertData.ExecuteNonQuery();
                        MessageBox.Show("Added to SQL successfully!");
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

        private void textb_inputFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAssignment_Click(object sender, EventArgs e)
        {
            insertDatabase();
        }

        private void textb_expectedFolder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
