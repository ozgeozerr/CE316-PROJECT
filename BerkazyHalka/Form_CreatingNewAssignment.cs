﻿using System;
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
        DateTime currentDateTime = DateTime.Now;

        public Form_CreatingNewAssignment()
        {

            InitializeComponent();
            if (Form_HomePage.currentConfigID > 0) 
            {
                
            }
            else {
                
            }


        }
        private string selectedFilePath;
        private string selectedFilePathForOutput;
        private string assignmentName;

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textb_assignName.Text)
                || string.IsNullOrWhiteSpace(textb_inputFolder.Text)
                || string.IsNullOrWhiteSpace(textb_expectedFolder.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            Form_Configuration form = new Form_Configuration();
            form.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form_HomePage form = new Form_HomePage();
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
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var insertData = new SQLiteCommand($"INSERT INTO assignment(name, input_folder, expected_folder,date,configuration_id) VALUES ('{textb_assignName.Text}', '{textb_inputFolder.Text}','{textb_expectedFolder.Text}','{currentDateTime}','{Form_HomePage.currentConfigID}'); SELECT last_insert_rowid();", connection))
                {
                    try
                    {
                        connection.Open();
                        Form_HomePage.currentAssignID = Convert.ToInt32(insertData.ExecuteScalar());
                        MessageBox.Show("Added to SQL successfully!" + Form_HomePage.currentAssignID);
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
            if (ValidateInputs())
            {
                MessageBox.Show(textb_assignName.Text);
                insertDatabase();
                Form4 form = new Form4();
                form.Show();
                this.Close();
            }


        }

        private void textb_expectedFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePath);
            }


        }

        private void saveInput_Click(object sender, EventArgs e)
        {
            textb_inputFolder.Text = selectedFilePath;
        }

        private void saveOutput_Click(object sender, EventArgs e)
        {
            textb_expectedFolder.Text = selectedFilePathForOutput;
        }

        private void browseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePathForOutput = openFileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePathForOutput);
            }

        }
        private Form_ConfigurationView configurationForm;

        private void createNewConfig_Click(object sender, EventArgs e)
        {
            if (configurationForm == null || configurationForm.Visible == false)
            {
                configurationForm = new Form_ConfigurationView();
                configurationForm.FormClosed += ConfigurationForm_FormClosed;
                this.Enabled = false;
                configurationForm.Show();
            }
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form_HomePage.currentConfigID > 0) 
            {
               
            }
            else
            {
                
            }

            this.Enabled = true;
        }

       
    }
}
