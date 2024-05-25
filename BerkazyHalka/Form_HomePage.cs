using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkazyHalka
{
    public partial class Form_HomePage : Form
    {
        public static Form_HomePage instance;
        public static int currentAssignID;
        public static int currentConfigID;
        public static string connectionPath = $"Data Source={Application.StartupPath}\\assignment.db;Version=3;";

        public Form_HomePage()
        {
            InitializeComponent();
            instance = this;
            listAssignment();
            string databaseFilePath = $"{Application.StartupPath}\\assignment.db";
            FileAttributes attributes = File.GetAttributes(databaseFilePath);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                attributes &= ~FileAttributes.ReadOnly;
                File.SetAttributes(databaseFilePath, attributes);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeScreenInstructions_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPastAssignments_Click(object sender, EventArgs e)
        {

        }

        private void createNewAssignmentButton_Click(object sender, EventArgs e)
        {
            Form_CreatingNewAssignment form = new Form_CreatingNewAssignment();
            form.Show();
            this.Hide();
        }
        private Form_ConfigurationView configurationForm;

        private void viewConfigurationsButton_Click(object sender, EventArgs e)
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
            dataGridView1.Refresh();
            this.Enabled = true;
        }


        private void backgroundPanelForListView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        static DataTable dt_assign;
        public void listAssignment()
        {
            dataGridView1.ReadOnly = true;
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                using (var readData = new SQLiteCommand("SELECT * FROM assignment", connection))
                {
                    try
                    {
                        connection.Open();
                        dt_assign = new DataTable();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(readData))
                        {

                            adapter.Fill(dt_assign);
                        }
                        if (dt_assign.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt_assign;
                        }
                        else
                        {
                            MessageBox.Show("No data found in the configuration table.");
                        }
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
            string searchText = textBox1.Text.Trim();
            if (dt_assign != null)
            {

                DataView dv = dt_assign.DefaultView;
                dv.RowFilter = $"name LIKE '%{searchText}%'";
                dataGridView1.DataSource = dv.ToTable();
            }
        }
        private int GetConfigurationIdById(int assignId)
        {
            using (var connection = new SQLiteConnection(Form_HomePage.connectionPath))
            {
                string query = "SELECT configuration_id FROM assignment WHERE id = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", assignId);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return result != null && result != DBNull.Value ? Convert.ToInt32(result) : -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error querying database: " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        private void viewTheAssignmentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                Form_HomePage.currentAssignID = selectedId;
                Form_HomePage.currentConfigID = GetConfigurationIdById(Form_HomePage.currentAssignID);

                Form4 form = new Form4();
                form.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("Please select a row to view assignment.");
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
